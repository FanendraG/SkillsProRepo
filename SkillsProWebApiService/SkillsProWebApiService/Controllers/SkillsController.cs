using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SkillsProWebApiService.DataOperations;
using SkillsProWebApiService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SkillsProWebApiService.Controllers
{
    
    [ApiController]
    public class SkillsController : ControllerBase
    {
        private ISkillsData _skill;
        public SkillsController(ISkillsData skill)
        {
            _skill = skill;
        }

        [HttpGet]
        [Route("api/[controller]")]
        [Authorize(Roles = "Administrator")]
        public IActionResult GetSkills()
        {
            var skill = _skill.GetSkills();
            if (skill != null)
            {
                return Ok(skill);
            }
            else return NotFound("Skill Record not Found");
        }

        [HttpGet]
        [Route("api/[controller]/{skillId}")]
        [Authorize(Roles = "Administrator")]
        public IActionResult GetSkillsById(string skillId)
        {
            var skill = _skill.GetSkills(skillId);
            if (skill != null)
            {
                return Ok(skill);
            }
            else return NotFound($"Skill Record with id: {skillId} was not Found");
        }

        [HttpPatch]
        [Route("api/[controller]/{skillId}")]
        [Authorize(Roles = "Administrator")]
        public IActionResult UpdateSkill(string skillId, Skills skill)
        {
            var existingSkill = _skill.GetSkills(skillId);
            if (existingSkill != null)
            {
                skill.SkillId = existingSkill.SkillId;
                skill = _skill.EditSkill(skill);
            }

            return Ok(skill);

        }

        [HttpDelete]
        [Route("api/[controller]/{skillId}")]
        [Authorize(Roles = "Administrator")]
        public IActionResult DeleteSkill(string skillId)
        {
            var existingSkill = _skill.GetSkills(skillId);
            if (existingSkill != null)
            {
                _skill.DeleteSkill(existingSkill);
                return Ok();
            }
            else return NotFound($"Skill Record with id: {skillId} was not Found");


        }

        [HttpPost]
        [Route("api/[controller]")]
        [Authorize(Roles = "Administrator")]
        public IActionResult AddSkill(Skills skill)
        {
            _skill.AddSkill(skill);

            return Ok(skill);
        }
    }
}
