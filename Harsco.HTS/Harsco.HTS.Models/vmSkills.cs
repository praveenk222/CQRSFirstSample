using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Harsco.HTS.ViewModels
{
   public class vmSkills
    {
        [Key]
        public int SkillId { get; set; }
        public int ProfileId { get; set; }
        public string EnterpriseCompetencies { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime ModifiedOn { get; set; }

        public int ApprovalStatusID { get; set; }

        public string ApproverID { get; set; }

        public int EmpRating { get; set; }

        public string EmpRatingDesc { get; set; }

        public int MngrRating { get; set; }

        public string MngrRatingDesc { get; set; }  

        public int Year { get; set; }

        public string EmployeeName { get; set;}
    }
}
