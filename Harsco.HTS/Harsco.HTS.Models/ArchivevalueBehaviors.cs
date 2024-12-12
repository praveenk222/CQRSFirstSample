using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace Harsco.HTS.API.Models
{
    public class ArchivevalueBehaviors
    {
        [Key]

        public string EnterpriseCompetency { get; set; }

        public string Comment { get; set; }

        public string ManagerComment { get; set; }

        public string EmployeeSkillRating { get; set; }

        public string ManagerSkillRating { get; set; }
    }
}
