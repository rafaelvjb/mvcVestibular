using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SysVest.DomainModel.Entities;


namespace SysVest.Test.Entities
{
    [TestClass]
    public class CourseTest
    {
        public Course c1, c2;

        [TestInitialize]
        public void InitTests()
        {
            c1 = new Course
            {
                Id = 1,
                Description = "desc",
                vagas = 50
            };

        }


        [TestMethod]
        public void Ensure_2_Courses_Equals_When_Same_Id()
        {

            c2 = new Course
            {
                Id = 1,
                Description = "descasdasd",
                vagas = 53
            };

            Assert.AreEqual(c1.Id, c2.Id);
            Assert.AreEqual(c1, c2);
        }

        [TestMethod]
        public void Ensure_2_Courses_Equals_When_Same_Description()
        {

            c2 = new Course
            {
                Id = 2,
                Description = "desc",
                vagas = 52
            };

            Assert.AreEqual(c1.Description, c2.Description);
            Assert.AreEqual(c1, c2);
        }
    
    
    
    }
}
