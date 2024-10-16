namespace GoSolution.Entity.Entities;

public class Ethnicity
{
    public Guid Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public Country Country { get; set; } = new Country();
    public ICollection<Employee> Employees { get; set; } = new List<Employee>();
}