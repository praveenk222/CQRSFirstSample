using System;
using System.Collections.Generic;

namespace Harsco.HTS.API.Models
{
    public partial class ProfilesRemoved
    {
        public int ProfileId { get; set; }
        public string EmployeeName { get; set; }
        public string Email { get; set; }
        public string NetWorkId { get; set; }
    }
}
