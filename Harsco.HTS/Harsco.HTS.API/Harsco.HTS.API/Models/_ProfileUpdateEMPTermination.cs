using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Harsco.HTS.API.Models
{
    public class _ProfileUpdateEMPTermination
    {
        [Key]
        public int ProfileID { get; set; }

        public string NetworkID { get; set; }

        public string EmployeeNumber { get; set; }

        public int? ManagerID { get; set; }

        public string EmployeeName { get; set; }

        public string Email { get; set; }

        public string BusinessUnitName { get; set; }

        public string Location { get; set; }
        public string Title { get; set; }

        public int AppraisalTypeId { get; set; }

        public int AppraisalId { get; set; }

        public string ManagerName { get; set; }

        public string JobTitle { get; set; }

        public DateTime? DateHired { get; set; }

        public DateTime? TerminationDate { get; set; }

        public string JobFamilyDesc { get; set; }

    }
}
