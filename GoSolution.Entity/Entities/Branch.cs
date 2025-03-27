namespace GoSolution.Entity.Entities;

public class Branch : EntityBase
{
    public string Name { get; set; }
    public ICollection<Employee> Employees { get; set; }
}