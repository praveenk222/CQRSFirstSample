using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace Harsco.HTS.API.Models
{
    public class ArchiveMidValues
    {
        [Key]
        public int ArchiveMidYearEmpValuesID { get; set; }
        public string EnterpriseCompetency { get; set; }

        public string EmpValueBehavior { get; set; }

        public string MgrValueBehavior { get; set; }

    }
}
