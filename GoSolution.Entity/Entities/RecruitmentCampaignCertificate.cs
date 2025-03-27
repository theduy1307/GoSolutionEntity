namespace GoSolution.Entity.Entities;

public class RecruitmentCampaignCertificate
{
    public Guid RecruitmentCampaignId { get; set; }
    public RecruitmentCampaign RecruitmentCampaign { get; set; }
    public int MinimumScore { get; set; }
    public Guid CertificateId { get; set; }
    public Certificate Certificate { get; set; }
}