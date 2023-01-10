using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SkillsProWebApiService.Models
{
    public class UserConstants
    {
        public static List<UserModel> Users = new List<UserModel>()
        {
            new UserModel() { Username = "fa.ganti", EmailAddress = "fa.ganti@reply.com", Password = "Pa$$word_Admin", GivenName = "Fanendra", Surname = "Ganti", Role = "Administrator" },
            new UserModel() { Username = "elyse_seller", EmailAddress = "elyse.seller@email.com", Password = "Pa$$word_User", GivenName = "Elyse", Surname = "Lambert", Role = "Seller" },
        };
    }
}
