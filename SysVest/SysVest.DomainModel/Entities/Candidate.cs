using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysVest.DomainModel.Entities
{
    public class Candidate
    {

        public int Id { get; set; }

        public string Name { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }

        public DateTime BirthDate { get; set; }

        public string Password { get; set; }

        public char Sex { get; set; }

        public string CPF { get; set; }

        public virtual Exam Exam { get; set; }

        public virtual Course Course { get; set; }

        public bool Approved { get; set; }

        public override bool Equals(object obj)
        {
            var candidateParam = (Candidate)obj;
            return (this.Id == candidateParam.Id || this.CPF == candidateParam.CPF);
        }
    }
}
