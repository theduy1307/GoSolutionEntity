namespace GoSolution.Entity.Entities;

public class Role : EntityBase
{
    public string Name { get; set; } = string.Empty;
    
    public ICollection<RoleRight> RoleRights { get; set; } = [];
    public ICollection<EmployeeRole> EmployeeRoles { get; set; } = [];
    public ICollection<MenuRole> MenuRoles { get; set; } = [];
}
