﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SkillsProWebApiService.Models
{
    public partial class Employees
    {
        public Employees()
        {
            
        }

        [Key]
        public string Code { get; set; }

        [Required]
        public string Name { get; set; }
        public string Gender { get; set; }
        public float AnnualSalary { get; set; }
        public string DateOfBirth { get; set; }       
    }
}