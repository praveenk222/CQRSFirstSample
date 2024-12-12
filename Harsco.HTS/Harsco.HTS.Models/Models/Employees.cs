using System;
using System.Collections.Generic;

namespace Harsco.HTS.API.Models
{
    public partial class Employees
    {
        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int? ManagerId { get; set; }
    }
}
