using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IAdminService : IGenericService<Admin>
    {
        void Delete(Admin t);
        Admin GetById(int id);
        List<Admin> GetListAll();
        void Insert(Admin t);
        void Update(Admin t);
        Task<IdentityUser> LoginAsync(string username, string password);
        Task<bool> ResetPasswordAsync(string userName, string newPassword);
    }
}
