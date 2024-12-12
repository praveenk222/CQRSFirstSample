using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Harsco.HTS.API.Models
{
    public class __ProfilesListWithCEO_NewSP
    {
        [Key]
        public int ProfileID { get; set; }
        public string NetworkID { get; set; }
        public string EmployeeName { get; set; }
        public string Email { get; set; }
        public string ManagerName { get; set; }
        public string EmployeeNumber { get; set; }
    }
}
