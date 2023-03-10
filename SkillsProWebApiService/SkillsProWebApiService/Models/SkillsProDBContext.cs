// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace SkillsProWebApiService.Models
{
    public partial class SkillsProDBContext : DbContext
    {
        public SkillsProDBContext()
        {
        }

        public SkillsProDBContext(DbContextOptions<SkillsProDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<EmployeeSkillsMapping> EmployeeSkillsMapping { get; set; }
        public virtual DbSet<Employees> Employees { get; set; }
        public virtual DbSet<Skills> Skills { get; set; }

        public virtual DbSet<UserLogin> UserLogins { get; set; }

        public virtual DbSet<UserModel> UserModels { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                //#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=tcp:faganti.database.windows.net;Initial Catalog=SkillsProDB;User ID=fa.ganti@reply.com;Authentication=ActiveDirectoryDefault");
            }
        }
        
    }
}