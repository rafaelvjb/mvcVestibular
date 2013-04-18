using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SysVest.DomainModel.Entities;


namespace SysVest.Test.Entities
{
    [TestClass]
    public class ExamTest
    {
        public Exam exam1, exam2;

        [TestInitialize]
        public void InitTests()
        {
            exam1 = new Exam
            {
                Id = 1,
                Description = "description"
            };

        }


        [TestMethod]
        public void Ensure_2_Exams_Equals_When_Same_Id()
        {

            exam2 = new Exam
            {
                Id = 1,
                Description = "descriptionssssss"
            };

            Assert.AreEqual(exam1.Id, exam2.Id);
            Assert.AreEqual(exam1, exam2);
        }

        [TestMethod]
        public void Ensure_2_Exams_Equals_When_Same_Description()
        {

            exam2 = new Exam
            {
                Id = 2,
                Description = "description"
            };

            Assert.AreEqual(exam1.Description, exam2.Description);
            Assert.AreEqual(exam1, exam2);
        }

    }
}
