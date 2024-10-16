namespace GoSolution.Entity.Entities;

public class Religion
{
    public Guid Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public ICollection<Employee> Employees = new List<Employee>();
}