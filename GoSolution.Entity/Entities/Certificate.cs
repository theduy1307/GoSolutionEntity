using System.ComponentModel.DataAnnotations;

namespace GoSolution.Entity.Entities;

public class Certificate: EntityBase
{
    [StringLength(100)]
    public string Name { get; set; }
    public ICollection<CandidateCertificate> CandidateCertificates { get; set; } = [];
    public ICollection<RecruitmentCampaignCertificate> RecruitmentCampaignCertificates { get; set; } = [];
}