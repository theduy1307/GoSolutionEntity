using System.Text.Json;
using GoSolution.Entity.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace GoSolution.Entity;

public class PoseidonDbContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        // Load configuration from appsettings.json
        var configuration = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json")
            .Build();
        var connectionString = configuration.GetConnectionString("DefaultConnection");
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
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Optional: Apply configurations here if needed
        // Seed data cho bảng Products
        // Thêm dữ liệu mẫu
        // var countries = JsonSerializer.Deserialize<List<Country>>(Path.Combine("Common", "SeedData", "countries.json")) ?? [];
        // var administrativeUnitTypes = JsonSerializer.Deserialize<List<AdministrativeUnitType>>(Path.Combine("Common", "SeedData", "administrativeUnitTypes.json")) ?? [];
        // var administrativeUnits = JsonSerializer.Deserialize<List<AdministrativeUnit>>(Path.Combine("Common", "SeedData", "administrativeUnits.json")) ?? [];
        //
        // modelBuilder.Entity<Country>().HasData(countries);
        // modelBuilder.Entity<AdministrativeUnitType>().HasData(administrativeUnitTypes);
        // modelBuilder.Entity<AdministrativeUnit>().HasData(administrativeUnits);

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

    }
}