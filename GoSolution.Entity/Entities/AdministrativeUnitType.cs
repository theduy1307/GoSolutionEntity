namespace GoSolution.Entity.Entities;

public class AdministrativeUnitType
{
    public Guid Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public ICollection<AdministrativeUnitType> AdministrativeUnitTypes { get; set; } = new List<AdministrativeUnitType>();
}