namespace GoSolution.Entity.Entities;

public class Country
{
    public Guid Id { get; set; }
    
    // ISO 3166-1 A-2
    public string IsoCode { get; set; } = string.Empty;
    public string Name { get; set; } = string.Empty;

    public ICollection<AdministrativeUnitType> AdministrativeUnitTypes { get; set; } =
        new List<AdministrativeUnitType>();
    public ICollection<Ethnicity> Ethnicities { get; set; } = new List<Ethnicity>();
    public ICollection<Employee> Employees { get; set; } = new List<Employee>();
}