using System.ComponentModel.DataAnnotations;

namespace Harsco.HTS.API.Models
{
    public class _MidYearNeedManagerSign
    {
        [Key]
        public string EmployeeName { get; set; }
        //public int? MidYearID { get; set; }
        public int ProfileID { get; set; }
        public string NetworkId { get; set; }
    }
}