using Microsoft.VisualStudio.TestTools.UnitTesting;
using NoTenKee;

namespace NoTenKeeTest2
{
    /// <summary>
    /// ���[�`��:���X�g�^(�c����4�s��������3�s)
    /// </summary>
    [TestClass]
    public class NoTenKeeTest_N4x3
    {
        /// <summary>
        /// 1�V�[�g�o�́A3�s�o�́A���s�Ȃ�
        /// </summary>
        [TestMethod]
        public void TestMethod_n4x3_p0()
        {
            string[] args = {
                ConstTest.XML_PATH + "NoTenkee_environment.xml",
                ConstTest.XML_PATH + "Excel_Report_N4x3.xml",
                ConstTest.INPUT_PATH + "testData_z3x4_p0.csv",
                TestUtil.CreateOutputPath(ConstTest.OUTPUT_PATH, "TestMethod_n4x3_p0") };
            NotenKee notenkee = new NotenKee();
            notenkee.Execute(args);
        }

        /// <summary>
        /// 1�V�[�g�o�́A4�s�o�́A���s����
        /// </summary>
        [TestMethod]
        public void TestMethod_n4x3_p1()
        {
            string[] args = {
                ConstTest.XML_PATH + "NoTenkee_environment.xml",
                ConstTest.XML_PATH + "Excel_Report_N4x3.xml",
                ConstTest.INPUT_PATH + "testData_z3x4_p1.csv",
                TestUtil.CreateOutputPath(ConstTest.OUTPUT_PATH, "TestMethod_n4x3_p1") };
            NotenKee notenkee = new NotenKee();
            notenkee.Execute(args);
        }

        /// <summary>
        /// 1�V�[�g�o�́A6�s�o�́A���s(1)����
        /// </summary>
        [TestMethod]
        public void TestMethod_n4x3_p2()
        {
            string[] args = {
                ConstTest.XML_PATH + "NoTenkee_environment.xml",
                ConstTest.XML_PATH + "Excel_Report_N4x3.xml",
                ConstTest.INPUT_PATH + "testData_z3x4_p2.csv",
                TestUtil.CreateOutputPath(ConstTest.OUTPUT_PATH, "TestMethod_n4x3_p2") };
            NotenKee notenkee = new NotenKee();
            notenkee.Execute(args);
        }

        /// <summary>
        /// 1�V�[�g�o�́A7�s�o�́A���s(2)����
        /// </summary>
        [TestMethod]
        public void TestMethod_n4x3_p3()
        {
            string[] args = {
                ConstTest.XML_PATH + "NoTenkee_environment.xml",
                ConstTest.XML_PATH + "Excel_Report_N4x3.xml",
                ConstTest.INPUT_PATH + "testData_z3x4_p3.csv",
                TestUtil.CreateOutputPath(ConstTest.OUTPUT_PATH, "TestMethod_n4x3_p3") };
            NotenKee notenkee = new NotenKee();
            notenkee.Execute(args);
        }

        /// <summary>
        /// 1�V�[�g�o�́A9�s�o�́A���s(2)����
        /// </summary>
        [TestMethod]
        public void TestMethod_n4x3_p4()
        {
            string[] args = {
                ConstTest.XML_PATH + "NoTenkee_environment.xml",
                ConstTest.XML_PATH + "Excel_Report_N4x3.xml",
                ConstTest.INPUT_PATH + "testData_z3x4_p4.csv",
                TestUtil.CreateOutputPath(ConstTest.OUTPUT_PATH, "TestMethod_n4x3_p4") };
            NotenKee notenkee = new NotenKee();
            notenkee.Execute(args);
        }

        /// <summary>
        /// 1�V�[�g�o�́A10�s�o�́A���s(3)����
        /// </summary>
        [TestMethod]
        public void TestMethod_n4x3_p5()
        {
            string[] args = {
                ConstTest.XML_PATH + "NoTenkee_environment.xml",
                ConstTest.XML_PATH + "Excel_Report_N4x3.xml",
                ConstTest.INPUT_PATH + "testData_z3x4_p5.csv",
                TestUtil.CreateOutputPath(ConstTest.OUTPUT_PATH, "TestMethod_n4x3_p5") };
            NotenKee notenkee = new NotenKee();
            notenkee.Execute(args);
        }

        /// <summary>
        /// 1�V�[�g�o�́A12�s�o�́A���s(3)����
        /// </summary>
        [TestMethod]
        public void TestMethod_n4x3_p6()
        {
            string[] args = {
                ConstTest.XML_PATH + "NoTenkee_environment.xml",
                ConstTest.XML_PATH + "Excel_Report_N4x3.xml",
                ConstTest.INPUT_PATH + "testData_z3x4_p6.csv",
                TestUtil.CreateOutputPath(ConstTest.OUTPUT_PATH, "TestMethod_n4x3_p6") };
            NotenKee notenkee = new NotenKee();
            notenkee.Execute(args);
        }

        /// <summary>
        /// 2�V�[�g�o�́A13�s�o�́A���s(3)����
        /// </summary>
        [TestMethod]
        public void TestMethod_n4x3_p7()
        {
            string[] args = {
                ConstTest.XML_PATH + "NoTenkee_environment.xml",
                ConstTest.XML_PATH + "Excel_Report_N4x3.xml",
                ConstTest.INPUT_PATH + "testData_z3x4_p7.csv",
                TestUtil.CreateOutputPath(ConstTest.OUTPUT_PATH, "TestMethod_n4x3_p7") };
            NotenKee notenkee = new NotenKee();
            notenkee.Execute(args);
        }
        /// <summary>
        /// 0����7�܂ňꊇ�o��(�L�[�u���C�N�m�F)
        /// </summary>
        [TestMethod]
        public void TestMethod_n4x3_p8()
        {
            string[] args = {
                ConstTest.XML_PATH + "NoTenkee_environment.xml",
                ConstTest.XML_PATH + "Excel_Report_N4x3.xml",
                ConstTest.INPUT_PATH + "testData_z3x4_p8.csv",
                TestUtil.CreateOutputPath(ConstTest.OUTPUT_PATH, "TestMethod_n4x3_p8") };
            NotenKee notenkee = new NotenKee();
            notenkee.Execute(args);
        }

        /// <summary>
        /// �L�[�u���C�N�m�F
        /// </summary>
        [TestMethod]
        public void TestMethod_n4x3_p9()
        {
            string[] args = {
                ConstTest.XML_PATH + "NoTenkee_environment.xml",
                ConstTest.XML_PATH + "Excel_Report_N4x3.xml",
                ConstTest.INPUT_PATH + "testData_z3x4_p9.csv",
                TestUtil.CreateOutputPath(ConstTest.OUTPUT_PATH, "TestMethod_n4x3_p9") };
            NotenKee notenkee = new NotenKee();
            notenkee.Execute(args);
        }
    }
}
