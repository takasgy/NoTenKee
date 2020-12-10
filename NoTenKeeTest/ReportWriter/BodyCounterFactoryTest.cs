using Microsoft.VisualStudio.TestTools.UnitTesting;
using NoTenKee.ReportWriter;
using NoTenKee.Definition;

namespace NoTenKeeTest.ReportWriter
{
    [TestClass]
    public class BodyCounterFactoryTest
    {
        [TestMethod]
        public void TestMethod_CreateListNType()
        {
            ReportDefinition repDef = new ReportDefinition();
            repDef.Type = ReportConst.ROW_LIST_TYPE;
            repDef.ListType = ReportConst.REPORT_TYPE_N;
            BodyCounterBase bodyCounter = BodyCounterFactory.Create(repDef);
            Assert.AreEqual(bodyCounter.GetType().ToString(), "NoTenKee.ReportWriter.NBodyCounter");
        }

        [TestMethod]
        public void TestMethod_NTypePositionValue()
        {
            ReportDefinition repDef = new ReportDefinition();
            repDef.Type = ReportConst.ROW_LIST_TYPE;
            repDef.ListType = ReportConst.REPORT_TYPE_N;
            repDef.ZIncremental = 2;
            repDef.ZRowMax = 3;
            repDef.NIncremental = 4;
            repDef.NRowMax = 5;
            BodyCounterBase bodyCounter = BodyCounterFactory.Create(repDef);
            bodyCounter.CountUp();
            Assert.AreEqual(bodyCounter.GetYPosition(), 4);
            Assert.AreEqual(bodyCounter.GetXPosition(), 0);
            bodyCounter.CountUp();
            Assert.AreEqual(bodyCounter.GetYPosition(), 8);
            Assert.AreEqual(bodyCounter.GetXPosition(), 0);
            bodyCounter.CountUp();
            Assert.AreEqual(bodyCounter.GetYPosition(), 12);
            Assert.AreEqual(bodyCounter.GetXPosition(), 0);
            bodyCounter.CountUp();
            Assert.AreEqual(bodyCounter.GetYPosition(), 16);
            Assert.AreEqual(bodyCounter.GetXPosition(), 0);
            bodyCounter.CountUp();
            Assert.AreEqual(bodyCounter.GetYPosition(), 0);
            Assert.AreEqual(bodyCounter.GetXPosition(), 2);
            bodyCounter.CountUp();
            Assert.AreEqual(bodyCounter.GetYPosition(), 4);
            Assert.AreEqual(bodyCounter.GetXPosition(), 2);
            bodyCounter.CountUp();
            Assert.AreEqual(bodyCounter.GetYPosition(), 8);
            Assert.AreEqual(bodyCounter.GetXPosition(), 2);
            bodyCounter.CountUp();
            Assert.AreEqual(bodyCounter.GetYPosition(), 12);
            Assert.AreEqual(bodyCounter.GetXPosition(), 2);
            bodyCounter.CountUp();
            Assert.AreEqual(bodyCounter.GetYPosition(), 16);
            Assert.AreEqual(bodyCounter.GetXPosition(), 2);
            bodyCounter.CountUp();
            Assert.AreEqual(bodyCounter.GetYPosition(), 0);
            Assert.AreEqual(bodyCounter.GetXPosition(), 4);
            bodyCounter.CountUp();
            Assert.AreEqual(bodyCounter.GetYPosition(), 4);
            Assert.AreEqual(bodyCounter.GetXPosition(), 4);
            bodyCounter.CountUp();
            Assert.AreEqual(bodyCounter.GetYPosition(), 8);
            Assert.AreEqual(bodyCounter.GetXPosition(), 4);
            bodyCounter.CountUp();
            Assert.AreEqual(bodyCounter.GetYPosition(), 12);
            Assert.AreEqual(bodyCounter.GetXPosition(), 4);
            bodyCounter.CountUp();
            Assert.AreEqual(bodyCounter.GetYPosition(), 16);
            Assert.AreEqual(bodyCounter.GetXPosition(), 4);
            bodyCounter.CountUp();
            Assert.AreEqual(bodyCounter.GetYPosition(), 0);
            Assert.AreEqual(bodyCounter.GetXPosition(), 0);
        }

        [TestMethod]
        public void TestMethod_CreateListZType()
        {
            ReportDefinition repDef = new ReportDefinition();
            repDef.Type = ReportConst.ROW_LIST_TYPE;
            repDef.ListType = ReportConst.REPORT_TYPE_Z;
            BodyCounterBase bodyCounter = BodyCounterFactory.Create(repDef);
            Assert.AreEqual(bodyCounter.GetType().ToString(), "NoTenKee.ReportWriter.ZBodyCounter");
        }

        [TestMethod]
        public void TestMethod_ZTypePositionValue()
        {
            ReportDefinition repDef = new ReportDefinition();
            repDef.Type = ReportConst.ROW_LIST_TYPE;
            repDef.ListType = ReportConst.REPORT_TYPE_Z;
            repDef.NIncremental = 2;
            repDef.NRowMax = 3;
            repDef.ZIncremental = 4;
            repDef.ZRowMax = 5;
            BodyCounterBase bodyCounter = BodyCounterFactory.Create(repDef);
            bodyCounter.CountUp();
            Assert.AreEqual(bodyCounter.GetXPosition(), 4);
            Assert.AreEqual(bodyCounter.GetYPosition(), 0);
            bodyCounter.CountUp();
            Assert.AreEqual(bodyCounter.GetXPosition(), 8);
            Assert.AreEqual(bodyCounter.GetYPosition(), 0);
            bodyCounter.CountUp();
            Assert.AreEqual(bodyCounter.GetXPosition(), 12);
            Assert.AreEqual(bodyCounter.GetYPosition(), 0);
            bodyCounter.CountUp();
            Assert.AreEqual(bodyCounter.GetXPosition(), 16);
            Assert.AreEqual(bodyCounter.GetYPosition(), 0);
            bodyCounter.CountUp();
            Assert.AreEqual(bodyCounter.GetXPosition(), 0);
            Assert.AreEqual(bodyCounter.GetYPosition(), 2);
            bodyCounter.CountUp();
            Assert.AreEqual(bodyCounter.GetXPosition(), 4);
            Assert.AreEqual(bodyCounter.GetYPosition(), 2);
            bodyCounter.CountUp();
            Assert.AreEqual(bodyCounter.GetXPosition(), 8);
            Assert.AreEqual(bodyCounter.GetYPosition(), 2);
            bodyCounter.CountUp();
            Assert.AreEqual(bodyCounter.GetXPosition(), 12);
            Assert.AreEqual(bodyCounter.GetYPosition(), 2);
            bodyCounter.CountUp();
            Assert.AreEqual(bodyCounter.GetXPosition(), 16);
            Assert.AreEqual(bodyCounter.GetYPosition(), 2);
            bodyCounter.CountUp();
            Assert.AreEqual(bodyCounter.GetXPosition(), 0);
            Assert.AreEqual(bodyCounter.GetYPosition(), 4);
            bodyCounter.CountUp();
            Assert.AreEqual(bodyCounter.GetXPosition(), 4);
            Assert.AreEqual(bodyCounter.GetYPosition(), 4);
            bodyCounter.CountUp();
            Assert.AreEqual(bodyCounter.GetXPosition(), 8);
            Assert.AreEqual(bodyCounter.GetYPosition(), 4);
            bodyCounter.CountUp();
            Assert.AreEqual(bodyCounter.GetXPosition(), 12);
            Assert.AreEqual(bodyCounter.GetYPosition(), 4);
            bodyCounter.CountUp();
            Assert.AreEqual(bodyCounter.GetXPosition(), 16);
            Assert.AreEqual(bodyCounter.GetYPosition(), 4);
            bodyCounter.CountUp();
            Assert.AreEqual(bodyCounter.GetXPosition(), 0);
            Assert.AreEqual(bodyCounter.GetYPosition(), 0);
        }
    }
}
