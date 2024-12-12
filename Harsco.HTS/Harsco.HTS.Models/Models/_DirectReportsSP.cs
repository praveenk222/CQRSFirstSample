using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Harsco.HTS.API.Models
{
    public class _DirectReportsSP
    {
        [Key]
        public int ProfileID { get; set; }
        public int? AppraisalID { get; set; }
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
        public int? JobFamilyID { get; set; }
        public DateTime? DateHired { get; set; }
        public DateTime? TerminationDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }

             
    }

    public class EmployeeReporteesSP
    {
        [Key]
        public int ProfileID { get; set; }                     
        public string EmployeeName { get; set; }
        public string NetworkID { get; set; }
        public int ManagerID { get; set; }       
        public int EmpLevel { get; set; }
    }
}
