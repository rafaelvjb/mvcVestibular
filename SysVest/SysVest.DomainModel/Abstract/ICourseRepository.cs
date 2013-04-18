using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SysVest.DomainModel.Entities;

namespace SysVest.DomainModel.Abstract
{
    public interface ICourseRepository
    {
        IQueryable<Course> Courses { get; }

        void Insert(Course course);

        void Update(Course course);

        void Delete(int id);

        Course GetCourseById(int id);

        IList<Course> GetAll();
    }
}
