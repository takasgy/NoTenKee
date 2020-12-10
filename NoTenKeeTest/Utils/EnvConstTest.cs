using Microsoft.VisualStudio.TestTools.UnitTesting;
using NoTenKee.Utils;

namespace NoTenKeeTest.Utils
{
    [TestClass]
    public class EnvConstTest
    {
        [TestMethod]
        public void TestMethod_GetPARAM_MIN()
        {
            Assert.AreEqual(EnvConst.PARAM_MIN, 2);
        }

        [TestMethod]
        public void TestMethod_GetPARAM_MAX()
        {
            Assert.AreEqual(EnvConst.PARAM_MAX, 3);
        }
    }
}
