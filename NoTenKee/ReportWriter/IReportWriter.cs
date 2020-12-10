using System;
using System.Collections.Generic;
using System.Text;

namespace NoTenKee.ReportWriter
{
    /// <summary>
    /// 帳票出力用インターフェース.
    /// </summary>
    interface IReportWriter
    {
        void CreateNewReport();
        void SetReportData(String[] args);
        void SaveClose();
    }
}
