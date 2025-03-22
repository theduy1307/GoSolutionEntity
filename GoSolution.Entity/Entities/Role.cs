namespace GoSolution.Entity.Entities;

public class Role : EntityBase
{
    public string Name { get; set; } = string.Empty;
    // Navigation Property (Danh sách quyền mà Role này có)
    public ICollection<RoleRight> RoleRights { get; set; } = [];
    public ICollection<Employee> Employees { get; set; } = [];
    public ICollection<Menu> Menus { get; set; } = [];
}
