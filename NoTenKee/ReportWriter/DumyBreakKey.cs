using System;
using System.Collections.Generic;
using System.Text;

namespace NoTenKee.ReportWriter
{
    class DumyBreakKey : IBreakKey
    {
        private bool initFlag = true;
        public void SetKeyValues(Dictionary<String, String> data)
        {
            // does not process
        }

        public bool Compare(Dictionary<String, String> data)
        {
            if (initFlag)
            {
                initFlag = false;
                return false;
            }
            return true;
        }
    }
}
