namespace Harsco.HTS.API.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;

    namespace Harsco.HTS.API.Models
    {

        public class LeadershipCompetencies
        {
            [Key]
            public int LC_ID { get; set; }

            public string TransLationKey { get; set; }
            public string Competency { get; set; }

            public string Description { get; set; }

            public string ModifiedBy { get; set; }

            public DateTime? ModifiedDate { get; set; }

            public bool? IsActive { get; set; }

        }
        public class LDRCompetenciesDesc

        {
            [Key]
            public int LCD_ID { get; set; }
            public int LC_ID { get; set; }

            public string TransLationKey { get; set; }

            public string Description { get; set; }

            public string ModifiedBy { get; set; }

            public DateTime? ModifiedDate { get; set; }

            public bool? IsActive { get; set; }


        }
        public class LeadershipCompetencyRatings

        {
            [Key]

            public int LCR_ID { get; set; }
            public int LC_ID { get; set; }
            public string TransLationKey { get; set; }
            public int CompetencyRating { get; set; }

            public string Description { get; set; }

            public string ModifiedBy { get; set; }

            public DateTime? ModifiedDate { get; set; }

            public bool? IsActive { get; set; }

        }
        public class tbl_EmpCompetencies
        {
            [Key]
            public int ID { get; set; }

            public int LC_ID { get; set; }

            public int AppraisalID { get; set; }

            public int AppraisalTypeID { get; set; }
            public string? EmpNumber { get; set; }

            public int EmpRating { get; set; }

            public string? EmpComment { get; set; }

            public int? MgrRating { get; set; }
            public string? MgrComment { get; set; }

            public int ApprovalStatusID { get; set; }

            public string ApproverID { get; set; }

            public string ModifiedBy { get; set; }

            public DateTime? ModifiedDate { get; set; }

            public bool? IsActive { get; set; }
        }

    }

}
