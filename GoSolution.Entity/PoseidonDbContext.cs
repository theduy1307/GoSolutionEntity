using GoSolution.Entity.Entities;
using Microsoft.EntityFrameworkCore;

namespace GoSolution.Entity;

public class PoseidonDbContext : DbContext
{
    public PoseidonDbContext(DbContextOptions<PoseidonDbContext> options) 
        : base(options) { }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=localhost,1433;Database=Poseidon;User Id=sa;Password=P@ssw0rd&user=nimda-repus;TrustServerCertificate=True");
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
    public DbSet<MenuRole> MenuRoles { get; set; }
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
        
        modelBuilder.Entity<RoleRight>()
            .HasKey(rr => new { rr.RoleId, rr.RightId });
        
        modelBuilder.Entity<EmployeeRole>()
            .HasKey(er => new { er.RoleId, er.EmployeeId });
        
        modelBuilder.Entity<MenuRole>()
            .HasKey(mr => new { mr.RoleId, mr.MenuId });
        
        base.OnModelCreating(modelBuilder);
        
        modelBuilder.Entity<Menu>()
            .HasOne(m => m.Parent)
            .WithMany(m => m.SubMenus)
            .HasForeignKey(m => m.ParentId)
            .OnDelete(DeleteBehavior.Restrict);

        // Seeding datas
        var employeeId = 1;
        modelBuilder.Entity<Employee>().HasData(
            new Employee
            {
                Id = employeeId, 
                FirstName = "TRAN", 
                LastName = "The Duy",
                Email = "tran.theduy@gmail.com",
                DateOfBirth = new DateOnly(1998, 7, 13),
                CreateDate = DateTime.UtcNow,
                CreatedBy = 1,
            }
        );
        modelBuilder.Entity<Account>().HasData(
            new Account
            {
                Id = 1, 
                EmployeeId = employeeId,
                Username = "tran.theduy", 
                Password = "ZSj61OnHWu2M2z18w2x+nZuczHNSaw07SlOQQDfkioE=",
                Salt = "mCwnlqAepUBDxyJ2z3FnYC2z",
                IsActive = true,
                CreateDate = DateTime.UtcNow,
                CreatedBy = 1,
            }
        );
        modelBuilder.Entity<Right>().HasData(
            new Right() { Id = 1, Name = "Create employee and account" },
            new Right() { Id = 2, Name = "Create schedule" },
            new Right() { Id = 3, Name = "Create employee scheduling" });
        
        modelBuilder.Entity<Role>().HasData(
            new Role() { Id = 1, Name = "Admin" },
            new Role() { Id = 2, Name = "Manager" },
            new Role() { Id = 3, Name = "Member" });

        modelBuilder.Entity<RoleRight>().HasData(
            new RoleRight() { RoleId = 1, RightId = 1 },
            new RoleRight() { RoleId = 1, RightId = 2 },
            new RoleRight() { RoleId = 1, RightId = 3 },
            new RoleRight() { RoleId = 2, RightId = 2 },
            new RoleRight() { RoleId = 2, RightId = 3 });
        
        modelBuilder.Entity<EmployeeRole>().HasData(
            new EmployeeRole()
            {
                EmployeeId = employeeId,
                RoleId = 1
            });
        var humanResourceId = 1;
        modelBuilder.Entity<Menu>().HasData(
            new Menu() { Id = humanResourceId, Name = "Human resource", Icon = "manage_accounts" });
        modelBuilder.Entity<Menu>().HasData(
            new Menu() { Id = 2, Name = "Schedule", Icon = "schedule", ParentId = humanResourceId, Url = "schedule"});
        modelBuilder.Entity<MenuRole>().HasData(
            new MenuRole() { MenuId = 1, RoleId = 1 },
            new MenuRole() { MenuId = 2, RoleId = 1 });
    }
}