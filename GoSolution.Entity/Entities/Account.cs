using System.ComponentModel.DataAnnotations;

namespace GoSolution.Entity.Entities;

public class Account : EntityBase
{
    public Guid EmployeeId { get; set; }
    public Employee Employee { get; set; } = new Employee();
    public bool IsActive { get; set; }
    public DateTime LastLogin { get; set; }
    [StringLength(50)]
    public string Username { get; set; } = string.Empty;
    [StringLength(32)]
    public string Password { get; set; } = string.Empty;
    [StringLength(5)]
    public string Salt { get; set; } = string.Empty;
}