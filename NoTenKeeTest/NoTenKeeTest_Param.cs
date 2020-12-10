using Microsoft.VisualStudio.TestTools.UnitTesting;
using NoTenKee;

namespace NoTenKeeTest
{
    /// <summary>
    /// 文字列のシングルコート、ダブルクォーコート指定
    /// </summary>
    [TestClass]
    public class NoTenKeeTest_Param
    {
        [TestMethod]
        public void TestMethod_Quato_Single()
        {
            string[] args = { ConstTest.XML_PATH + "Excel_Report_N1_QuatoSingle.xml", ConstTest.INPUT_PATH + "testData_quote_single.csv", TestUtil.CreateOutputPath(ConstTest.OUTPUT_PATH, "TestMethod_QUATO_SINGLE") };

            NotenKee notenkee = new NotenKee();
            notenkee.Execute(args);
        }
        [TestMethod]
        public void TestMethod_Quato_Double()
        {
            string[] args = { ConstTest.XML_PATH + "Excel_Report_N1_QuatoDouble.xml", ConstTest.INPUT_PATH + "testData_quote_double.csv", TestUtil.CreateOutputPath(ConstTest.OUTPUT_PATH, "TestMethod_QUATO_DOUBLE") };

            NotenKee notenkee = new NotenKee();
            notenkee.Execute(args);
        }
        [TestMethod]
        public void TestMethod_CodeSet_SJIS()
        {
            string[] args = { ConstTest.XML_PATH + "Excel_Report_N1_SJIS.xml", ConstTest.INPUT_PATH + "testData_sjis.csv", TestUtil.CreateOutputPath(ConstTest.OUTPUT_PATH, "TestMethod_SJIS") };

            NotenKee notenkee = new NotenKee();
            notenkee.Execute(args);
        }
        public void TestMethod_CodeSet_UTF8()
        {
            string[] args = { ConstTest.XML_PATH + "Excel_Report_N1_UTF8.xml", ConstTest.INPUT_PATH + "testData_utf8.csv", TestUtil.CreateOutputPath(ConstTest.OUTPUT_PATH, "TestMethod_utf8") };

            NotenKee notenkee = new NotenKee();
            notenkee.Execute(args);
        }
        public void TestMethod_Header_True()
        {
            string[] args = { ConstTest.XML_PATH + "Excel_Report_N1_header_true.xml", ConstTest.INPUT_PATH + "testData_header.csv", TestUtil.CreateOutputPath(ConstTest.OUTPUT_PATH, "TestMethod_Header_true") };

            NotenKee notenkee = new NotenKee();
            notenkee.Execute(args);
        }
    }
}

