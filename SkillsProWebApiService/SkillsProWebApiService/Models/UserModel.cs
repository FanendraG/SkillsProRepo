using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SkillsProWebApiService.Models
{
    public partial class UserModel
    {

        public UserModel()
        {

        }

        [Key]
        public string Username { get; set; }
        
        [Required]
        public string Password { get; set; }
        [Required]
        public string EmailAddress { get; set; }

        [Required]
        public string Role { get; set; }
        public string Surname { get; set; }
        public string GivenName { get; set; }
    }
}
