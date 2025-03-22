using System.ComponentModel.DataAnnotations;

namespace GoSolution.Entity.Entities;

public class JobHistory : EntityBase
{
    [StringLength(50)] public string Period { get; set; } = string.Empty;
    [StringLength(50)] public string Position { get; set; } = string.Empty;
    [StringLength(50)] public string Company { get; set; } = string.Empty;
    [StringLength(4000)] public string Description { get; set; } = string.Empty;
    public Candidate Candidate { get; set; } = new();
}