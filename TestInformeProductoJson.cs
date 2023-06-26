using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP1_UTN.Clases;

namespace UnitTesting
{
    [TestClass]
    public class TestInformeProductoJson
    {

        [TestMethod]
        public async Task TestInformeJsonOk()
        {
            bool creoInforme = await Informes.ExportarProductosAJSON("productos");
            Assert.IsTrue(creoInforme);
        }
        [TestMethod]
        public async Task TestInformeNotJsonOk()
        {
            bool creoInforme = await Informes.ExportarProductosAJSON("pepe");
            Assert.IsFalse(creoInforme);
        }

    }
}
