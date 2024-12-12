using System;


namespace Harsco.HTS.ViewModels
{
   public class vmWorkExp
    {
        public int WorkExperienceId { get; set; }
        public int ProfileId { get; set; }
        public string EmployerName { get; set; }
        public string JobTitle { get; set; }
        public string Address { get; set; }
        public DateTime DateEmploymentStarted { get; set; }
        public DateTime? DateEmploymentEnded { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime ModifiedOn { get; set; }
    }
}
