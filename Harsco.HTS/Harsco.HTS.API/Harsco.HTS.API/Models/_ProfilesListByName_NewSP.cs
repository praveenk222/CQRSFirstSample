using System;
using System.ComponentModel.DataAnnotations;

namespace Harsco.HTS.API.Models
{
    public class _ProfilesListByName_NewSP
    {
        [Key]
        public int ProfileID { get; set; }

        public int AppraisalID { get; set; }
        public string NetworkID { get; set; }
        public int? ManagerID { get; set; }
        public string EmployeeNumber { get; set; }
        public string EmployeeName { get; set; }
        public string Email { get; set; }
        public int? DivisionID { get; set; }
        public int? CountryID { get; set; }
        public string Location { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string JobTitle { get; set; }
        public int JobFamilyID { get; set; }
        public DateTime? DateHired { get; set; }
        public DateTime? TerminationDate { get; set; }
        public string JobFamilyDesc { get; set; }
        public string ManagerName { get; set; }
        public string AppraisalTitle { get; set; }
        public string BusinessUnitName { get; set; }
    }
}