namespace GoSolution.Entity.Entities;

public class Right
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public ICollection<RoleRight> RoleRights { get; set; } = [];
}

