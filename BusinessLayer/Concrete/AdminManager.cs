using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class AdminManager : IAdminService
    {
        private readonly IAdminDal _adminDal;
        private readonly UserManager<IdentityUser> _userManager;  // Identity UserManager

        public AdminManager(IAdminDal adminDal, UserManager<IdentityUser> userManager)
        {
            _adminDal = adminDal;
            _userManager = userManager;
        }

        public void Delete(Admin t)
        {
            _adminDal.Delete(t);
        }

        public Admin GetById(int id)
        {
            return _adminDal.GetById(id);
        }

        public List<Admin> GetListAll()
        {
            return _adminDal.GetListAll();
        }

        public void Insert(Admin t)
        {
            _adminDal.Insert(t);
        }

        public void Update(Admin t)
        {
            _adminDal.Update(t);
        }
        public async Task<IdentityUser> LoginAsync(string username, string password)
        {
            var user = await _userManager.FindByNameAsync(username);

            if (user != null && await _userManager.CheckPasswordAsync(user, password))
            {
                // Giriş başarılı
                return user;
            }

            return null;
        }
        public async Task<bool> ResetPasswordAsync(string username, string newPassword)
        {
            var user = await _userManager.FindByNameAsync(username);

            if (user == null)
                return false;

            var token = await _userManager.GeneratePasswordResetTokenAsync(user);
            var result = await _userManager.ResetPasswordAsync(user, token, newPassword);

            return result.Succeeded;
        }


    }
}
