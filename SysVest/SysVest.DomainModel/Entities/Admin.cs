using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysVest.DomainModel.Entities
{
    public class Admin
    {
        public int Id { get; set; }

        public string Login { get; set; }

        public string Password { get; set; }

        public string NameTratament { get; set; }

        public string Email { get; set; }

        public override bool Equals(object obj)
        {
            var adminParam = (Admin)obj;
            return (this.Id == adminParam.Id || this.Login == adminParam.Login || this.Email == adminParam.Email);
        }

    }
}
