using System;
using System.Collections.Generic;

namespace Harsco.HTS.API.Models
{
    public partial class Profiles
    {
        public Profiles()
        {
            AwardsPatentsRecognitions = new HashSet<AwardsPatentsRecognitions>();
            CareerAspiration = new HashSet<CareerAspiration>();
            CareerInterests = new HashSet<CareerInterests>();
            EducationalInstitutions = new HashSet<EducationalInstitutions>();
            InverseManager = new HashSet<Profiles>();
            LicsCertsProfOrgs = new HashSet<LicsCertsProfOrgs>();
            MidYear = new HashSet<MidYear>();
            MidYearEmpMgrValues = new HashSet<MidYearEmpMgrValues>();
            TrainingDevelopment = new HashSet<TrainingDevelopment>();
            UnderstoodLanguages = new HashSet<UnderstoodLanguages>();
            WorkExperiences = new HashSet<WorkExperiences>();
        }

        public int ProfileId { get; set; }
        public int AppraisalId { get; set; }
        public string NetworkId { get; set; }
        public int? ManagerId { get; set; }
        public string EmployeeNumber { get; set; }
        public string EmployeeName { get; set; }
        public string Email { get; set; }
        public int DivisionId { get; set; }
        public int CountryId { get; set; }
        public string Location { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string JobTitle { get; set; }
        public int JobFamilyId { get; set; }
        public DateTime? DateHired { get; set; }
        public DateTime? TerminationDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime ModifiedOn { get; set; }

        public virtual Profiles Manager { get; set; }
        public virtual ICollection<AwardsPatentsRecognitions> AwardsPatentsRecognitions { get; set; }
        public virtual ICollection<CareerAspiration> CareerAspiration { get; set; }
        public virtual ICollection<CareerInterests> CareerInterests { get; set; }
        public virtual ICollection<EducationalInstitutions> EducationalInstitutions { get; set; }
        public virtual ICollection<Profiles> InverseManager { get; set; }
        public virtual ICollection<LicsCertsProfOrgs> LicsCertsProfOrgs { get; set; }
        public virtual ICollection<MidYear> MidYear { get; set; }
        public virtual ICollection<MidYearEmpMgrValues> MidYearEmpMgrValues { get; set; }
        public virtual ICollection<TrainingDevelopment> TrainingDevelopment { get; set; }
        public virtual ICollection<UnderstoodLanguages> UnderstoodLanguages { get; set; }
        public virtual ICollection<WorkExperiences> WorkExperiences { get; set; }
    }
}
