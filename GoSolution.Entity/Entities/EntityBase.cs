namespace GoSolution.Entity.Entities;

public class EntityBase
{
    public int Id { get; set; }
    public string? CreatedBy { get; set; }
    public DateTime? CreateDate { get; set; }
    public string? LastModifiedBy { get; set; }
    public DateTime? LastModifiedDate { get; set; }
}