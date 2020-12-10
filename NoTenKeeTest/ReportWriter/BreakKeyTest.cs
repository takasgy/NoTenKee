using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NoTenKee.Definition;
using NoTenKee.ReportWriter;
using NoTenKee.AppException;

namespace NoTenKeeTest.ReportWriter
{
    [TestClass]
    public class BreakKeyTest
    {
        [TestMethod]
        public void TestMethod_CreateBreakKey_Exception()
        {
            try
            {
                ReportDefinition repDef = new ReportDefinition();
                repDef.BreakAction = ReportConst.BOOK_BREAK_ACTION_NEW_BOOK;
                IBreakKey breakKey = BreakKeyFactory.Create(repDef);
            }
            catch (NoTenKeeException e)
            {
                // Assert
                NoTenKeeException text = new NoTenKeeException("Break key is not set");
                StringAssert.Contains(e.Message, text.Message);
                return;
            }
            Assert.Fail("The expected exception was not thrown.");
        }

        [TestMethod]
        public void TestMethod_CompareTrue_BreakKeySheet()
        {
            ReportDefinition repDef = new ReportDefinition();
            repDef.BreakAction = ReportConst.BOOK_BREAK_ACTION_NEW_SHEET;
            string[] breakKeys = new string[] { "プレイクキー１", "プレイクキー２" };
            repDef.BreakKey = breakKeys;
            IBreakKey breakKey = BreakKeyFactory.Create(repDef);
            Dictionary<String, String> data = new Dictionary<String, String>();
            data.Add("プレイクキー１", "ABCDEFG001");
            data.Add("プレイクキー２", "XYZ0001");
            breakKey.SetKeyValues(data);
            Assert.IsTrue(breakKey.Compare(data));
        }

        [TestMethod]
        public void TestMethod_CompareNull_False_BreakKeySheet()
        {
            ReportDefinition repDef = new ReportDefinition();
            repDef.BreakAction = ReportConst.BOOK_BREAK_ACTION_NEW_SHEET;
            string[] breakKeys = new string[] { "プレイクキー１", "プレイクキー２" };
            repDef.BreakKey = breakKeys;
            IBreakKey breakKey = BreakKeyFactory.Create(repDef);
            Dictionary<String, String> data = new Dictionary<String, String>();
            data.Add("プレイクキー１", "ABCDEFG001");
            data.Add("プレイクキー２", "XYZ0001");
            Assert.IsFalse(breakKey.Compare(data));
        }

        [TestMethod]
        public void TestMethod_CompareValue_False_BreakKeySheet()
        {
            ReportDefinition repDef = new ReportDefinition();
            repDef.BreakAction = ReportConst.BOOK_BREAK_ACTION_NEW_SHEET;
            string[] breakKeys = new string[] { "プレイクキー１", "プレイクキー２" };
            repDef.BreakKey = breakKeys;
            IBreakKey breakKey = BreakKeyFactory.Create(repDef);
            Dictionary<String, String> data = new Dictionary<String, String>();
            data.Add("プレイクキー１", "ABCDEFG001");
            data.Add("プレイクキー２", "XYZ0001");
            breakKey.SetKeyValues(data);
            Dictionary<String, String> data2 = new Dictionary<String, String>();
            data2.Add("プレイクキー１", "ABCDEFG002");
            data2.Add("プレイクキー２", "XYZ0001");
            Assert.IsFalse(breakKey.Compare(data2));
        }

        [TestMethod]
        public void TestMethod_CompareTrue_BreakKeyBook()
        {
            ReportDefinition repDef = new ReportDefinition();
            repDef.BreakAction = ReportConst.BOOK_BREAK_ACTION_NEW_BOOK;
            string[] breakKeys = new string[] { "プレイクキー１", "プレイクキー２" };
            repDef.BreakKey = breakKeys;
            IBreakKey breakKey = BreakKeyFactory.Create(repDef);
            Dictionary<String, String> data = new Dictionary<String, String>();
            data.Add("プレイクキー１", "ABCDEFG001");
            data.Add("プレイクキー２", "XYZ0001");
            breakKey.SetKeyValues(data);
            Assert.IsTrue(breakKey.Compare(data));

        }

        [TestMethod]
        public void TestMethod_CompareNulll_False_BreakKeyBook()
        {
            ReportDefinition repDef = new ReportDefinition();
            repDef.BreakAction = ReportConst.BOOK_BREAK_ACTION_NEW_BOOK;
            string[] breakKeys = new string[] { "プレイクキー１", "プレイクキー２" };
            repDef.BreakKey = breakKeys;
            IBreakKey breakKey = BreakKeyFactory.Create(repDef);
            Dictionary<String, String> data = new Dictionary<String, String>();
            data.Add("プレイクキー１", "ABCDEFG001");
            data.Add("プレイクキー２", "XYZ0001");
            Assert.IsFalse(breakKey.Compare(data));
        }

        [TestMethod]
        public void TestMethod_CompareValue_False_BreakKeyBook()
        {
            ReportDefinition repDef = new ReportDefinition();
            repDef.BreakAction = ReportConst.BOOK_BREAK_ACTION_NEW_BOOK;
            string[] breakKeys = new string[] { "プレイクキー１", "プレイクキー２" };
            repDef.BreakKey = breakKeys;
            IBreakKey breakKey = BreakKeyFactory.Create(repDef);
            Dictionary<String, String> data = new Dictionary<String, String>();
            data.Add("プレイクキー１", "ABCDEFG001");
            data.Add("プレイクキー２", "XYZ0001");
            breakKey.SetKeyValues(data);
            Dictionary<String, String> data2 = new Dictionary<String, String>();
            data2.Add("プレイクキー１", "ABCDEFG001");
            data2.Add("プレイクキー２", "XYZ0002");
            Assert.IsFalse(breakKey.Compare(data2));
        }
    }
}
