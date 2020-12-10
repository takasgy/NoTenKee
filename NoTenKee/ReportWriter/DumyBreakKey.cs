using System;
using System.Collections.Generic;
using System.Text;

namespace NoTenKee.ReportWriter
{
    class DumyBreakKey : IBreakKey
    {
        public void SetKeyValues(Dictionary<String, String> data)
        {
            // does not process
        }

        public bool Compare(Dictionary<String, String> data)
        {
            return false;
        }
    }
}
