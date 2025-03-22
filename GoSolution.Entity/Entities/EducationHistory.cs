using System.ComponentModel.DataAnnotations;

namespace GoSolution.Entity.Entities;

public class EducationHistory : EntityBase
{
    [StringLength(100)]
    public string SchoolName { get; set; } = string.Empty;
    [StringLength(50)]
    public string Major { get; set; } = string.Empty;
    [StringLength(50)]
    public string Graduation { get; set; } = string.Empty;
    [StringLength(50)]
    public string Period { get; set; } = string.Empty;

    public Candidate Candidate { get; set; } = new();
}