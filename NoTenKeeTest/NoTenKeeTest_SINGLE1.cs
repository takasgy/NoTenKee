using Microsoft.VisualStudio.TestTools.UnitTesting;
using NoTenKee;

namespace NoTenKeeTest
{
    [TestClass]
    public class NoTenKeeTest_SINGLE1
    {
        [TestMethod]
        public void TestMethod_Single()
        {
            string[] args = { ConstTest.XML_PATH + "Excel_Report_SINGLE.xml", ConstTest.INPUT_PATH + "testData.csv", TestUtil.CreateOutputPath(ConstTest.OUTPUT_PATH, "TestMethod_Single") };
            NotenKee notenkee = new NotenKee();
            notenkee.Execute(args);
        }
        [TestMethod]
        public void TestMethod_Single_R1()
        {
            string[] args = { ConstTest.XML_PATH + "Excel_Report_SINGLE_R1.xml", ConstTest.INPUT_PATH + "testData.csv", TestUtil.CreateOutputPath(ConstTest.OUTPUT_PATH, "TestMethod_Single_R1") };
            NotenKee notenkee = new NotenKee();
            notenkee.Execute(args);
        }
    }
}