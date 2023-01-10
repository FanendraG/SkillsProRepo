using SkillsProWebApiService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SkillsProWebApiService.DataOperations
{
    public interface ISkillsData
    {

        List<Skills> GetSkills();

        Skills GetSkills(string skillId);

        Skills AddSkill(Skills skill);

        void DeleteSkill(Skills skill);

        Skills EditSkill(Skills skill);
    }
}
