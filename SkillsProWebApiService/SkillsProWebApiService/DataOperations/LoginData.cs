using SkillsProWebApiService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SkillsProWebApiService.DataOperations
{
    public class LoginData : ILoginData
    {
        private SkillsProDBContext _context;

        public LoginData(SkillsProDBContext context)
        {
            _context = context;
        }
        public UserModel GetUserModels(UserLogin userLogin)
        {
            var currentUser =  _context.UserModels.FirstOrDefault(o => o.Username.ToLower() == userLogin.Username.ToLower() && o.Password == userLogin.Password);

            return currentUser;
        }        
    }
}
