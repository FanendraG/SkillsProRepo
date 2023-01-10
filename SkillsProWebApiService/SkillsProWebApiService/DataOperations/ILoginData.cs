using SkillsProWebApiService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SkillsProWebApiService.DataOperations
{
    public interface ILoginData
    {
        public UserModel GetUserModels(UserLogin userLogin);

    }
}
