namespace GoSolution.Entity.Entities;

public class EntityBase
{
    public int Id { get; set; }
    public int? CreatedBy { get; set; }
    public DateTime? CreateDate { get; set; }
    public int? LastModifiedBy { get; set; }
    public DateTime? LastModifiedDate { get; set; }
}