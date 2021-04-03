using Microsoft.VisualStudio.TestTools.UnitTesting;
using NoTenKee;

namespace NoTenKeeTest2
{
    /// <summary>
    /// 帳票形式:リスト型(縦方向4行　横方向3行)
    /// </summary>
    [TestClass]
    public class NoTenKeeTest_N4x3
    {
        [TestMethod]
        public void TestMethod_n4x3_p0()
        {
            string[] args = { ConstTest.XML_PATH + "Excel_Report_N4x3.xml", ConstTest.INPUT_PATH + "testData.csv", TestUtil.CreateOutputPath(ConstTest.OUTPUT_PATH, "TestMethod_n4x3_p0") };
            NotenKee notenkee = new NotenKee();
            notenkee.Execute(args);
        }

        [TestMethod]
        public void TestMethod_n4x3_p1()
        {
            string[] args = { ConstTest.XML_PATH + "Excel_Report_N4x3.xml", ConstTest.INPUT_PATH + "testData_z3x4_p1.csv", TestUtil.CreateOutputPath(ConstTest.OUTPUT_PATH, "TestMethod_n4x3_p1") };
            NotenKee notenkee = new NotenKee();
            notenkee.Execute(args);
        }

        [TestMethod]
        public void TestMethod_n4x3_p2()
        {
            string[] args = { ConstTest.XML_PATH + "Excel_Report_N4x3.xml", ConstTest.INPUT_PATH + "testData_z3x4_p2.csv", TestUtil.CreateOutputPath(ConstTest.OUTPUT_PATH, "TestMethod_n4x3_p2") };
            NotenKee notenkee = new NotenKee();
            notenkee.Execute(args);
        }

        [TestMethod]
        public void TestMethod_n4x3_p3()
        {
            string[] args = { ConstTest.XML_PATH + "Excel_Report_N4x3.xml", ConstTest.INPUT_PATH + "testData_z3x4_p3.csv", TestUtil.CreateOutputPath(ConstTest.OUTPUT_PATH, "TestMethod_n4x3_p3") };
            NotenKee notenkee = new NotenKee();
            notenkee.Execute(args);
        }

        [TestMethod]
        public void TestMethod_n4x3_p4()
        {
            string[] args = { ConstTest.XML_PATH + "Excel_Report_N4x3.xml", ConstTest.INPUT_PATH + "testData_z3x4_p4.csv", TestUtil.CreateOutputPath(ConstTest.OUTPUT_PATH, "TestMethod_n4x3_p4") };
            NotenKee notenkee = new NotenKee();
            notenkee.Execute(args);
        }

    }
}
