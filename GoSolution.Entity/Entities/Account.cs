namespace GoSolution.Entity.Entities;

public class Account
{
    public Guid Id { get; set; }
    public Guid EmployeeId { get; set; }
    public Employee Employee { get; set; } = new Employee();
    public bool IsActive { get; set; }
    public DateTime LastLogin { get; set; }
    public string Username { get; set; } = string.Empty;
    public string Password { get; set; } = string.Empty;
}