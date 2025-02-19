namespace GoSolution.Entity.Entities;

public class Role
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;

    // Navigation Property (Danh sách quyền mà Role này có)
    public ICollection<RoleRight> RoleRights { get; set; } = [];
}
