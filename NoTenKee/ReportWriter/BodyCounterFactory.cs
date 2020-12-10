using NoTenKee.Definition;
using NoTenKee.AppException;

namespace NoTenKee.ReportWriter
{
    /// <summary>
    /// 帳票の明細行カウンターの生成.
    /// </summary>
    class BodyCounterFactory
    {
        /// <summary>
        /// 帳票の形式に対応した行カウンターを生成する.
        /// </summary>
        /// <param name="repDef"></param>
        /// <returns></returns>
        public static BodyCounterBase Create(ReportDefinition repDef)
        {
            if (repDef.Type == ReportConst.ROW_LIST_TYPE)
            {
                switch (repDef.ListType.ToUpper())
                {
                    case ReportConst.REPORT_TYPE_N:
                        return new NBodyCounter(repDef);
                    case ReportConst.REPORT_TYPE_Z:
                        return new ZBodyCounter(repDef);
                    default:
                        throw new NoTenKeeException("The Report type is not specified or the correct value is not set.");
                }
            } else
            {
                return new NBodyCounter(repDef);
            }
        }
    }

}
