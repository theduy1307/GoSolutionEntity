namespace GoSolution.Entity.Entities;

public class CandidateCertificate
{
    public Guid CandidateId { get; set; }
    public Candidate Candidate { get; set; } = new();
    
    public Guid CertificateId { get; set; }
    public Certificate Certificate { get; set; } = new();
}