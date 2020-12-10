using Microsoft.VisualStudio.TestTools.UnitTesting;
using NoTenKee;
using NoTenKee.AppException;
using System;

namespace NoTenKeeTest
{
    /// <summary>
    /// 帳票形式:リスト型(縦方向1行　横方向1行)
    /// </summary>
    [TestClass]
    public class NoTenKeeTest_DateTypeExp
    {
        [TestMethod]
        public void TestMethod_Date_null()
        {
            string[] args = { ConstTest.XML_PATH + "Excel_Report_N1.xml", ConstTest.INPUT_PATH + "testData_Date_null.csv", TestUtil.CreateOutputPath(ConstTest.OUTPUT_PATH, "TestMethod_Date_null") };

            NotenKee notenkee = new NotenKee();
            notenkee.Execute(args);
        }
        [TestMethod]
        public void TestMethod_DatetypeExp01()
        {
            string[] args = { ConstTest.XML_PATH + "Excel_Report_N1.xml", ConstTest.INPUT_PATH + "testData_DatetypeExp01.csv", TestUtil.CreateOutputPath(ConstTest.OUTPUT_PATH, "testData_DatetypeExp01") };

            NotenKee notenkee = new NotenKee();
            try
            {
                notenkee.Execute(args);
            }
            catch (NoTenKeeException e)
            {
                // Assert
                NoTenKeeException text = new NoTenKeeException("The data in the specified format cannot be converted. type:Datetime, value:2018o117");
                StringAssert.Contains(e.Message, text.Message);
                return;
            }
            Assert.Fail("The expected exception was not thrown.");
        }
        [TestMethod]
        public void TestMethod_DatetypeExp02()
        {
            string[] args = { ConstTest.XML_PATH + "Excel_Report_N1.xml", ConstTest.INPUT_PATH + "testData_DatetypeExp02.csv", TestUtil.CreateOutputPath(ConstTest.OUTPUT_PATH, "testData_DatetypeExp02") };

            NotenKee notenkee = new NotenKee();
            try
            {
                notenkee.Execute(args);
            }
            catch (NoTenKeeException e)
            {
                // Assert
                NoTenKeeException text = new NoTenKeeException("The data in the specified format cannot be converted. type:Datetime, value:20181332");
                StringAssert.Contains(e.Message, text.Message);
                return;
            }
            catch (Exception e)
            {
                Console.WriteLine($"Generic Exception Handler: {e}");
            }
            Assert.Fail("The expected exception was not thrown.");
        }
        [TestMethod]
        public void TestMethod_DatetypeExp03()
        {
            string[] args = { ConstTest.XML_PATH + "Excel_Report_N1.xml", ConstTest.INPUT_PATH + "testData_DatetypeExp03.csv", TestUtil.CreateOutputPath(ConstTest.OUTPUT_PATH, "testData_DatetypeExp03") };

            NotenKee notenkee = new NotenKee();
            try
            {
                notenkee.Execute(args);
            }
            catch (NoTenKeeException e)
            {
                // Assert
                NoTenKeeException text = new NoTenKeeException("The data in the specified format cannot be converted. type:Datetime, value:2018/01/17");
                StringAssert.Contains(e.Message, text.Message);
                return;
            }
            Assert.Fail("The expected exception was not thrown.");
        }
        [TestMethod]
        public void TestMethod_DatetypeExp04()
        {
            string[] args = { ConstTest.XML_PATH + "Excel_Report_N1.xml", ConstTest.INPUT_PATH + "testData_DatetypeExp04.csv", TestUtil.CreateOutputPath(ConstTest.OUTPUT_PATH, "testData_DatetypeExp04") };

            NotenKee notenkee = new NotenKee();
            try
            {
                notenkee.Execute(args);
            }
            catch (NoTenKee.AppException.NoTenKeeException e)
            {
                // Assert
                NoTenKeeException text = new NoTenKeeException("The data in the specified format cannot be converted. type:Datetime, value:20180108121314");
                StringAssert.Contains(e.Message, text.Message);
                return;
            }
            Assert.Fail("The expected exception was not thrown.");
        }
    }
}

