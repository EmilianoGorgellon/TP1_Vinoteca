using FireSharp.Response;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using TP1_UTN.Clases;
namespace UnitTesting
{
    [TestClass]
    public class TestFirebase
    {
        [TestMethod]
        public async Task TestFirebaseResponse()
        {
            string nombreBaseDatos = "productos";
            FirebaseResponse response = await Firebase.GetElement(nombreBaseDatos);
            Assert.AreNotEqual(response.Body, "null");
        }

        [TestMethod]
        public async Task TestFirebaseResponseNull()
        {
            string nombreBaseDatos = "pepe";
            FirebaseResponse response = await Firebase.GetElement(nombreBaseDatos);
            Assert.AreEqual(response.Body, "null");
        }
    }
}
