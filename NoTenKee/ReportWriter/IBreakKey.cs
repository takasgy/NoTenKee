using System;
using System.Collections.Generic;
using System.Text;

namespace NoTenKee.ReportWriter
{
    /// <summary>
    /// 帳票のブレイクキー用インターフェース.
    /// </summary>
    interface IBreakKey
    {
        void SetKeyValues(Dictionary<String, String> data);
        bool Compare(Dictionary<String, String> data);
    }
}
