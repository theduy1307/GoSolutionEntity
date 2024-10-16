namespace GoSolution.Entity.Entities;

public class ContactInformation
{
    public Guid Id { get; set; }
    public Guid EmployeeId { get; set; }
    public Employee Employee { get; set; } = new Employee();
    public string Email { get; set; } = string.Empty;
}