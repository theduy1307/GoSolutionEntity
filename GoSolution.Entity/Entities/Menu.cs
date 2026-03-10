using System.ComponentModel.DataAnnotations;

namespace GoSolution.Entity.Entities;

public class Menu : EntityBase
{
    [Required]
    [MaxLength(100)]
    public string Name { get; set; } = string.Empty;
    public string? Icon { get; set; } = string.Empty;
    public string? Url { get; set; }
    public int? ParentId { get; set; }
    public Menu? Parent { get; set; } =  null!;
    public ICollection<Menu>? SubMenus { get; set; }
    public ICollection<MenuRole> MenuRoles { get; set; } = [];
}