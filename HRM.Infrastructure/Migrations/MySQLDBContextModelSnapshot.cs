﻿// <auto-generated />
using System;
using HRM.Infrastructure.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace HRM.Infrastructure.Migrations
{
    [DbContext(typeof(MySQLDBContext))]
    partial class MySQLDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Core.Entity.AccountEntity", b =>
                {
                    b.Property<Guid>("AccountId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("longtext");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<Guid>("EmployeeId")
                        .HasColumnType("char(36)");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("longtext");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("AccountId");

                    b.HasIndex("EmployeeId")
                        .IsUnique();

                    b.HasIndex("UserName")
                        .IsUnique();

                    b.ToTable("Accounts");
                });

            modelBuilder.Entity("Core.Entity.AllowanceSalaryEntity", b =>
                {
                    b.Property<Guid>("AllowanceSalaryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("AllowanceName")
                        .HasColumnType("longtext");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("longtext");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<Guid>("EmployeeId")
                        .HasColumnType("char(36)");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("longtext");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<double?>("Value")
                        .HasColumnType("double");

                    b.HasKey("AllowanceSalaryId");

                    b.HasIndex("EmployeeId");

                    b.ToTable("AllowanceSalary");
                });

            modelBuilder.Entity("Core.Entity.DeductibleSalaryEntity", b =>
                {
                    b.Property<Guid>("DeductibleSalaryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("longtext");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("DeductibleName")
                        .HasColumnType("longtext");

                    b.Property<Guid>("EmployeeId")
                        .HasColumnType("char(36)");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("longtext");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<double?>("Value")
                        .HasColumnType("double");

                    b.HasKey("DeductibleSalaryId");

                    b.HasIndex("EmployeeId");

                    b.ToTable("DeductibleSalary");
                });

            modelBuilder.Entity("Core.Entity.EducationEntity", b =>
                {
                    b.Property<Guid>("EducationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("Classification")
                        .HasColumnType("longtext");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("longtext");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Degree")
                        .HasColumnType("longtext");

                    b.Property<string>("EducationPlace")
                        .HasColumnType("longtext");

                    b.Property<Guid>("EmployeeId")
                        .HasColumnType("char(36)");

                    b.Property<int?>("FromYear")
                        .HasColumnType("int");

                    b.Property<string>("GraduationYear")
                        .HasColumnType("longtext");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("longtext");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Specialized")
                        .HasColumnType("longtext");

                    b.Property<int?>("ToYear")
                        .HasColumnType("int");

                    b.HasKey("EducationId");

                    b.HasIndex("EmployeeId");

                    b.ToTable("Educations");
                });

            modelBuilder.Entity("Core.Entity.EmployeeEntity", b =>
                {
                    b.Property<Guid>("EmployeeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<int?>("Bank")
                        .HasColumnType("int");

                    b.Property<string>("BankAccount")
                        .HasColumnType("longtext");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("longtext");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime?>("Dob")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Fullname")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<int?>("Gender")
                        .HasColumnType("int");

                    b.Property<string>("IdentifyDateRange")
                        .HasColumnType("longtext");

                    b.Property<string>("IdentifyIssuedBy")
                        .HasColumnType("longtext");

                    b.Property<string>("IdentifyNumber")
                        .HasColumnType("longtext");

                    b.Property<int?>("IdentifyType")
                        .HasColumnType("int");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("longtext");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("OrganEmail")
                        .HasColumnType("longtext");

                    b.Property<string>("PersonalEmail")
                        .HasColumnType("longtext");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("varchar(25)");

                    b.Property<string>("TaxtCode")
                        .HasColumnType("longtext");

                    b.Property<string>("TaxtCodeDateRange")
                        .HasColumnType("longtext");

                    b.Property<string>("TaxtCodeIssuedBy")
                        .HasColumnType("longtext");

                    b.HasKey("EmployeeId");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("Core.Entity.ExperienceEntity", b =>
                {
                    b.Property<Guid>("ExperienceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("ComparePerson")
                        .HasColumnType("longtext");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("longtext");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<Guid>("EmployeeId")
                        .HasColumnType("char(36)");

                    b.Property<string>("FromDay")
                        .HasColumnType("longtext");

                    b.Property<bool?>("IsCheckedCompare")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("longtext");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Note")
                        .HasColumnType("longtext");

                    b.Property<string>("ToDay")
                        .HasColumnType("longtext");

                    b.Property<string>("WorkPlace")
                        .HasColumnType("longtext");

                    b.Property<string>("WorkPosition")
                        .HasColumnType("longtext");

                    b.HasKey("ExperienceId");

                    b.HasIndex("EmployeeId");

                    b.ToTable("Experiences");
                });

            modelBuilder.Entity("Core.Entity.FileEntity", b =>
                {
                    b.Property<Guid>("FileId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("longtext");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<Guid>("EmployeeId")
                        .HasColumnType("char(36)");

                    b.Property<string>("FileName")
                        .HasColumnType("longtext");

                    b.Property<string>("FileUrl")
                        .HasColumnType("longtext");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("longtext");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("UploadDate")
                        .HasColumnType("longtext");

                    b.HasKey("FileId");

                    b.HasIndex("EmployeeId");

                    b.ToTable("Files");
                });

            modelBuilder.Entity("Core.Entity.HometownEntity", b =>
                {
                    b.Property<Guid>("HometownId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("City")
                        .HasColumnType("longtext");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("longtext");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("District")
                        .HasColumnType("longtext");

                    b.Property<Guid>("EmployeeId")
                        .HasColumnType("char(36)");

                    b.Property<string>("HouseNumber")
                        .HasColumnType("longtext");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("longtext");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Wards")
                        .HasColumnType("longtext");

                    b.HasKey("HometownId");

                    b.HasIndex("EmployeeId")
                        .IsUnique();

                    b.ToTable("Hometowns");
                });

            modelBuilder.Entity("Core.Entity.NowAddressEntity", b =>
                {
                    b.Property<Guid>("NowAddressId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("City")
                        .HasColumnType("longtext");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("longtext");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("District")
                        .HasColumnType("longtext");

                    b.Property<Guid>("EmployeeId")
                        .HasColumnType("char(36)");

                    b.Property<string>("HouseNumber")
                        .HasColumnType("longtext");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("longtext");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Wards")
                        .HasColumnType("longtext");

                    b.HasKey("NowAddressId");

                    b.HasIndex("EmployeeId")
                        .IsUnique();

                    b.ToTable("NowAddresses");
                });

            modelBuilder.Entity("Core.Entity.PermanentResidenceEntity", b =>
                {
                    b.Property<Guid>("PermanentResidenceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("City")
                        .HasColumnType("longtext");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("longtext");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("District")
                        .HasColumnType("longtext");

                    b.Property<Guid>("EmployeeId")
                        .HasColumnType("char(36)");

                    b.Property<string>("HouseNumber")
                        .HasColumnType("longtext");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("longtext");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Wards")
                        .HasColumnType("longtext");

                    b.HasKey("PermanentResidenceId");

                    b.HasIndex("EmployeeId")
                        .IsUnique();

                    b.ToTable("PermanentResidences");
                });

            modelBuilder.Entity("Core.Entity.SalaryInfoEntity", b =>
                {
                    b.Property<Guid>("SalaryInfoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<double?>("BasicSalary")
                        .HasColumnType("double");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("longtext");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<Guid>("EmployeeId")
                        .HasColumnType("char(36)");

                    b.Property<double?>("GrossSalary")
                        .HasColumnType("double");

                    b.Property<double?>("InsuranceSalary")
                        .HasColumnType("double");

                    b.Property<string>("LevelSalary")
                        .HasColumnType("longtext");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("longtext");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<double?>("NetSalary")
                        .HasColumnType("double");

                    b.Property<double?>("TotalSalary")
                        .HasColumnType("double");

                    b.HasKey("SalaryInfoId");

                    b.HasIndex("EmployeeId")
                        .IsUnique();

                    b.ToTable("SalaryInfos");
                });

            modelBuilder.Entity("Core.Entity.UrgentContactEntity", b =>
                {
                    b.Property<Guid>("UrgentContactId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("longtext");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<Guid>("EmployeeId")
                        .HasColumnType("char(36)");

                    b.Property<string>("FullName")
                        .HasColumnType("longtext");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("longtext");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("longtext");

                    b.Property<string>("Relational")
                        .HasColumnType("longtext");

                    b.HasKey("UrgentContactId");

                    b.HasIndex("EmployeeId")
                        .IsUnique();

                    b.ToTable("UrgentContacts");
                });

            modelBuilder.Entity("Core.Entity.WorkInfoEntity", b =>
                {
                    b.Property<Guid>("WorkInfoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<int?>("ContractType")
                        .HasColumnType("int");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("longtext");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<Guid>("EmployeeId")
                        .HasColumnType("char(36)");

                    b.Property<string>("GoogleCalendarId")
                        .HasColumnType("longtext");

                    b.Property<bool?>("IsExemptTimeKeeper")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("ManagerId")
                        .HasColumnType("longtext");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("longtext");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("PositionId")
                        .HasColumnType("longtext");

                    b.Property<int?>("Status")
                        .HasColumnType("int");

                    b.Property<string>("TimeKeeperCode")
                        .HasColumnType("longtext");

                    b.Property<string>("UnitId")
                        .HasColumnType("longtext");

                    b.Property<int?>("WorkType")
                        .HasColumnType("int");

                    b.HasKey("WorkInfoId");

                    b.HasIndex("EmployeeId")
                        .IsUnique();

                    b.ToTable("WorkInfos");
                });

            modelBuilder.Entity("Core.Entity.AccountEntity", b =>
                {
                    b.HasOne("Core.Entity.EmployeeEntity", "Employee")
                        .WithOne("Account")
                        .HasForeignKey("Core.Entity.AccountEntity", "EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("Core.Entity.AllowanceSalaryEntity", b =>
                {
                    b.HasOne("Core.Entity.EmployeeEntity", "Employee")
                        .WithMany("AllowanceSalary")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("Core.Entity.DeductibleSalaryEntity", b =>
                {
                    b.HasOne("Core.Entity.EmployeeEntity", "Employee")
                        .WithMany("DeductibleSalary")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("Core.Entity.EducationEntity", b =>
                {
                    b.HasOne("Core.Entity.EmployeeEntity", "Employee")
                        .WithMany("Education")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("Core.Entity.ExperienceEntity", b =>
                {
                    b.HasOne("Core.Entity.EmployeeEntity", "Employee")
                        .WithMany("Experience")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("Core.Entity.FileEntity", b =>
                {
                    b.HasOne("Core.Entity.EmployeeEntity", "Employee")
                        .WithMany("File")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("Core.Entity.HometownEntity", b =>
                {
                    b.HasOne("Core.Entity.EmployeeEntity", "Employee")
                        .WithOne("Hometown")
                        .HasForeignKey("Core.Entity.HometownEntity", "EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("Core.Entity.NowAddressEntity", b =>
                {
                    b.HasOne("Core.Entity.EmployeeEntity", "Employee")
                        .WithOne("NowAddress")
                        .HasForeignKey("Core.Entity.NowAddressEntity", "EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("Core.Entity.PermanentResidenceEntity", b =>
                {
                    b.HasOne("Core.Entity.EmployeeEntity", "Employee")
                        .WithOne("PermanentResidence")
                        .HasForeignKey("Core.Entity.PermanentResidenceEntity", "EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("Core.Entity.SalaryInfoEntity", b =>
                {
                    b.HasOne("Core.Entity.EmployeeEntity", "Employee")
                        .WithOne("SalaryInfo")
                        .HasForeignKey("Core.Entity.SalaryInfoEntity", "EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("Core.Entity.UrgentContactEntity", b =>
                {
                    b.HasOne("Core.Entity.EmployeeEntity", "Employee")
                        .WithOne("UrgentContact")
                        .HasForeignKey("Core.Entity.UrgentContactEntity", "EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("Core.Entity.WorkInfoEntity", b =>
                {
                    b.HasOne("Core.Entity.EmployeeEntity", "Employee")
                        .WithOne("WorkInfo")
                        .HasForeignKey("Core.Entity.WorkInfoEntity", "EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("Core.Entity.EmployeeEntity", b =>
                {
                    b.Navigation("Account")
                        .IsRequired();

                    b.Navigation("AllowanceSalary");

                    b.Navigation("DeductibleSalary");

                    b.Navigation("Education");

                    b.Navigation("Experience");

                    b.Navigation("File");

                    b.Navigation("Hometown")
                        .IsRequired();

                    b.Navigation("NowAddress")
                        .IsRequired();

                    b.Navigation("PermanentResidence")
                        .IsRequired();

                    b.Navigation("SalaryInfo")
                        .IsRequired();

                    b.Navigation("UrgentContact")
                        .IsRequired();

                    b.Navigation("WorkInfo")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
