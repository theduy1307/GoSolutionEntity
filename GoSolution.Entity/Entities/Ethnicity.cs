using System.ComponentModel.DataAnnotations;

namespace GoSolution.Entity.Entities;

public class Ethnicity : EntityBase
{
    [StringLength(50)]
    public string Name { get; set; } = string.Empty;
    
    public Country Country { get; set; } = new Country();
    public ICollection<Employee> Employees { get; set; } = new List<Employee>();
}