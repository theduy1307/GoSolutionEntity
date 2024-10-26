using System.ComponentModel.DataAnnotations;

namespace GoSolution.Entity.Entities;

public class Religion : EntityBase
{
    [StringLength(100)]
    public string Name { get; set; } = string.Empty;
    public ICollection<Employee> Employees = new List<Employee>();
}