namespace GoSolution.Entity.Entities;

public class EmployeeSchedule : EntityBase
{
    public int EmployeeId { get; set; }
    public Employee Employee { get; set; } = new();
    public int ScheduleId { get; set; }
    public Schedule Schedule { get; set; } = new();
    public DateTime Date { get; set; }
    public Branch Branch { get; set; } = new();
}