using Microsoft.VisualStudio.TestTools.UnitTesting;
using NoTenKee.Definition;
using NoTenKee.ReportWriter;
using NoTenKee.AppException;

namespace NoTenKeeTest.ReportWriter
{
    [TestClass]
    public class BreakKeyFactoryTest
    {
        [TestMethod]
        public void TestMethod_CreateBreakKey_Sheet()
        {
            ReportDefinition repDef = new ReportDefinition();
            repDef.BreakAction = ReportConst.BOOK_BREAK_ACTION_NEW_SHEET;
            string[] breakKeys = new string[] { "プレイクキー１", "プレイクキー２" };
            repDef.BreakKey = breakKeys;
            IBreakKey breakKey = BreakKeyFactory.Create(repDef);
            Assert.AreEqual(breakKey.GetType().ToString(), "NoTenKee.ReportWriter.BreakKey");
        }

        [TestMethod]
        public void TestMethod_CreateBreakKey_Book()
        {
            ReportDefinition repDef = new ReportDefinition();
            repDef.BreakAction = ReportConst.BOOK_BREAK_ACTION_NEW_BOOK;
            string[] breakKeys = new string[] { "プレイクキー１", "プレイクキー２" };
            repDef.BreakKey = breakKeys;
            IBreakKey breakKey = BreakKeyFactory.Create(repDef);
            Assert.AreEqual(breakKey.GetType().ToString(), "NoTenKee.ReportWriter.BreakKey");
        }

        [TestMethod]
        public void TestMethod_CreateBreakKey_null()
        {
            ReportDefinition repDef = new ReportDefinition();
            repDef.BreakAction = null;
            string[] breakKeys = new string[] { };
            repDef.BreakKey = breakKeys;
            IBreakKey breakKey = BreakKeyFactory.Create(repDef);
            Assert.AreEqual(breakKey.GetType().ToString(), "NoTenKee.ReportWriter.DumyBreakKey");
        }

        [TestMethod]
        public void TestMethod_CreateBreakKey_no_processing()
        {
            ReportDefinition repDef = new ReportDefinition();
            string[] breakKeys = new string[] { };
            repDef.BreakKey = breakKeys;
            repDef.BreakAction = "no_processing";
            IBreakKey breakKey = BreakKeyFactory.Create(repDef);
            Assert.AreEqual(breakKey.GetType().ToString(), "NoTenKee.ReportWriter.DumyBreakKey");
        }
    }
}
