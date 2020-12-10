using System;
using System.Collections.Generic;
using System.Text;
using NoTenKee.Definition;

namespace NoTenKee.ReportWriter
{
    /// <summary>
    /// 帳票明細の縦方向優先カウンター.
    /// </summary>
    class NBodyCounter : BodyCounterBase
    {
        public NBodyCounter(ReportDefinition repDef) : base()
        {
            SetXIncremental(repDef.ZIncremental);
            SetXMax(repDef.ZRowMax);
            SetYIncremental(repDef.NIncremental);
            SetYMax(repDef.NRowMax);
        }
    }
}
