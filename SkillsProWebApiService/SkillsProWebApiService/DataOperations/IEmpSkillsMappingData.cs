using SkillsProWebApiService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SkillsProWebApiService.DataOperations
{
    public interface IEmpSkillsMappingData
    {
        List<EmployeeSkillsMapping> GetSkillMappings();

        EmployeeSkillsMapping GetSkillMappingByMapId(string mapId);

        List<ExtendedEmployeeSkillsMapping> GetExtendedEmployeeSkillsMappings();

        List<EmployeeSkillsMapping> GetSkillMappingBySkillId(string skillId);

        List<EmployeeSkillsMapping> GetSkillMappingByEmpCode(string code);

        EmployeeSkillsMapping AddSkillMapping(EmployeeSkillsMapping SkillMapping);

        void DeleteSkillMapping(EmployeeSkillsMapping SkillMapping);

        EmployeeSkillsMapping EditSkill(EmployeeSkillsMapping SkillMapping);
    }
}
