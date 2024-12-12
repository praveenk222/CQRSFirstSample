using System;

namespace Harsco.HTS.ViewModels
{
    public class vmDivisions : vmProfileBase
    {
        public int DivisionId { get; set; }
        public string DivisionName { get; set; }
        public string Abbreviation { get; set; }
        public string DisplayName { get; set; }
        public int BusinessGroupId { get; set; }
        public bool IsDeleted { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime ModifiedOn { get; set; }
    }
}