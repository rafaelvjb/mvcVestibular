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
        
        public string Nome { get; set; }

        public string Telefone { get; set; }

        public string Email { get; set; }

        public DateTime DataNascimento { get; set; }

        public string Senha { get; set; }

        public char Sexo { get; set; }

        public string CPF { get; set; }

        public virtual Vestibular Vestibular{ get; set; }

        public virtual Curso Curso { get; set; }

        public bool Aprovado { get; set; }
    }
}
