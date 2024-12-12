using System.ComponentModel.DataAnnotations;

namespace Harsco.HTS.API.Models
{
    public class _AppraisalNeedsHRSignOff
    {
        [Key]
        public string EmployeeName { get; set; }
        public int AppraisalId { get; set; }
        public int ProfileID { get; set; }
        public string NetworkId { get; set; }
    }
}