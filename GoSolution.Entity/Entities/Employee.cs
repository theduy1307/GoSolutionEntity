using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using GoSolution.Entity.Enums;

namespace GoSolution.Entity.Entities;

public class Employee : EntityBase
{
    [StringLength(400)]
    public string FullName { get; set; } = string.Empty;
    
    [DataType(DataType.Date)]
    [Column(TypeName="Date")]
    public DateTime DateOfBirth { get; set; }
    
    public byte Gender { get; set; }
    public Account? Account { get; set; }
    public Guid? BranchId { get; set; }
    public Branch Branch { get; set; } = new Branch();
    public ICollection<EmployeeSchedule> EmployeeSchedules { get; set; } = [];
    public ICollection<Role> Roles { get; set; } = [];

}