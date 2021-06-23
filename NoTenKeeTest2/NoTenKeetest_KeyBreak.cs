using Microsoft.VisualStudio.TestTools.UnitTesting;
using NoTenKee;

namespace NoTenKeeTest2
{
    /// <summary>
    /// キーブレイク関連テスト
    /// </summary>
    [TestClass]
    public class NoTenKeetest_KeyBreak
    {
        /// <summary>
        /// 単票形式キーブレイクなし
        /// </summary>
        [TestMethod]
        public void TestMethod_NoBreak_Single_p1()
        {
            string[] args = {
                ConstTest.XML_PATH + "NoTenkee_environment.xml",
                ConstTest.XML_PATH + "Excel_Report_SINGLE_NoKeyBreake.xml",
                ConstTest.INPUT_PATH + "testData_NoBreak_Single_p1.csv",
                TestUtil.CreateOutputPath(ConstTest.OUTPUT_PATH, "Excel_Report_SINGLE_NoKeyBreake") };

            NotenKee notenkee = new NotenKee();
            notenkee.Execute(args);
        }

        /// <summary>
        /// 単票形式キーブレイクなし ３ページで新しいBook ３ページ出力
        /// </summary>
        [TestMethod]
        public void TestMethod_NoBreak_Single_p3()
        {
            string[] args = {
                ConstTest.XML_PATH + "NoTenkee_environment.xml",
                ConstTest.XML_PATH + "Excel_Report_SINGLE_NoKeyBreake.xml",
                ConstTest.INPUT_PATH + "testData_NoBreak_Single_p3.csv",
                TestUtil.CreateOutputPath(ConstTest.OUTPUT_PATH, "Excel_Report_SINGLE_NoKeyBreake") };

            NotenKee notenkee = new NotenKee();
            notenkee.Execute(args);
        }

        /// <summary>
        /// 単票形式キーブレイクなし ３ページで新しいBook ４ページ出力
        /// </summary>
        [TestMethod]
        public void TestMethod_NoBreak_Single_4()
        {
            string[] args = {
                ConstTest.XML_PATH + "NoTenkee_environment.xml",
                ConstTest.XML_PATH + "Excel_Report_SINGLE_NoKeyBreake.xml",
                ConstTest.INPUT_PATH + "testData_NoBreak_Single_p4.csv",
                TestUtil.CreateOutputPath(ConstTest.OUTPUT_PATH, "Excel_Report_SINGLE_NoKeyBreake") };

            NotenKee notenkee = new NotenKee();
            notenkee.Execute(args);
        }

        /// <summary>
        /// 表票形式キーブレイクなし
        /// </summary>
        [TestMethod]
        public void TestMethod_NoBreak_List_p1()
        {
            string[] args = {
                ConstTest.XML_PATH + "NoTenkee_environment.xml",
                ConstTest.XML_PATH + "Excel_Report_N1_NoKeyBreake.xml",
                ConstTest.INPUT_PATH + "testData_NoBreak_N1_p1.csv",
                TestUtil.CreateOutputPath(ConstTest.OUTPUT_PATH, "Excel_Report_N1_NoKeyBreake") };

            NotenKee notenkee = new NotenKee();
            notenkee.Execute(args);
        }

        /// <summary>
        /// 表票形式キーブレイクなし ３ページで新しいBook ３ページ出力
        /// </summary>
        [TestMethod]
        public void TestMethod_NoBreak_List_p3()
        {
            string[] args = {
                ConstTest.XML_PATH + "NoTenkee_environment.xml",
                ConstTest.XML_PATH + "Excel_Report_N1_NoKeyBreake.xml",
                ConstTest.INPUT_PATH + "testData_NoBreak_N1_p3.csv",
                TestUtil.CreateOutputPath(ConstTest.OUTPUT_PATH, "Excel_Report_N1_NoKeyBreake") };

            NotenKee notenkee = new NotenKee();
            notenkee.Execute(args);
        }

        /// <summary>
        /// 表票形式キーブレイクなし ３ページで新しいBook ４ページ出力
        /// </summary>
        [TestMethod]
        public void TestMethod_NoBreak_List_p4()
        {
            string[] args = {
                ConstTest.XML_PATH + "NoTenkee_environment.xml",
                ConstTest.XML_PATH + "Excel_Report_N1_NoKeyBreake.xml",
                ConstTest.INPUT_PATH + "testData_NoBreak_N1_p4.csv",
                TestUtil.CreateOutputPath(ConstTest.OUTPUT_PATH, "Excel_Report_N1_NoKeyBreake") };

            NotenKee notenkee = new NotenKee();
            notenkee.Execute(args);
        }

    }
}
