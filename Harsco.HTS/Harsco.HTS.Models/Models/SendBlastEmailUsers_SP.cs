using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Harsco.HTS.API.Models
{
    public class SendBlastEmailUsers_SP
    {
        [Key]
        public int ProfileID { get; set; }
        public string EmployeeName { get; set; }
        public string EmailAddress { get; set; }
        public int CountryID { get; set; }        
    }
}
