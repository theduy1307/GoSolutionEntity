using System.ComponentModel.DataAnnotations;

namespace GoSolution.Entity.Entities;

public class Candidate : EntityBase
{
    [StringLength(100)]
    public string FullName { get; set; } = string.Empty;
    public DateTime DateOfBirth { get; set; }
    public byte Gender { get; set; }
    [StringLength(50)]
    public string Email { get; set; } = string.Empty;
    [StringLength(20)]
    public string Phone { get; set; } = string.Empty;
    [StringLength(200)]
    public string Location { get; set; } = string.Empty;
    [StringLength(1000)]
    public string Skills { get; set; } = string.Empty;
    [StringLength(1000)]
    public string CareerObjective { get; set; } = string.Empty;
    [StringLength(1000)]
    public string Interest { get; set; } = string.Empty;
    [StringLength(1000)]
    public string Award { get; set; } = string.Empty;
    [StringLength(4000)]
    public string Project { get; set; } = string.Empty;
    [StringLength(1000)]
    public string SocialActivities { get; set; } = string.Empty;
    
    public Guid RecruimentCampaignId { get; set; }
    public RecruitmentCampaign RecruitmentCampaign { get; set; } = new();
    
    public ICollection<JobHistory> JobHistories { get; set; } = [];
    public ICollection<EducationHistory> CandidateEducations { get; set; } = [];
    public ICollection<CandidateCertificate> CandidateCertificates { get; set; } = [];
}