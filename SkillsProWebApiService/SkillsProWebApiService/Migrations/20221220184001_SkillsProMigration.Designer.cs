﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SkillsProWebApiService.Models;

namespace SkillsProWebApiService.Migrations
{
    [DbContext(typeof(SkillsProDBContext))]
    [Migration("20221220184001_SkillsProMigration")]
    partial class SkillsProMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SkillsProWebApiService.Models.EmployeeSkillsMapping", b =>
                {
                    b.Property<string>("MapId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("EmployeeId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SkillId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MapId");

                    b.ToTable("EmployeeSkillsMapping");
                });

            modelBuilder.Entity("SkillsProWebApiService.Models.Employees", b =>
                {
                    b.Property<string>("Code")
                        .HasColumnType("nvarchar(450)");

                    b.Property<float>("AnnualSalary")
                        .HasColumnType("real");

                    b.Property<string>("DateOfBirth")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Code");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("SkillsProWebApiService.Models.Skills", b =>
                {
                    b.Property<string>("SkillId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SkillId");

                    b.ToTable("Skills");
                });
#pragma warning restore 612, 618
        }
    }
}