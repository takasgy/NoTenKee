using System;
using System.Collections.Generic;
using System.Linq;
using NoTenKee.Definition;
using NoTenKee.ReportWriter;

namespace NoTenKee.FileOperator
{
    /// <summary>
    /// CSVファイルの操作クラス.
    /// </summary>
    class CsvFileOperator : IFileOperator
    {
        ReportDefinition repDef;
        IReportWriter reportWriter;

        public void SetRepDef(ReportDefinition repDef)
        {
            this.repDef = repDef;
        }

        public void SetWriter(IReportWriter reportWriter)
        {
            this.reportWriter = reportWriter;
        }

        public void Read(String filePath)
        {
            // CSVのheader行の対応
            bool headerFlg = String.Compare(
                ReportConst.CSV_CSV_HEADER_TRUE, repDef.CsvHeader.ToString(), true).Equals(0);

            IEnumerable<string[]> context =
                TextField.Context(filePath, repDef.Delimiter, repDef.Quote, headerFlg, repDef.Codeset);

            IEnumerable<string[]> results = from fields in context select (fields);


            foreach (var result in results)
            {
                    reportWriter.SetReportData(result);
            }
            reportWriter.SaveClose();
        }
    }
}
