using SkillsProWebApiService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SkillsProWebApiService.DataOperations
{
    public class SkillsData : ISkillsData
    {
        private SkillsProDBContext _context;

        public SkillsData(SkillsProDBContext context)
        {
            _context = context;
        }
        public Skills AddSkill(Skills skill)
        {
            if (string.IsNullOrEmpty(skill.SkillId))
            {
                skill.SkillId = "Skill" + Guid.NewGuid();
            }
            _context.Skills.Add(skill);
            _context.SaveChanges();
            return skill;
        }

        public void DeleteSkill(Skills skill)
        {
            _context.Skills.Remove(skill);
            _context.SaveChanges();
        }

        public Skills EditSkill(Skills skill)
        {
            var existingSkill = GetSkills(skill.SkillId);
            existingSkill.Name = skill.Name;
            //existingEmployee.AnnualSalary = employee.AnnualSalary;
            //existingEmployee.DateOfBirth = employee.DateOfBirth;
            //existingEmployee.Gender = employee.Gender;
            _context.SaveChanges();
            return existingSkill;
        }

        public List<Skills> GetSkills()
        {
            return _context.Skills.ToList();
        }

        public Skills GetSkills(string skillId)
        {
            var skill = _context.Skills.Find(skillId);

            return skill;
        }

        public string GetSkillNameById(string skillId)
        {
            var skill = _context.Skills.Find(skillId);

            return skill.Name;
        }
    }
}
