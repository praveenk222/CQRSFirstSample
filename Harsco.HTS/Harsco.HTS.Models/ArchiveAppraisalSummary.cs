using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Harsco.HTS.API.Models
{
    public class ArchiveAppraisalSummary
    {
        [Key]
        public int ArchiveAppraisalID { get; set; }

        public string PerformanceRating { get; set; }

        public string CompetencySkillRatings { get; set; }

        public string OverallRating { get; set; }

        public string NextYearObjectives { get; set; }

        public string EmployeeComment { get; set; }

        public string ManagerComment { get; set; }

        public string COCViolation { get; set; }

        public DateTime? ReviewDate { get; set; }

        public string EmployeeName { get; set; }

        public DateTime EmployeeSignDate { get; set; }
        
        public string ManagerName { get; set; }

        public DateTime? ManagerSignDate { get; set; }

        public string ManagersManagerName { get; set; }

        public DateTime? ManagersManagerSignDate { get; set; }

        public string ManagerMeeting { get; set; }
    }
}
