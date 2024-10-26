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
    public DbSet<AdministrativeUnit> AdministrativeUnits { get; set; }
    public DbSet<AdministrativeUnitType> AdministrativeUnitTypes { get; set; }
    public DbSet<ContactInformation> ContactInformations { get; set; }
    public DbSet<Country> Countries { get; set; }
    public DbSet<EducationLevel> EducationLevels { get; set; }
    public DbSet<Employee> Employees { get; set; }
    public DbSet<Ethnicity> Ethnicities { get; set; }
    public DbSet<PlaceOfIssueOfNationalIdentification> PlaceOfIssueOfNationalIdentifications { get; set; }
    public DbSet<PlaceOfIssueOfPassport> PlaceOfIssueOfPassports { get; set; }
    public DbSet<PoliticalQualification> PoliticalQualifications { get; set; }
    public DbSet<Religion> Religions { get; set; }
    public DbSet<Specialization> Specializations { get; set; }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
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
    }
}