using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Harsco.HTS.API.Models
{
    public class ReportHeaderInfo
    {
        [Key]
        public string Employeename { get; set; }

        public string JobTitle { get; set; }

        public string Email { get; set; }

        public string ManagerName { get; set; }

        public string JobFamilyName { get; set; }

        public DateTime DateHired { get; set; }

        public string DivisionName { get; set; }

        public string LocationName { get; set; }

        public string AppraisalType { get; set; }

        public string Title { get; set; }

    }
}
