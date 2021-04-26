using System;
using System.Collections.Generic;
using NoTenKee.Definition;
using NoTenKee.Utils;
using System.IO;
using ClosedXML.Excel;

namespace NoTenKee.ReportWriter
{
    /// <summary>
    /// ExcelのBOOK帳票用ライター.
    /// </summary>
    class ExcelReportWriter : IReportWriter
    {
        // 帳票定義
        private ReportDefinition repDef;
        // 帳票出力先パス
        private String outputPath = null;
        // 帳票Book名
        private String bookName = null;
        // Book形式のファイルカウンタ
        private int bookCounter = 0;
        // Book内のシートカウンタ
        private int sheetCounter = 0;
        // 処理時のシステム日時
        private String createDate = DateTime.Now.ToString("yyyyMMddHHmmssffff");
        // 環境情報取得クラス
        private readonly EnvUtil envUtil = EnvUtil.Instance;

        // Book, Sheet用オブジェクト
        private IXLWorkbook book = null;
        private IXLWorksheet templateSheet = null;
        private IXLWorksheet activeSheet = null;
        private IBreakKey breakkey = null;
        private BodyCounterBase bodyCounter = null;

        public ExcelReportWriter(ReportDefinition repDef)
        {
            Initialize(repDef, envUtil.OutputPath);
        }

        public ExcelReportWriter(ReportDefinition repDef, String outputPath)
        {
            Initialize(repDef, outputPath);
        }

        /// <summary>
        /// 初期化処理.
        /// </summary>
        /// <param name="repDef">帳票定義</param>
        /// <param name="outputPath">Book出力先パス</param>
        private void Initialize(ReportDefinition repDef, String outputPath)
        {

            this.repDef = repDef;

            // 一覧の改ページ制御とカウンタの生成
            breakkey = BreakKeyFactory.Create(this.repDef);
            bodyCounter = BodyCounterFactory.Create(this.repDef);

            SetOutputPath(outputPath);
        }

        /// <summary>
        /// ExcelのBookファイルをテンプレートからコピーして新規作成する.
        /// 帳票のブレイクキーを作成する.
        /// </summary>
        public void CreateNewReport()
        {
            if (!File.Exists(envUtil.TemplatePath + repDef.TemplateName))
            {
                throw new FileNotFoundException("Template file not found!!");
            }

            bookName = repDef.FileName.Replace("yyyyMMddHHmmss", createDate).Replace("000", (++bookCounter).ToString());
            File.Copy(
                envUtil.TemplatePath + repDef.TemplateName,
                envUtil.TmporaryPath + bookName);

            this.Open();
        }

        /// <summary>
        /// 帳票にデータを設定する.
        /// </summary>
        /// <param name="args">帳票出力レコードの内容</param>
        public void SetReportData(String[] args)
        {
            // 帳票定義のキー項目とデータでDictionalyを作成
            Dictionary<String, String> recored = new Dictionary<String, String>();
            ReportItem item;

            repDef.HeaderItemList.InitializeIndex();
            while (repDef.HeaderItemList.HasNext())
            {
                item = repDef.HeaderItemList.Next();
                recored.Add(item.Name, args[item.Posiotion]);
            }

            repDef.BodyItemList.InitializeIndex();
            while (repDef.BodyItemList.HasNext())
            {
                item = repDef.BodyItemList.Next();
                recored.Add(item.Name, args[item.Posiotion]);
            }

            // Sheetに値を設定する
            if (BreakAction(recored))
            {
                SetColumnValue(repDef.HeaderItemList, recored);
            }
            SetBodyColumnValue(repDef.BodyItemList, recored);
            bodyCounter.CountUp();
        }

        /// <summary>
        /// シートにデータを貼り付ける.
        /// </summary>
        /// <param name="reportItemList">帳票項目定義</param>
        /// <param name="recored">データ</param>
        private void SetColumnValue(ReportItemList reportItemList, Dictionary<String, String> recored)
        {
            reportItemList.InitializeIndex();
            while (reportItemList.HasNext())
            {
                ReportItem item = reportItemList.Next();
                CellUtil.SetValue(activeSheet.Cell(item.PosiotionY, item.PosiotionX), recored[item.Name], item);
            }
        }

        /// <summary>
        /// シートの明細行にデータを貼り付ける.
        /// </summary>
        /// <param name="reportItemList">帳票項目定義</param>
        /// <param name="recored">データ</param>
        private void SetBodyColumnValue(ReportItemList reportItemList, Dictionary<String, String> recored)
        {
            reportItemList.InitializeIndex();
            while (reportItemList.HasNext())
            {
                ReportItem item = reportItemList.Next();
                CellUtil.SetValue(
                    activeSheet.Cell(
                        item.PosiotionY + bodyCounter.GetYPosition(), 
                        item.PosiotionX + bodyCounter.GetXPosition()), 
                    recored[item.Name], item);
            }
        }

        /// <summary>
        /// キーブレイク、ページブレイクの判定と実行.
        /// </summary>
        /// <param name="recored">データ</param>
        /// <returns>true:ページブレイクあり</returns>
        private bool BreakAction(Dictionary<String, String> recored)
        {
            if (!breakkey.Compare(recored))
            {
                if (repDef.BreakAction.Equals(ReportConst.BOOK_BREAK_ACTION_NEW_SHEET) &&
                    sheetCounter + 1 <= repDef.MaxSheet)
                {
                    Write();
                    AddSheet();
                }
                else
                {
                    SaveClose();
                    CreateNewReport();
                }
                return true;
            }
            else if (bodyCounter.IsPageBreak())
            {
                if (sheetCounter + 1 <= repDef.MaxSheet)
                {
                    Write();
                    AddSheet();
                }
                else
                {
                    SaveClose();
                    CreateNewReport();
                }
                return true;
            }
            return false;
        }

        /// <summary>
        /// 指定された帳票の出力先を設定する.
        /// </summary>
        /// <param name="outputPath">帳票の出力先パス</param>
        private void SetOutputPath(String outputPath)
        {
            if (Directory.Exists(outputPath))
            {
                this.outputPath = outputPath + EnvConst.DIR_DELIMITER;
            } else
            {
                throw new DirectoryNotFoundException("Output folder not found!!");
            }
        }

        /// <summary>
        /// ExcelのBookファイルをOpenする.
        /// </summary>
        private void Open()
        {
            book = new XLWorkbook(envUtil.TmporaryPath + bookName);
            templateSheet = this.book.Worksheets.Worksheet(repDef.TemplateSheet);
            sheetCounter = 0;
            AddSheet();
        }

        /// <summary>
        /// テンプレート用シートをコピーしてシートを追加する.
        /// 指定されたシート名を設定し、アクティブ状態にする.
        /// ボディ部のカウンタを初期化する.
        /// </summary>
        private void AddSheet()
        {
            activeSheet = templateSheet.CopyTo(
                repDef.SheetName.Replace("{page}", (++sheetCounter).ToString()));

            bodyCounter.Initialize();
        }

        /// <summary>
        /// テンプレート用シートを削除する.
        /// </summary>
        private void RemoveTemplateSheet()
        {
            book.Worksheets.Delete(templateSheet.Name);
        }

        /// <summary>
        /// Bookを更新する.
        /// </summary>
        private void Write()
        {
            book.Save();
        }

        /// <summary>
        /// ExcelのBookを閉じる.
        /// ファイル用の一時領域から帳票出力先フォルダへファイルを移動する.
        /// </summary>
        private void Close()
        {
            Write();
            book = null;

            File.Move(
                envUtil.TmporaryPath + bookName, outputPath + bookName);
        }

        /// <summary>
        /// ExcelのBookを保存して閉じる.
        /// </summary>
        public void SaveClose()
        {
            if (book != null)
            {
                RemoveTemplateSheet();
                Write();
                Close();
            }
        }
    }
}
