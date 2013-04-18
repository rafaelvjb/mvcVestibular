using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SysVest.DomainModel.Entities;


namespace SysVest.Test.Entities
{
    [TestClass]
    public class AdminTest
    {
        public Admin adm1, adm2;

        [TestInitialize]
        public void InitTests()
        {
            adm1 = new Admin
            {
                Id = 1,
                Email = "adm@devmedia.com.br",
                NameTratament = "ADM",
                Login = "admin",
                Password = "123456"
            };

        }


        [TestMethod]
        public void Ensure_2_Admins_Equals_When_Same_Id()
        {

            adm2 = new Admin
            {
                Id = 1,
                Email = "asad@devmedia.com.br",
                NameTratament = "asaADM",
                Login = "adminasdsadz",
                Password = "147852"
            };

            Assert.AreEqual(adm1.Id, adm2.Id);
            Assert.AreEqual(adm1, adm2);
        }

        [TestMethod]
        public void Ensure_2_Admins_Equals_When_Same_Login()
        {

            adm2 = new Admin
            {
                Id = 2,
                Email = "asad@devmedia.com.br",
                NameTratament = "asaADM",
                Login = "admin",
                Password = "147852"
            };

            Assert.AreEqual(adm1.Login, adm2.Login);
            Assert.AreEqual(adm1, adm2);
        }
    
    
    
    }
}
