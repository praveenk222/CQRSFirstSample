using System;
using System.Collections.Generic;

namespace Harsco.HTS.API.ArchiveModels
{
    public partial class Profiles
    {
        public Profiles()
        {
            AwardsPatentsRecognitions = new HashSet<AwardsPatentsRecognitions>();
            CareerInterests = new HashSet<CareerInterests>();
            EducationalInstitutions = new HashSet<EducationalInstitutions>();
            LicsCertsProfOrgs = new HashSet<LicsCertsProfOrgs>();
            Skills = new HashSet<Skills>();
            TrainingDevelopment = new HashSet<TrainingDevelopment>();
            UnderstoodLanguages = new HashSet<UnderstoodLanguages>();
            WorkExperiences = new HashSet<WorkExperiences>();
        }

        public int ArchiveProfileId { get; set; }
        public int OriginalProfileId { get; set; }
        public int ArchiveAppraisalId { get; set; }
        public string NetworkId { get; set; }
        public string ManagerName { get; set; }
        public string EmployeeNumber { get; set; }
        public string EmployeeName { get; set; }
        public string Email { get; set; }
        public string DivisionName { get; set; }
        public string CountryName { get; set; }
        public string LocationName { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string JobTitle { get; set; }
        public string JobFamilyName { get; set; }
        public DateTime? DateHired { get; set; }
        public DateTime? TerminationDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime ModifiedOn { get; set; }

        public virtual Appraisals ArchiveAppraisal { get; set; }
        public virtual ICollection<AwardsPatentsRecognitions> AwardsPatentsRecognitions { get; set; }
        public virtual ICollection<CareerInterests> CareerInterests { get; set; }
        public virtual ICollection<EducationalInstitutions> EducationalInstitutions { get; set; }
        public virtual ICollection<LicsCertsProfOrgs> LicsCertsProfOrgs { get; set; }
        public virtual ICollection<Skills> Skills { get; set; }
        public virtual ICollection<TrainingDevelopment> TrainingDevelopment { get; set; }
        public virtual ICollection<UnderstoodLanguages> UnderstoodLanguages { get; set; }
        public virtual ICollection<WorkExperiences> WorkExperiences { get; set; }
    }
}
