using System;
using NoTenKee.Definition;
using NoTenKee.FileOperator;
using NoTenKee.Utils;
using NoTenKee.ReportWriter;

namespace NoTenKee
{
    public class NotenKee
    {
        /// <summary>
        /// ファイル転記機能を提供する.
        /// 引数:
        /// 0) 環境定義XMLファイルパス
        /// 1) 帳票定義XMLファイルパス
        /// 2) データファイルパス
        /// 3) 出力先のパス
        /// </summary>
        public void Execute(String[] args)
        {
            // 引数チェック
            if (args.Length == 0)
            {
                throw new ArgumentException();
            }
            else if (args.Length < EnvConst.PARAM_MIN)
            {
                throw new ArgumentOutOfRangeException();
            }

            // アプリケーションの環境を取得する
            EnvUtil envUtil = EnvUtil.Instance;
            envUtil.SetValue(args[0]);

            // 引数から帳票定義と対象データを取得する
            ReportDefinition repDef = ReportDefineFactory.CreateDefinition(args[1]);

            // 入力ファイルの読込み
            IFileOperator opertor = new CsvFileOperator();
            opertor.SetRepDef(repDef);
            opertor.SetWriter(new ExcelReportWriter(repDef, args[3]));
            opertor.Read(args[2]);
        }
    }
}
