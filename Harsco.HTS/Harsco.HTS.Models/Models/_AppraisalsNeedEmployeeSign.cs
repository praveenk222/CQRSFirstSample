using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Harsco.HTS.API.Models
{
    public class _AppraisalsNeedEmployeeSign
    {
        [Key]
        public string EmployeeName { get; set; }
        public int AppraisalId { get; set; }
        public int ProfileID { get; set; }
    }
}
