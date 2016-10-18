using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using Model;
using Model.ViewModel;
using Service.Interfaces;
using System;

namespace Service.Implements
{
    public class UserService : BaseService, IUserService
    {
        public UserService(HongLienDb hongLienDb) : base(hongLienDb)
        {

        }
        public async Task<bool> Login(LoginViewModel model)
        {
            var result =
                HongLienDb.tblSysUsers.AsNoTracking()
                    .AnyAsync(c => c.UserID == model.UserName && c.UserPass == model.Password);
            return await result;
        }

        public string md5(string data)
        {
            System.Security.Cryptography.MD5CryptoServiceProvider md5Hasher = new System.Security.Cryptography.MD5CryptoServiceProvider();
            byte[] hashedBytes;
            System.Text.UTF8Encoding encoder = new System.Text.UTF8Encoding();
            hashedBytes = md5Hasher.ComputeHash(encoder.GetBytes(data));
            var md5Encrypt = BitConverter.ToString(hashedBytes).Replace("-", "").ToLower();
            return md5Encrypt;
        }
    }
}
