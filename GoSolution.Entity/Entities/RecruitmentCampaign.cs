using System.ComponentModel.DataAnnotations;

namespace GoSolution.Entity.Entities;

public class RecruitmentCampaign : EntityBase
{
    [StringLength(200)]
    public string Name { get; set; } = string.Empty;
    public ICollection<RecruitmentCampaignCertificate> RecruitmentCampaignCertificates { get; set; } = [];
    public ICollection<Candidate> Candidates { get; set; } = [];
}