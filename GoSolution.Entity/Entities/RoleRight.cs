namespace GoSolution.Entity.Entities;

// Bảng trung gian giữa Role và Right
public class RoleRight
{
    public int RoleId { get; set; }
    public Role Role { get; set; } = new();

    public int RightId { get; set; }
    public Right Right { get; set; } = new();
}
