using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public  class HrpermissionsNew
    {
        public int HrpermissionsId { get; set; }
        public int HruserId { get; set; }
        public int? BusinessGroupId { get; set; }
        public string CountryId { get; set; }

        public bool? HRBP { get; set; }
    }
}
