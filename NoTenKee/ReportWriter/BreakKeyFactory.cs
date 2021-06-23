using NoTenKee.Definition;

namespace NoTenKee.ReportWriter
{
    /// <summary>
    /// コントロールブレイクキーの生成.
    /// </summary>
    class BreakKeyFactory
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="repDef"></param>
        /// <returns></returns>
        public static IBreakKey Create(ReportDefinition repDef)
        {
            if (!string.IsNullOrEmpty(repDef.BreakAction) && !repDef.BreakAction.Equals(ReportConst.BOOK_BREAK_ACTION_NO_PROCESSING))
            {
                if (repDef.BreakAction.Equals(ReportConst.BOOK_BREAK_ACTION_NEW_SHEET) ||
                    repDef.BreakAction.Equals(ReportConst.BOOK_BREAK_ACTION_NEW_BOOK))
                {
                    return new BreakKey(repDef);
                }
            }
            return new DumyBreakKey();
        }
    }
}
