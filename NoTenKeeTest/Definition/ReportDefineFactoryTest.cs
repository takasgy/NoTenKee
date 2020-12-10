using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NoTenKee.Definition;
using System.IO;

namespace NoTenKeeTest.Definition
{
    [TestClass]
    public class ReportDefineFactoryTest
    {
        [TestMethod]
        public void TestMethod_FileNotExists()
        {
            try
            {
                ReportDefineFactory.CreateDefinition("test");
            }
            catch (FileNotFoundException e)
            {
                StringAssert.Contains(e.Message, "XML File not found!");
                return;
            }
            Assert.Fail("The expected exception was not thrown.");
        }
 
        [TestMethod]
        public void TestMethod_FileExists()
        {
            ReportDefinition repDef = ReportDefineFactory.CreateDefinition(ConstTest.XML_PATH + "Excel_Report_N1.xml");
            Assert.AreEqual(repDef.ReportName, "表形式帳票Ｎ１");
            Assert.AreEqual(repDef.Type, "shingle");
            Assert.AreEqual(repDef.ReferenceFormat, "A1");
            Assert.AreEqual(repDef.TemplateName, "templTEST_REPORT_N1.xlsx");
            Assert.AreEqual(repDef.FileName, "TEST_REPORT_N1_yyyyMMddHHmmss_000.xlsx");
            Assert.AreEqual(repDef.BreakKey[0], "ブレイクキー1");
            Assert.AreEqual(repDef.BreakKey[1], "ブレイクキー2");
            Assert.AreEqual(repDef.BreakAction, "newbook");
            Assert.AreEqual(repDef.MaxSheet, 5);
            Assert.AreEqual(repDef.SheetName, "P_{page}");
            Assert.AreEqual(repDef.TemplateSheet, "template");
            Assert.AreEqual(repDef.Delimiter, ",");
            Assert.IsNull(repDef.Quote);
            Assert.AreEqual(repDef.Codeset, Encoding.UTF8);
            Assert.IsFalse(repDef.CsvHeader);
            Assert.AreEqual(repDef.RowName, "_ROW");
            Assert.AreEqual(repDef.NRowMax, 5);
            Assert.AreEqual(repDef.NIncremental, 2);
            Assert.AreEqual(repDef.ZRowMax, 1);
            Assert.AreEqual(repDef.ZIncremental, 0);

            ReportItemList hlist = repDef.HeaderItemList;
            ReportItem hitem = hlist.Next();
            Assert.AreEqual(hitem.Name, "請求締日");
            Assert.AreEqual(hitem.DataType, "Datetime");
            Assert.AreEqual(hitem.DataFormat, "yyyymmdd");
            Assert.AreEqual(hitem.CellFormat, "yyyy/mm/dd");
            Assert.AreEqual(hitem.Posiotion, 0);
            Assert.AreEqual(hitem.PosiotionX, 2);
            Assert.AreEqual(hitem.PosiotionY, 1);

            ReportItemList rlist = repDef.BodyItemList;
            ReportItem ritem = rlist.Next();
            Assert.AreEqual(ritem.Name, "取引日付");
            Assert.AreEqual(ritem.DataType, "Datetime");
            Assert.AreEqual(ritem.DataFormat, "yyyymmdd");
            Assert.AreEqual(ritem.CellFormat, "yyyy/mm/dd");
            Assert.AreEqual(ritem.Posiotion, 4);
            Assert.AreEqual(ritem.PosiotionX, 1);
            Assert.AreEqual(ritem.PosiotionY, 7);
        }    }
}
