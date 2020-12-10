using System;
using NoTenKee.Definition;
using NoTenKee.ReportWriter;

namespace NoTenKee.FileOperator
{
    /// <summary>
    /// ファイル操作クラス用インターフェース.
    /// </summary>
    interface IFileOperator
    {
        /// <summary>
        /// 帳票定義の設定.
        /// </summary>
        /// <param name="repDef"></param>
        void SetRepDef(ReportDefinition repDef);

        /// <summary>
        /// データの出力先の設定.
        /// </summary>
        /// <param name="reportWriter"></param>
        void SetWriter(IReportWriter reportWriter);

        /// <summary>
        /// ファイルの読み込み.
        /// </summary>
        /// <param name="filePath"></param>
        void Read(String filePath);
    }
}
