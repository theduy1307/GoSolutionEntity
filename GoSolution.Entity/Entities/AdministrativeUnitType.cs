using System.ComponentModel.DataAnnotations;

namespace GoSolution.Entity.Entities;

public class AdministrativeUnitType : EntityBase
{
    [StringLength(100)]
    public string Name { get; set; } = string.Empty;
    [StringLength(400)]
    public string Description { get; set; } = string.Empty;
    public ICollection<AdministrativeUnit> AdministrativeUnits { get; set; } = new List<AdministrativeUnit>();
}