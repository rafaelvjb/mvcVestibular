using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysVest.DomainModel.Entities
{
    public class Exam
    {
        public int Id { get; set; }

        public string Description { get; set; }

        public DateTime StartInscriptionDate { get; set; }

        public DateTime EndInscriptionDate { get; set; }

        public DateTime TestDate { get; set; }

        public ICollection<Candidate> ListCandidates { get; set; }

        public override bool Equals(object obj)
        {
            var exam = (Exam)obj;
            return (this.Id == exam.Id || this.Description == exam.Description);
        }
    }
}
