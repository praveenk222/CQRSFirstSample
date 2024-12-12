using System;
using System.ComponentModel.DataAnnotations;

namespace Harsco.HTS.ViewModels
{
  
   public class IsUserInCurrentCycle
    {
        [Key]
        public bool Results { get; set; }
    }


    public class EligibilityCheck
    {
        [Key]
        public string GetEligibilityCheck { get; set; }
    }

    public class NoteMessage
    {
        [Key]
        public string GetNoteMessage { get; set; }
    }

    public class ActualCycle
    {
        [Key]
        public string GetActualCycle { get; set; }
    }

}


