using System;
using System.Collections.Generic;
using System.Text;
using NoTenKee.Definition;

namespace NoTenKee.ReportWriter
{
    /// <summary>
    /// 帳票明細の横方向優先カウンター.
    /// </summary>
    class ZBodyCounter : BodyCounterBase
    {
        public ZBodyCounter(ReportDefinition repDef) : base()
        {
            SetXIncremental(repDef.NIncremental);
            SetXMax(repDef.NRowMax);
            SetYIncremental(repDef.ZIncremental);
            SetYMax(repDef.ZRowMax);
        }

        public override int GetXPosition()
        {
            return base.GetYPosition();
        }

        public override int GetYPosition()
        {
            return base.GetXPosition();
        }
    }
}
