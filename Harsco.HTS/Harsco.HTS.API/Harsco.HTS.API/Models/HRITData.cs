using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Harsco.HTS.API.Models
{
    public class HRITData
    {
        [Key]
        public string EmployeeId { get; set; }

        public string Name { get; set; }

        public string JobFamily { get; set; }

        public string Country { get; set; }

        public string Division { get; set; }

        public string Location { get; set; }

        public string Email { get; set; }

        public string JobType { get; set; }

        public string Supervisor { get; set; }

        public string AD_USERNAME { get; set; }

        public DateTime? START_DATE { get; set; }

        public string ASSIGNMENT_CATEGORY { get;set;}

        public string SALARY_BASIS { get;set;}

        public string ASSIGNMENT_STATUS { get;set;}

        public DateTime? TERMINATIONDATE { get;set;}


    }
}
