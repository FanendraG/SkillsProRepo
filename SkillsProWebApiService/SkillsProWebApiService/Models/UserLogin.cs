using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SkillsProWebApiService.Models
{
    public partial class UserLogin
    {
        public UserLogin()
        {

        }

        [Key]
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
