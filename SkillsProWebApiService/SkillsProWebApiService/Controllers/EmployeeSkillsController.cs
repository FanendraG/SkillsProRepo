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
    public class EmployeeSkillsController : ControllerBase
    {

        private IEmpSkillsMappingData _empSkillsMapping;
        public EmployeeSkillsController(IEmpSkillsMappingData empSkillsMapping)
        {
            _empSkillsMapping = empSkillsMapping;
        }

        [HttpGet]
        [Route("api/[controller]")]
        [Authorize(Roles = "Administrator,Seller")]
        public IActionResult GetEmployeeSkillMappings()
        {
            var esm = _empSkillsMapping.GetSkillMappings();
            if (esm != null)
            {
                return Ok(esm);
            }
            else return NotFound("Employees-Skills Mappings Records not Found");
        }

        [HttpGet]
        [Route("api/[controller]/ExtendedEmployeeSkillMappings")]
        [Authorize(Roles = "Administrator,Seller")]
        public IActionResult GetExtendedEmployeeSkillMappings()
        {
            var esm = _empSkillsMapping.GetExtendedEmployeeSkillsMappings();
            if (esm != null)
            {
                return Ok(esm);
            }
            else return NotFound("Extended Employees-Skills Mappings Records not Found");
        }


        [HttpGet]
        [Route("api/[controller]/GetSkillMappingByEmpCode/{code}")]
        [Authorize(Roles = "Administrator,Seller")]
        public IActionResult GetSkillMappingByEmpCode(string code)
        {
            var esm = _empSkillsMapping.GetSkillMappingByEmpCode(code);
            if (esm != null)
            {
                return Ok(esm);
            }
            else return NotFound($"Employee-Skill Record with code: {code} was not Found");
        }


        [HttpGet]
        [Route("api/[controller]/GetSkillMappingBySkillId/{skillId}")]
        [Authorize(Roles = "Administrator,Seller")]
        public IActionResult GetSkillMappingBySkillId(string skillId)
        {
            var esm = _empSkillsMapping.GetSkillMappingBySkillId(skillId);
            if (esm != null)
            {
                return Ok(esm);
            }
            else return NotFound($"Employee-Skill Record with SkillId: {skillId} was not Found");
        }


        [HttpGet]
        [Route("api/[controller]/{mapId}")]
        [Authorize(Roles = "Administrator,Seller")]
        public IActionResult GetSkillMappingByMapId(string mapId)
        {
            var esm = _empSkillsMapping.GetSkillMappingByMapId(mapId);
            if (esm != null)
            {
                return Ok(esm);
            }
            else return NotFound($"Employee-Skill Record with MapId: {mapId} was not Found");
        }


        [HttpPatch]
        [Route("api/[controller]/{mapId}")]
        [Authorize(Roles = "Administrator,Seller")]
        public IActionResult UpdateSkillMapping(string mapId, EmployeeSkillsMapping empSkillsMapping)
        {
            var esm = _empSkillsMapping.GetSkillMappingByMapId(mapId);
            if (esm != null)
            {
                empSkillsMapping.MapId = esm.MapId;
                empSkillsMapping = _empSkillsMapping.EditSkill(empSkillsMapping);
            }

            return Ok(empSkillsMapping);

        }

        [HttpDelete]
        [Route("api/[controller]/{mapId}")]
        [Authorize(Roles = "Administrator,Seller")]
        public IActionResult DeleteEmployee(string mapId)
        {
            var esm = _empSkillsMapping.GetSkillMappingByMapId(mapId);
            if (esm != null)
            {
                _empSkillsMapping.DeleteSkillMapping(esm);
                return Ok();
            }
            else return NotFound($"Employee-Skill Record with MapId: {mapId} was not Found");


        }

        [HttpPost]
        [Route("api/[controller]")]
        [Authorize(Roles = "Administrator,Seller")]
        public IActionResult AddEmployeeSkillMapping(EmployeeSkillsMapping empSkillsMapping)
        {
            _empSkillsMapping.AddSkillMapping(empSkillsMapping);

            return Ok(empSkillsMapping);

        }
    }
}
