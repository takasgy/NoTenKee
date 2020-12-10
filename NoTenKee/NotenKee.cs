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
        /// ファイル転機機能を提供する.
        /// 引数:
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

            // 引数から帳票定義と対象データを取得する
            ReportDefinition repDef = ReportDefineFactory.CreateDefinition(args[0]);

            // 入力ファイルの読込み
            IFileOperator opertor = new CsvFileOperator();
            opertor.SetRepDef(repDef);
            opertor.SetWriter(new ExcelReportWriter(repDef, args[2]));
            opertor.Read(args[1]);
        }
    }
}
