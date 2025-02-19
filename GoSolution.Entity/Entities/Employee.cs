using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using GoSolution.Entity.Enums;

namespace GoSolution.Entity.Entities;

public class Employee : EntityBase
{
    [StringLength(100)]
    public string FirstName { get; set; } = string.Empty;
    
    [StringLength(100)]
    public string MiddleName { get; set; } = string.Empty;
    
    [StringLength(100)]
    public string LastName { get; set; } = string.Empty;
    
    [DataType(DataType.Date)]
    [Column(TypeName="Date")]
    public DateTime DateOfBirth { get; set; }
    
    public byte Gender { get; set; }
    
    public Account? Account { get; set; }

    public ICollection<EmployeeSchedule> EmployeeSchedules { get; set; } = [];
}