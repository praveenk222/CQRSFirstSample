using System;

namespace Harsco.HTS.ViewModels
{
    public class vmProfile
    {
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
        public string ManagerName { get; set; }
        public string CountryName { get; set; }
        public string JobFamilyName { get; set; }
        public string DivisionName { get; set; }
        public bool IsManager { get; set; }
        public bool IsAdmin { get; set; }
        public bool IsHR { get; set; }
        public bool IsSecurityUser { get; set; }
        public bool? IsDirect { get; set; }
    }
}