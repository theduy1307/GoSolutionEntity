using System.Text.Json;
using GoSolution.Entity.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace GoSolution.Entity;

public class PoseidonDbContext : DbContext
{
    public PoseidonDbContext(DbContextOptions<PoseidonDbContext> options) 
        : base(options) { }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql("Host=localhost,5432; Database=Poseidon;Username=postgres;Password=P@ssw0rd&user=nimda-repus");
    }
    
    public DbSet<Account> Accounts { get; set; }
    public DbSet<Employee> Employees { get; set; }
    public DbSet<Schedule> Schedules { get; set; }
    public DbSet<EmployeeSchedule>  EmployeeSchedules { get; set; }
    public DbSet<Branch> Branches { get; set; }
    public DbSet<Role> Roles { get; set; }
    public DbSet<Right> Rights { get; set; }
    public DbSet<RoleRight> RoleRights { get; set; }
    public DbSet<Menu> Menus { get; set; }
    public DbSet<Candidate> Candidates { get; set; }
    public DbSet<EducationHistory> CandidateEducations { get; set; }
    public DbSet<Certificate> Certificates { get; set; }
    public DbSet<CandidateCertificate> EmployeeCertificates { get; set; }
    public DbSet<JobHistory> JobHistories { get; set; }
    public DbSet<RecruitmentCampaign> RecruimentCampaigns { get; set; }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<EmployeeSchedule>()
            .HasKey(ews => new { ews.EmployeeId, ews.ScheduleId });

        modelBuilder.Entity<EmployeeSchedule>()
            .HasOne(ews => ews.Employee)
            .WithMany(e => e.EmployeeSchedules)
            .HasForeignKey(ews => ews.EmployeeId);

        modelBuilder.Entity<EmployeeSchedule>()
            .HasOne(ews => ews.Schedule)
            .WithMany(ws => ws.EmployeeSchedules)
            .HasForeignKey(ews => ews.ScheduleId);
        base.OnModelCreating(modelBuilder);
        
        modelBuilder.Entity<RoleRight>()
            .HasKey(rr => new { rr.RoleId, rr.RightId }); // Thiết lập khóa chính
        
        modelBuilder.Entity<RoleRight>()
            .HasOne(rr => rr.Role)
            .WithMany(r => r.RoleRights)
            .HasForeignKey(rr => rr.RoleId);
        
        modelBuilder.Entity<RoleRight>()
            .HasOne(rr => rr.Right)
            .WithMany(r => r.RoleRights)
            .HasForeignKey(rr => rr.RightId);
        
        modelBuilder.Entity<Menu>()
            .HasOne(m => m.Parent)
            .WithMany(m => m.SubMenus)
            .HasForeignKey(m => m.ParentId)
            .OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<CandidateCertificate>()
            .HasKey(cc => new { cc.CandidateId, cc.CertificateId });
        
        modelBuilder.Entity<CandidateCertificate>()
            .HasOne(cc => cc.Candidate)
            .WithMany(c => c.CandidateCertificates)
            .HasForeignKey(cc => cc.CandidateId);

        modelBuilder.Entity<CandidateCertificate>()
            .HasOne(cc => cc.Certificate)
            .WithMany(c => c.CandidateCertificates)
            .HasForeignKey(cc => cc.CertificateId);
        
        modelBuilder.Entity<RecruitmentCampaignCertificate>()
            .HasKey(cc => new { cc.RecruitmentCampaignId, cc.CertificateId });
        
        modelBuilder.Entity<RecruitmentCampaignCertificate>()
            .HasOne(cc => cc.RecruitmentCampaign)
            .WithMany(c => c.RecruitmentCampaignCertificates)
            .HasForeignKey(cc => cc.RecruitmentCampaignId);

        modelBuilder.Entity<RecruitmentCampaignCertificate>()
            .HasOne(cc => cc.Certificate)
            .WithMany(c => c.RecruitmentCampaignCertificates)
            .HasForeignKey(cc => cc.CertificateId);

    }
}