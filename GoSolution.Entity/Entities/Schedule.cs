using System.ComponentModel.DataAnnotations;
namespace GoSolution.Entity.Entities;

public class Schedule : EntityBase
{
    [StringLength(50)]
    public string Name { get; set; } = string.Empty;
    [StringLength(400)] 
    public string Description { get; set; } = string.Empty;
    public TimeSpan FromTime { get; set; }
    public TimeSpan ToTime { get; set; }
    public ICollection<EmployeeSchedule> EmployeeSchedules { get; set; } = [];
}