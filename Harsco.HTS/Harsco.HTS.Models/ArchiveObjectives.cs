using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Harsco.HTS.API.Models
{
    public class ArchiveObjectives
    {
        [Key]
        public string Description { get; set; }

        public string YearEndResults { get; set; }

        public string ManagerYearEndResults { get; set; }

        public DateTime DateDue { get; set; }

        public string Achieved { get; set; }

        public string ManagerAchieved { get; set; }
    }
}
