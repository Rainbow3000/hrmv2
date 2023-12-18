using Core.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace HRM.Infrastructure.DataAccess
{
    public class MySQLDBContext : DbContext
    {

        static readonly string connectionString = "Server=localhost; port=3306; User ID=root; Password=abcd; Database=blog";
        private readonly IConfiguration _configuration;

        public MySQLDBContext(IConfiguration configuration)
        {
            _configuration = configuration; 
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
           /* optionsBuilder.UseMySql(_configuration.GetConnectionString("connString"), ServerVersion.AutoDetect(_configuration.GetConnectionString("connString")))*/;
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<EmployeeEntity>()
                .HasOne(e => e.WorkInfo)
                .WithOne(w => w.Employee)
                .HasForeignKey<WorkInfoEntity>(w => w.EmployeeId);

            modelBuilder.Entity<EmployeeEntity>()
                .HasOne(e => e.Education)
                .WithOne(edu => edu.Employee)
                .HasForeignKey<EducationEntity>(edu => edu.EmployeeId);

            modelBuilder.Entity<EmployeeEntity>()
                .HasOne(e => e.Experience)
                .WithOne(exp => exp.Employee)
                .HasForeignKey<ExperienceEntity>(exp => exp.EmployeeId);

            modelBuilder.Entity<EmployeeEntity>()
                .HasOne(e => e.File)
                .WithOne(f => f.Employee)
                .HasForeignKey<FileEntity>(f => f.EmployeeId);

            modelBuilder.Entity<EmployeeEntity>()
               .HasOne(e => e.PermanentResidence)
               .WithOne(pr => pr.Employee)
               .HasForeignKey<PermanentResidenceEntity>(pr => pr.EmployeeId);


            modelBuilder.Entity<EmployeeEntity>()
               .HasOne(e => e.NowAddress)
               .WithOne(na => na.Employee)
               .HasForeignKey<NowAddressEnity>(na => na.EmployeeId);

            modelBuilder.Entity<EmployeeEntity>()
               .HasOne(e => e.Hometown)
               .WithOne(ht => ht.Employee)
               .HasForeignKey<HometownEntity>(ht => ht.EmployeeId);

            modelBuilder.Entity<EmployeeEntity>()
               .HasOne(e => e.UrgentContact)
               .WithOne(uc => uc.Employee)
               .HasForeignKey<UrgentContactEntity>(uc => uc.EmployeeId);

            modelBuilder.Entity<EmployeeEntity>()
               .HasOne(e => e.SalaryInfo)
               .WithOne(si => si.Employee)
               .HasForeignKey<SalaryInfoEntity>(si => si.EmployeeId);

            modelBuilder.Entity<EmployeeEntity>()
               .HasOne(e => e.AllowanceSalary)
               .WithOne(als => als.Employee)
               .HasForeignKey<AllowanceSalaryEntity>(als => als.EmployeeId);

            modelBuilder.Entity<EmployeeEntity>()
               .HasOne(e => e.DeductibleSalary)
               .WithOne(ds => ds.Employee)
               .HasForeignKey<DeductibleSalaryEntity>(ds => ds.EmployeeId);
        }

        public DbSet<EmployeeEntity> Employees { get; set; }
        public DbSet<WorkInfoEntity> WorkInfos   { get; set; }
        public DbSet<EducationEntity> Educations { get; set; }
        public DbSet<ExperienceEntity> Experiences { get; set; }
        public DbSet<FileEntity> Files { get; set; }
        public DbSet<PermanentResidenceEntity> PermanentResidences { get; set; }
        public DbSet<NowAddressEnity> NowAddresses { get; set; }
        public DbSet<HometownEntity> Hometowns { get; set; }
        public DbSet<UrgentContactEntity> UrgentContacts { get; set; }
        public DbSet<SalaryInfoEntity> SalaryInfos { get; set; }
        public DbSet<AllowanceSalaryEntity> AllowanceSalary { get; set; }
        public DbSet<DeductibleSalaryEntity> DeductibleSalary { get; set; }

    }

}
