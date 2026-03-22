using System.ComponentModel.DataAnnotations;

namespace GoSolution.Entity.Entities;

public class Account : EntityBase
{
    public int EmployeeId { get; set; }
    public Employee Employee { get; set; } = null!;
    public bool IsActive { get; set; }
    public DateTime? LastLogin { get; set; }
    [StringLength(50)]
    public string Username { get; set; } = string.Empty;
    [StringLength(44)]
    public string Password { get; set; } = string.Empty;
    [StringLength(24)]
    public string Salt { get; set; } = string.Empty;
}