﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NoTenKee;

namespace NoTenKeeTest2
{
    /// <summary>
    /// 帳票形式:リスト型(横方向3行→横方向4行)
    /// </summary>
    [TestClass]
    public class NoTenKeeTest_Z3x4
    {
        /// <summary>
        /// 1シート出力、3行出力、改行なし
        /// </summary>
        [TestMethod]
        public void TestMethod_z3x4_p0()
        {
            string[] args = {
                ConstTest.XML_PATH + "NoTenkee_environment.xml",
                ConstTest.XML_PATH + "Excel_Report_Z3x4.xml",
                ConstTest.INPUT_PATH + "testData_z3x4_p0.csv",
                TestUtil.CreateOutputPath(ConstTest.OUTPUT_PATH, "TestMethod_z3x4_p0") };
            NotenKee notenkee = new NotenKee();
            notenkee.Execute(args);
        }

        /// <summary>
        /// 1シート出力、4行出力、改行あり
        /// </summary>
        [TestMethod]
        public void TestMethod_z3x4_p1()
        {
            string[] args = {
                ConstTest.XML_PATH + "NoTenkee_environment.xml",
                ConstTest.XML_PATH + "Excel_Report_Z3x4.xml",
                ConstTest.INPUT_PATH + "testData_z3x4_p1.csv",
                TestUtil.CreateOutputPath(ConstTest.OUTPUT_PATH, "TestMethod_z3x4_p1") };
            NotenKee notenkee = new NotenKee();
            notenkee.Execute(args);
        }

        /// <summary>
        /// 1シート出力、6行出力、改行(1)あり
        /// </summary>
        [TestMethod]
        public void TestMethod_z3x4_p2()
        {
            string[] args = {
                ConstTest.XML_PATH + "NoTenkee_environment.xml",
                ConstTest.XML_PATH + "Excel_Report_Z3x4.xml",
                ConstTest.INPUT_PATH + "testData_z3x4_p2.csv",
                TestUtil.CreateOutputPath(ConstTest.OUTPUT_PATH, "TestMethod_z3x4_p2") };
            NotenKee notenkee = new NotenKee();
            notenkee.Execute(args);
        }

        /// <summary>
        /// 1シート出力、7行出力、改行(2)あり
        /// </summary>
        [TestMethod]
        public void TestMethod_z3x4_p3()
        {
            string[] args = {
                ConstTest.XML_PATH + "NoTenkee_environment.xml",
                ConstTest.XML_PATH + "Excel_Report_Z3x4.xml",
                ConstTest.INPUT_PATH + "testData_z3x4_p3.csv",
                TestUtil.CreateOutputPath(ConstTest.OUTPUT_PATH, "TestMethod_z3x4_p3") };
            NotenKee notenkee = new NotenKee();
            notenkee.Execute(args);
        }

        /// <summary>
        /// 1シート出力、9行出力、改行(2)あり
        /// </summary>
        [TestMethod]
        public void TestMethod_z3x4_p4()
        {
            string[] args = {
                ConstTest.XML_PATH + "NoTenkee_environment.xml",
                ConstTest.XML_PATH + "Excel_Report_Z3x4.xml",
                ConstTest.INPUT_PATH + "testData_z3x4_p4.csv",
                TestUtil.CreateOutputPath(ConstTest.OUTPUT_PATH, "TestMethod_z3x4_p4") };
            NotenKee notenkee = new NotenKee();
            notenkee.Execute(args);
        }

        /// <summary>
        /// 1シート出力、10行出力、改行(3)あり
        /// </summary>
        [TestMethod]
        public void TestMethod_z3x4_p5()
        {
            string[] args = {
                ConstTest.XML_PATH + "NoTenkee_environment.xml",
                ConstTest.XML_PATH + "Excel_Report_Z3x4.xml",
                ConstTest.INPUT_PATH + "testData_z3x4_p5.csv",
                TestUtil.CreateOutputPath(ConstTest.OUTPUT_PATH, "TestMethod_z3x4_p5") };
            NotenKee notenkee = new NotenKee();
            notenkee.Execute(args);
        }

        /// <summary>
        /// 1シート出力、12行出力、改行(3)あり
        /// </summary>
        [TestMethod]
        public void TestMethod_z3x4_p6()
        {
            string[] args = {
                ConstTest.XML_PATH + "NoTenkee_environment.xml",
                ConstTest.XML_PATH + "Excel_Report_Z3x4.xml",
                ConstTest.INPUT_PATH + "testData_z3x4_p6.csv",
                TestUtil.CreateOutputPath(ConstTest.OUTPUT_PATH, "TestMethod_z3x4_p6") };
            NotenKee notenkee = new NotenKee();
            notenkee.Execute(args);
        }

        /// <summary>
        /// 1シート出力、13行出力、改行(3)あり、改ページあり
        /// </summary>
        [TestMethod]
        public void TestMethod_z3x4_p7()
        {
            string[] args = {
                ConstTest.XML_PATH + "NoTenkee_environment.xml",
                ConstTest.XML_PATH + "Excel_Report_Z3x4.xml",
                ConstTest.INPUT_PATH + "testData_z3x4_p7.csv",
                TestUtil.CreateOutputPath(ConstTest.OUTPUT_PATH, "TestMethod_z3x4_p7") };
            NotenKee notenkee = new NotenKee();
            notenkee.Execute(args);
        }

        /// <summary>
        /// キーブレイク確認
        /// </summary>
        [TestMethod]
        public void TestMethod_z3x4_p8()
        {
            string[] args = {
                ConstTest.XML_PATH + "NoTenkee_environment.xml",
                ConstTest.XML_PATH + "Excel_Report_Z3x4.xml",
                ConstTest.INPUT_PATH + "testData_z3x4_p8.csv",
                TestUtil.CreateOutputPath(ConstTest.OUTPUT_PATH, "TestMethod_z3x4_p8") };
            NotenKee notenkee = new NotenKee();
            notenkee.Execute(args);
        }
    }
}
