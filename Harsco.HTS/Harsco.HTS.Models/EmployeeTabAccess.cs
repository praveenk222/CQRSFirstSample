using System;
using System.ComponentModel.DataAnnotations;

namespace Harsco.HTS.ViewModels
{
   public class EmployeeTabAccess
    {
        [Key]
        public string NetworkID { get; set; }
        public string EmployeeNumber { get; set; }
        public string EmployeeName { get; set; }
        public bool IsDeveloper { get; set; }
        public bool IsSupport { get; set; }
    }
}


