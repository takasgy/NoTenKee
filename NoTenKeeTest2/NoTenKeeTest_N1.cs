using Microsoft.VisualStudio.TestTools.UnitTesting;
using NoTenKee;

namespace NoTenKeeTest2
{
    /// <summary>
    /// 帳票形式:リスト型(縦方向1行　横方向1行)
    /// </summary>
    [TestClass]
    public class NoTenKeeTest_N1
    {
        [TestMethod]
        public void TestMethod_N1()
        {
            string[] args = {
                ConstTest.XML_PATH + "NoTenkee_environment.xml",
                ConstTest.XML_PATH + "Excel_Report_N1.xml",
                ConstTest.INPUT_PATH + "testData.csv",
                TestUtil.CreateOutputPath(ConstTest.OUTPUT_PATH, "TestMethod_N1") };

            NotenKee notenkee = new NotenKee();
            notenkee.Execute(args);
        }
        [TestMethod]
        public void TestMethod_N1_R1()
        {
            string[] args = {
                ConstTest.XML_PATH + "NoTenkee_environment.xml",
                ConstTest.XML_PATH + "Excel_Report_N1_R1.xml",
                ConstTest.INPUT_PATH + "testData.csv",
                TestUtil.CreateOutputPath(ConstTest.OUTPUT_PATH, "TestMethod_N1_R1") };

            NotenKee notenkee = new NotenKee();
            notenkee.Execute(args);
        }
    }
}

