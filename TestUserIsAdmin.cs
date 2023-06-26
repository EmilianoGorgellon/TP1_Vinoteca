using FireSharp.Response;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using TP1_UTN.Clases;
namespace UnitTesting
{
    [TestClass]
    public class TestUnitarios
    {


        [TestMethod]
        public async Task TestUserIsAdmin()
        {
            string userId = "52d9ac92d6e043b9be4834f41b4295ef";
            bool userIsAdmin = await Cliente.UserIsAdmin(userId);
            Assert.IsTrue(userIsAdmin);
        }
        [TestMethod]        
        public async Task TestUserIsNotAdmin()
        {
            string idUser = "pepe";
            bool userIsAdmin = await Cliente.UserIsAdmin(idUser);
            Assert.IsFalse(userIsAdmin);
        }
    }
}