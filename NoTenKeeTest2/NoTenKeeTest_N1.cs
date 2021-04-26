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
        /// <summary>
        /// リスト型帳票定義でのファイル作成機能確認(A1形式)
        /// </summary>
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
        /// <summary>
        /// リスト型帳票定義でのファイル作成機能確認(R1C1形式)
        /// </summary>
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

