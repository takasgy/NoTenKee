using System;
using System.Collections.Generic;
using System.Text;

namespace NoTenKee.Definition
{
    /// <summary>
    /// 帳票定義情報の格納クラス.
    /// </summary>
    class ReportDefinition
    {
        // 帳票名
        private String reportName;
        // 帳票のタイプ
        private String type;
        // セルの参照タイプ(A1形式/R1C1形式)
        private String referenceFormat;
        // 帳票テンプレートファイル名
        private String templateName;
        // 帳票ファイル名
        private String fileName;
        // Book内最大Sheet数
        private int maxSheet;
        // Sheet名形式
        private String sheetName;
        // テンプレートSheet名
        private String templateSheet;
        // 一覧表の行名
        private String rowName;
        // 一覧表のタイプ(Z形式/N形式)
        private String listType;
        // 一覧表縦方向最大行数
        private int zRowMax;
        // 一覧表縦方向１行段数
        private int zIncremental;
        // 一覧表横方向最大行数
        private int nRowMax;
        // 一覧表横方向１行段数
        private int nIncremental;
        // キーブレイク時の動作
        private String breakAction;
        // ブレイクキー項目
        private String[] breakKey;
        // CSVセパレータ
        private String delimiter;
        // CSV文字列のクォーテーション
        private string quote;
        // CSVファイルのコードセット
        private Encoding codeset;
        // CSVファイルのヘッダ情報有無
        private bool csvHeader;
        // ヘッダ部、ボディ部、フッタ部の項目格納リスト
        private ReportItemList headerItemList;
        private ReportItemList bodyItemList;
        private ReportItemList footerItemList;

        public string ReportName { get => reportName; set => reportName = value; }
        public string Type { get => type; set => type = value.ToLower(); }
        public string ReferenceFormat { get => referenceFormat; set => referenceFormat = value; }
        public string TemplateName { get => templateName; set => templateName = value; }
        public string FileName { get => fileName; set => fileName = value; }
        public int MaxSheet { get => maxSheet; set => maxSheet = value; }
        public string RowName { get => rowName; set => rowName = value; }
        public string ListType { get => listType; set => listType = value.ToLower(); }
        public int ZRowMax { get => zRowMax; set => zRowMax = value; }
        public int ZIncremental { get => zIncremental; set => zIncremental = value; }
        public int NRowMax { get => nRowMax; set => nRowMax = value; }
        public int NIncremental { get => nIncremental; set => nIncremental = value; }
        public string BreakAction { get => breakAction; set => breakAction = value; }
        public string[] BreakKey { get => breakKey; set => breakKey = value; }
        public string TemplateSheet { get => templateSheet; set => templateSheet = value; }
        public string SheetName { get => sheetName; set => sheetName = value; }
        public string Delimiter { get => delimiter; set => delimiter = value; }
        public string Quote { get => quote; set => quote = value; }
        public Encoding Codeset { get => codeset; set => codeset = value; }
        public bool CsvHeader { get => csvHeader; set => csvHeader = value; }
        internal ReportItemList HeaderItemList { get => headerItemList; set => headerItemList = value; }
        internal ReportItemList BodyItemList { get => bodyItemList; set => bodyItemList = value; }
        internal ReportItemList FooterItemList { get => footerItemList; set => footerItemList = value; }
    }

}
