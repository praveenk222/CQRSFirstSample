using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Harsco.HTS.API.Models
{
    public class _GetAllHRUsers_New
    {
        [Key]
        public int HRUserId { get; set; }
        public string UserName { get; set; }
        public bool SecurityUser { get; set; }
        public bool SuperUser { get; set; }
        
        public string EmployeeName { get; set; }
    }
}
