using Harsco.HTS.API.Models.Harsco.HTS.API.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Harsco.HTS.API.Models
{
    public class vmComptency
    {
        public List<LeadershipCompetencies> LeadershipCompetencies { get; set; }
        public List<LDRCompetenciesDesc> LDRCompetencies_Desc { get; set; }
        public List<LeadershipCompetencyRatings> LeadershipCompetencyRatings { get; set; }
    }

    public class vmCompetencies
    {

        public int LC_ID { get; set; }

        public string TransLationKey { get; set; }
        public string Competency { get; set; }

        public string Description { get; set; }

        public string ModifiedBy { get; set; }

        public DateTime? ModifiedDate { get; set; }

        public bool? IsActive { get; set; }
        public List<LDRCompetenciesDesc> LDRCompetencies_Desc { get; set; }
        public List<LeadershipCompetencyRatings> LeadershipCompetencyRatings { get; set; }

    }
    public class vmemprating
    {
        public vmemprating()
        {
            EmpCompetencies = new List<tbl_EmpCompetencies>();

        }
        public List<tbl_EmpCompetencies> EmpCompetencies { get; set; }

    }


}
