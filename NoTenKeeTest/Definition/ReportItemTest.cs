using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NoTenKee.Definition;

namespace NoTenKeeTest.Definition
{
    [TestClass]
    public class ReportItemTest
    {
        [TestMethod]
        public void TestMethod_CreateReportItem_String()
        {
            ReportItem item = new ReportItem();
            item.Name = "TestName";
            item.DataType = ReportConst.DATA_TYPE_STRING;
            item.DataFormat = null;
            item.CellFormat = null;
            item.Posiotion = 1;
            item.PosiotionX = 100;
            item.PosiotionY = 200;

            Assert.AreEqual(item.Name, "TestName");
            Assert.AreEqual(item.DataType, ReportConst.DATA_TYPE_STRING);
            Assert.IsNull(item.DataFormat);
            Assert.IsNull(item.CellFormat);
            Assert.AreEqual(item.Posiotion, 1);
            Assert.AreEqual(item.PosiotionX, 100);
            Assert.AreEqual(item.PosiotionY, 200);
        }

        [TestMethod]
        public void TestMethod_CreateReportItem_Integer()
        {
            ReportItem item = new ReportItem();
            item.Name = "TestName";
            item.DataType = ReportConst.DATA_TYPE_INTEGER;
            item.DataFormat = "##0";
            item.CellFormat = "#,##0";
            item.Posiotion = 2;
            item.PosiotionX = 300;
            item.PosiotionY = 400;

            Assert.AreEqual(item.Name, "TestName");
            Assert.AreEqual(item.DataType, ReportConst.DATA_TYPE_INTEGER);
            Assert.AreEqual(item.DataFormat, "##0");
            Assert.AreEqual(item.CellFormat, "#,##0");
            Assert.AreEqual(item.Posiotion, 2);
            Assert.AreEqual(item.PosiotionX, 300);
            Assert.AreEqual(item.PosiotionY, 400);
        }
    }
}
