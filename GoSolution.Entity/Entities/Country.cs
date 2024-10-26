using System.ComponentModel.DataAnnotations;

namespace GoSolution.Entity.Entities;

public class Country : EntityBase
{
    // ISO 3166-1 A-2
    [StringLength(2)]
    public string IsoCode { get; set; } = string.Empty;
    
    [StringLength(100)]
    public string Name { get; set; } = string.Empty;

    public ICollection<AdministrativeUnitType> AdministrativeUnitTypes { get; set; } =
        new List<AdministrativeUnitType>();
    public ICollection<Ethnicity> Ethnicities { get; set; } = new List<Ethnicity>();
    public ICollection<Employee> Employees { get; set; } = new List<Employee>();
}