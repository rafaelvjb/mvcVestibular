using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SysVest.DomainModel.Entities;

namespace SysVest.DomainModel.Abstract
{
    public interface IAdminRepository
    {
        IQueryable<Admin> Admins { get; }

        void Insert(Admin admin);

        void Update(Admin admin);
        
        void Delete(int id);

        Admin GetAdminById(int id);

        IList<Admin> GetAll();
    }
}
