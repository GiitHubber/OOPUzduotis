using System;
using OOPUzd;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace OOPUzd_UnitTest
{
    [TestClass]
    public class Siuntos_UnitTest
    {
        [TestMethod]
        public void SiuntosNustatymas_PrekiuKiekis1_TikimesGautiS()
        {
            Siuntos s = new Siuntos();
            s.SiuntosNustatymas(1);
            Assert.IsTrue(s.SiuntosDydis == "S");           
        }
        [TestMethod]
        public void SiuntosNustatymas_PrekiuKiekis3_TikimesGautiM()
        {
            Siuntos s = new Siuntos();
            s.SiuntosNustatymas(3);
            Assert.IsTrue(s.SiuntosDydis == "M");
        }
        [TestMethod]
        public void SiuntosNustatymas_PrekiuKiekis6_TikimesGautiL()
        {
            Siuntos s = new Siuntos();
            s.SiuntosNustatymas(6);
            Assert.IsTrue(s.SiuntosDydis == "L");
        }
    }
}
