using System;
using System.ComponentModel.DataAnnotations;

namespace Harsco.HTS.ViewModels
{
   public class EmployeeAppraisalCycle
    {
        [Key]
        public string? Employee{ get; set; }
        public string? Email { get; set; }
        public string? EmployeeNumber { get; set; }
        public DateTime? DateOfJoin { get; set; }
        public string? AppraisalCycle { get; set; }
        public int?  AppraisalID { get; set; }
        public int? AppraisalTypeID { get; set; }
    }
}


