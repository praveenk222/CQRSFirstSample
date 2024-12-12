using System;
using System.ComponentModel.DataAnnotations;

namespace Harsco.HTS.ViewModels
{
   public class WrongAppraisals
    {
        [Key]
      
        public int ProfileId { get; set; }
        public int AppraisalID { get; set; }
        public string NetworkID { get; set; }
        public string Employee { get; set; }
        public string Email { get; set; }
        public DateTime DateOfJoin { get; set; }
        public DateTime? TerminationDate { get; set; }
        public string Country { get; set; }
        public string Division { get; set; }
        public string AppraisalCycle { get; set; }
        public int AppraisalTypeID { get; set; }
        public string Manager { get; set; }
    }
}


