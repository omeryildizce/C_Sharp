using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Helpers.StringHelper;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace Helpers.Tests
{
    [TestClass]
    public class StringHelperTests
    {
        [TestMethod]
        public void Girilen_ifadenin_basindaki_ve_sonundaki_bosluklar_silinmelidir()
        {
            // Arange 
            var ifade = "    Ömer Yıldız   ";
            var beklenen = "Ömer Yıldız";

            //Act
            var gerceklesen = StringHelper.FazlaBosluklariSil(ifade);

            // Assert
            Assert.AreEqual(beklenen, gerceklesen); 
        }
    }
}
