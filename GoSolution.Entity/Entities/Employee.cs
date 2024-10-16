using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using GoSolution.Entity.Enums;

namespace GoSolution.Entity.Entities;

public class Employee
{
    public Guid Id { get; set; }
    public string FirstName { get; set; } = string.Empty;
    public string MiddleName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public string NickName { get; set; } = string.Empty;
    [DataType(DataType.Date)]
    [Column(TypeName="Date")]
    public DateTime DateOfBirth { get; set; }
    public string PlaceOfBirth { get; set; } = string.Empty;
    public byte Gender { get; set; }
    
    public Guid AncestralHomeId { get; set; }
    public AdministrativeUnit AncestralHome { get; set; } = new AdministrativeUnit();
    
    public Guid EthnicityId { get; set; }
    public Ethnicity Ethnicity { get; set; } = new Ethnicity();
    
    public Guid ReligionId { get; set; }
    public Religion Religion { get; set; } = new Religion();
    
    public Guid NationalityId { get; set; }
    public Country Nationality { get; set; } = new Country();
    
    public string NationalId { get; set; } = string.Empty;
    [DataType(DataType.Date)]
    [Column(TypeName="Date")]
    public DateTime DateOfIssueOfNationalIdentification { get; set; }
    
    public Guid PlaceOfIssueOfNationalIdentificationId { get; set; } 
    public PlaceOfIssueOfNationalIdentification PlaceOfIssueOfNationalIdentification { get; set; } = new PlaceOfIssueOfNationalIdentification();
    
    public string PassportNumber { get; set; } = string.Empty;
    public string TaxId { get; set; } = string.Empty;
    [DataType(DataType.Date)]
    [Column(TypeName="Date")]
    public DateTime DateOfIssueOfPassport { get; set; }
    
    public Guid PlaceOfIssueOfPassportId { get; set; }
    public PlaceOfIssueOfPassport PlaceOfIssueOfPassport { get; set; } = new PlaceOfIssueOfPassport();
    
    public Guid EducationLevelId { get; set; }
    public EducationLevel EducationLevel { get; set; } = new EducationLevel();
    
    public Guid SpecializationId { get; set; }
    public Specialization Specialization { get; set; } = new Specialization();
    
    public Guid PoliticalQualificationId { get; set; }
    public PoliticalQualification PoliticalQualification { get; set; } = new PoliticalQualification();
    
    public MaritalStatus MaritalStatus { get; set; }
    [DataType(DataType.Date)]
    [Column(TypeName="Date")]
    public DateTime DateOfJoiningTheTradeUnion { get; set; }
    
    public Account? Account { get; set; }
    public ContactInformation? ContactInformation { get; set; }
}