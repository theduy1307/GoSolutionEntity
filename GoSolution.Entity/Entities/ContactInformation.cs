using System.ComponentModel.DataAnnotations;

namespace GoSolution.Entity.Entities;

public class ContactInformation : EntityBase
{
    public Guid EmployeeId { get; set; }
    public Employee Employee { get; set; } = new Employee();
    [StringLength(100)]
    public string Email { get; set; } = string.Empty;
}