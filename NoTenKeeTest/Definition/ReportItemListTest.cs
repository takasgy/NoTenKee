using Microsoft.VisualStudio.TestTools.UnitTesting;
using NoTenKee.Definition;

namespace NoTenKeeTest.Definition
{
    [TestClass]
    public class ReportItemListTest
    {
        [TestMethod]
        public void TestMethod_SizeZero()
        {
            ReportItemList list = new ReportItemList();
            Assert.AreEqual(list.Size(), 0);
            Assert.IsFalse(list.HasNext());
        }

        [TestMethod]
        public void TestMethod_AddList1()
        {
            ReportItemList list = new ReportItemList();
            ReportItem item = new ReportItem();
            item.Name = "TestName";
            item.DataType = ReportConst.DATA_TYPE_STRING;
            item.DataFormat = null;
            item.CellFormat = null;
            item.Posiotion = 1;
            item.PosiotionX = 100;
            item.PosiotionY = 200;
            list.AddItem(item);
            Assert.AreEqual(list.Size(), 1);
            Assert.IsTrue(list.HasNext());
            Assert.AreEqual(list.Next(), item);
        }

        [TestMethod]
        public void TestMethod_AddList2()
        {
            ReportItemList list = new ReportItemList();
            ReportItem item = new ReportItem();
            item.Name = "TestName";
            item.DataType = ReportConst.DATA_TYPE_STRING;
            item.DataFormat = null;
            item.CellFormat = null;
            item.Posiotion = 1;
            item.PosiotionX = 100;
            item.PosiotionY = 200;
            list.AddItem(item);

            ReportItem item2 = new ReportItem();
            item2.Name = "TestName";
            item2.DataType = ReportConst.DATA_TYPE_INTEGER;
            item2.DataFormat = "##0";
            item2.CellFormat = "#,##0";
            item2.Posiotion = 2;
            item2.PosiotionX = 300;
            item2.PosiotionY = 400;
            list.AddItem(item2);

            Assert.AreEqual(list.Size(), 2);
            Assert.IsTrue(list.HasNext());
            Assert.AreEqual(list.Next(), item);
            Assert.IsTrue(list.HasNext());
            Assert.AreEqual(list.Next(), item2);
            Assert.IsFalse(list.HasNext());
        }
    }
}
