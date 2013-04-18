using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysVest.DomainModel.Entities
{
    public class Course
    {
        public int Id { get; set; }

        public string Description { get; set; }

        public int vagas { get; set; }

        public ICollection<Candidate> ListCandidates { get; set; }

        public override bool Equals(object obj)
        {
            var course = (Course)obj;
            return (this.Id == course.Id || this.Description == course.Description);
        }

    }
}
