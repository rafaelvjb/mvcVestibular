using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SysVest.DomainModel.Entities;

namespace SysVest.Test.Entities
{
    [TestClass]
    public class CandidateTest
    {

        public Candidate candidate1, candidate2;

        [TestInitialize]
        public void InitTests()
        {
            candidate1 = new Candidate
            {
                Id = 1,
                Approved = true,
                BirthDate = DateTime.Now,
                Email = "cand@mail.com",
                Name = "candidate 1",
                CPF = "12312312333"
            };

        }

        [TestMethod]
        public void Ensure_2_Admins_Equals_When_Same_Id()
        {
            candidate2 = new Candidate
            {
                Id = 1,
                Approved = false,
                BirthDate = DateTime.Now.AddDays(2),
                Email = "cand2@mail.com",
                Name = "candidate2",
                CPF = "12312asdsa312333"
            };

            Assert.AreEqual(candidate1.Id, candidate2.Id);
            Assert.AreEqual(candidate1, candidate2);
        }


        [TestMethod]
        public void Ensure_2_Admins_Equals_When_Same_CPF()
        {
            candidate2 = new Candidate
            {
                Id = 2,
                Approved = false,
                BirthDate = DateTime.Now.AddDays(2),
                Email = "cand2@mail.com",
                Name = "candidate2",
                CPF = "12312312333"
            };

            Assert.AreEqual(candidate1.CPF, candidate2.CPF);
         Assert.AreEqual(candidate1, candidate2);
        }

        [TestMethod]
        public void Ensure_2_Admins_Equals_When_Same_Email()
        {
            candidate2 = new Candidate
            {
                Id = 2,
                Approved = false,
                BirthDate = DateTime.Now.AddDays(2),
                Email = "cand@mail.com",
                Name = "candidate2",
                CPF = "12312312333"
            };

            Assert.AreEqual(candidate1.Email, candidate2.Email);
            Assert.AreEqual(candidate1, candidate2);
        }
    }
}
