using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using GoSolution.Entity.Enums;

namespace GoSolution.Entity.Entities;

public class Employee : EntityBase
{
    [StringLength(200)]
    public string FirstName { get; set; } = string.Empty;
    
    [StringLength(200)]
    public string LastName { get; set; } = string.Empty;
    
    [DataType(DataType.Date)]
    [Column(TypeName="Date")]
    public DateOnly DateOfBirth { get; set; }
    
    public byte Gender { get; set; }
    public Account? Account { get; set; }
    public int? BranchId { get; set; }
    public Branch? Branch { get; set; }
    public ICollection<EmployeeSchedule> EmployeeSchedules { get; set; } = [];
    public ICollection<EmployeeRole> EmployeeRoles { get; set; } = [];

}