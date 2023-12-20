using Core.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;

namespace HRM.Infrastructure.DataAccess
{
    public class MySQLDBContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql("Server=localhost; port=3306; User ID=root; Password=abcd; Database=hrm", ServerVersion.AutoDetect("Server=localhost; port=3306; User ID=root; Password=abcd; Database=hrm"));
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<AccountEntity>().HasIndex(a => a.UserName).IsUnique(); 

            modelBuilder.Entity<EmployeeEntity>().Property(p => p.Code).IsRequired().HasMaxLength(100); 
            modelBuilder.Entity<EmployeeEntity>().Property(p => p.Fullname).IsRequired().HasMaxLength(100);
            modelBuilder.Entity<EmployeeEntity>().Property(p => p.PhoneNumber).IsRequired().HasMaxLength(25);

            modelBuilder.Entity<EmployeeEntity>()
                .HasOne(e => e.WorkInfo)
                .WithOne(w => w.Employee)
                .HasForeignKey<WorkInfoEntity>(w => w.EmployeeId);

            modelBuilder.Entity<EducationEntity>().HasOne<EmployeeEntity>(edu => edu.Employee).WithMany(e => e.Education).HasForeignKey(edu => edu.EmployeeId).OnDelete(DeleteBehavior.Cascade);


            modelBuilder.Entity<ExperienceEntity>().HasOne<EmployeeEntity>(exp => exp.Employee).WithMany(e => e.Experience).HasForeignKey(exp => exp.EmployeeId);

            modelBuilder.Entity<FileEntity>().HasOne<EmployeeEntity>(f => f.Employee).WithMany(e => e.File).HasForeignKey(f => f.EmployeeId);

        
            modelBuilder.Entity<EmployeeEntity>()
               .HasOne(e => e.PermanentResidence)
               .WithOne(pr => pr.Employee)
               .HasForeignKey<PermanentResidenceEntity>(pr => pr.EmployeeId);


            modelBuilder.Entity<EmployeeEntity>()
               .HasOne(e => e.NowAddress)
               .WithOne(na => na.Employee)
               .HasForeignKey<NowAddressEntity>(na => na.EmployeeId);

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
              .HasOne(e => e.Account)
              .WithOne(a => a.Employee)
              .HasForeignKey<AccountEntity>(a => a.EmployeeId);


            modelBuilder.Entity<AllowanceSalaryEntity>().HasOne<EmployeeEntity>(als => als.Employee).WithMany(e => e.AllowanceSalary
            ).HasForeignKey(als => als.EmployeeId);


            modelBuilder.Entity<DeductibleSalaryEntity>().HasOne<EmployeeEntity>(dts => dts.Employee).WithMany(e => e.DeductibleSalary
            ).HasForeignKey(dts => dts.EmployeeId);

          
        }
        public DbSet<AccountEntity> Accounts { get; set; }
        public DbSet<EmployeeEntity> Employees { get; set; }
        public DbSet<WorkInfoEntity> WorkInfos   { get; set; }
        public DbSet<EducationEntity> Educations { get; set; }
        public DbSet<ExperienceEntity> Experiences { get; set; }
        public DbSet<FileEntity> Files { get; set; }
        public DbSet<PermanentResidenceEntity> PermanentResidences { get; set; }
        public DbSet<NowAddressEntity> NowAddresses { get; set; }
        public DbSet<HometownEntity> Hometowns { get; set; }
        public DbSet<UrgentContactEntity> UrgentContacts { get; set; }
        public DbSet<SalaryInfoEntity> SalaryInfos { get; set; }
        public DbSet<AllowanceSalaryEntity> AllowanceSalary { get; set; }
        public DbSet<DeductibleSalaryEntity> DeductibleSalary { get; set; }

    }

}
