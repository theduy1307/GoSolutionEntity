using System.ComponentModel.DataAnnotations;

namespace GoSolution.Entity.Entities;

public class Specialization : EntityBase
{
    [StringLength(100)]
    public string Name { get; set; } = string.Empty;
    
    public ICollection<Employee> Employees { get; set; } = new List<Employee>();
}