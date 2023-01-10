using SkillsProWebApiService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SkillsProWebApiService.DataOperations
{
    public class EmpSkillsMappingData : IEmpSkillsMappingData
    {
        private SkillsProDBContext _context;

        public EmpSkillsMappingData(SkillsProDBContext skillsProDBContext)
        {
            _context = skillsProDBContext;
        }
        public EmployeeSkillsMapping AddSkillMapping(EmployeeSkillsMapping skillMapping)
        {
            if (string.IsNullOrEmpty(skillMapping.MapId))
            {
                skillMapping.MapId = "ESM" + Guid.NewGuid();
            }
            _context.EmployeeSkillsMapping.Add(skillMapping);
            _context.SaveChanges();
            return skillMapping;
        }

        public void DeleteSkillMapping(EmployeeSkillsMapping skillMapping)
        {
            _context.EmployeeSkillsMapping.Remove(skillMapping);
            _context.SaveChanges();
        }

        public EmployeeSkillsMapping EditSkill(EmployeeSkillsMapping skillMapping)
        {
            var existinSkillMapping = GetSkillMappingByMapId(skillMapping.MapId);
            if (existinSkillMapping.EmployeeId != skillMapping.EmployeeId)
                existinSkillMapping.EmployeeId = skillMapping.EmployeeId;

            if (existinSkillMapping.SkillId != skillMapping.SkillId)
                existinSkillMapping.SkillId = skillMapping.SkillId;
            //existingEmployee.AnnualSalary = employee.AnnualSalary;
            //existingEmployee.DateOfBirth = employee.DateOfBirth;
            //existingEmployee.Gender = employee.Gender;
            _context.SaveChanges();
            return existinSkillMapping;
        }

        public List<EmployeeSkillsMapping> GetSkillMappingByEmpCode(string code)
        {
            return _context.EmployeeSkillsMapping.Where(x => x.EmployeeId == code).ToList();
        }

        public EmployeeSkillsMapping GetSkillMappingByMapId(string mapId)
        {
            var existinSkillMapping = _context.EmployeeSkillsMapping.Find(mapId);

            return existinSkillMapping;
        }

        public List<EmployeeSkillsMapping> GetSkillMappingBySkillId(string skillId)
        {
            return _context.EmployeeSkillsMapping.Where(x => x.SkillId == skillId).ToList();
        }

        public List<EmployeeSkillsMapping> GetSkillMappings()
        {
            return _context.EmployeeSkillsMapping.ToList();
        }

        public List<ExtendedEmployeeSkillsMapping> GetExtendedEmployeeSkillsMappings()
        {
            List<ExtendedEmployeeSkillsMapping> extended = new List<ExtendedEmployeeSkillsMapping>();
            List<EmployeeSkillsMapping> employeeSkillsMapping = _context.EmployeeSkillsMapping.ToList();

            employeeSkillsMapping.ForEach(esm =>  {
                extended.Add(new ExtendedEmployeeSkillsMapping() {
                  EmployeeId = esm.EmployeeId,
                  MapId = esm.MapId,
                  SkillId = esm.SkillId,
                  EmployeeName = _context.Employees.Find(esm.EmployeeId).Name,
                  SkillName = _context.Skills.Find(esm.SkillId).Name
                });
            });


            return extended;
        }
    }
}
