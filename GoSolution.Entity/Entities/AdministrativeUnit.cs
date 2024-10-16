namespace GoSolution.Entity.Entities;

public class AdministrativeUnit
{
    public Guid Id { get; set; }
    public Guid? ParentUnitId { get; set; }
    public string Name { get; set; } = string.Empty;
    public bool Active { get; set; }
    public Country Country { get; set; } = new Country();
    public AdministrativeUnitType AdministrativeUnitType { get; set; } = new AdministrativeUnitType();
    public ICollection<Employee> Employees { get; set; } = new List<Employee>();
}