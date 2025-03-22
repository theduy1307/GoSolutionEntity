namespace GoSolution.Entity.Entities;

public class Right : EntityBase
{
    public string Name { get; set; } = string.Empty;
    public ICollection<RoleRight> RoleRights { get; set; } = [];
}

