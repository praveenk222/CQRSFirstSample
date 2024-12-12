using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Harsco.HTS.API.Models
{
    public class _ArchiveMidYearObjective
    {
        [Key]
        public int ObjectiveID { get; set; }

        public string EmpObjective { get; set; }

        public string MgrObjective { get; set; }

        public string Description { get; set; }
    }
}
