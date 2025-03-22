namespace GoSolution.Entity.Entities;

// Bảng trung gian giữa Role và Right
public class RoleRight
{
    public Guid RoleId { get; set; }
    public Role Role { get; set; } = new();

    public Guid RightId { get; set; }
    public Right Right { get; set; } = new();
}
