﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SkillsProWebApiService.Models
{
    public partial class Skills
    {
        public Skills()
        {
            
        
        }
        
        [Key]
        public string SkillId { get; set; }
        
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }

    }
}