using System;
using System.Collections.Generic;

namespace Harsco.HTS.ViewModels
{
    public class vmTemporaryDirectReport:vmProfileBase
    {
        public int? Id { get; set; }
        public List<Employee> Employee { get; set; }
        public List<Employee> Manager { get; set; }
        public DateTime Startdate { get; set; }
        public DateTime Enddate { get; set; }
    }

    public class Employee
    {
        public string EmployeeName { get; set; }
        public int ProfileID { get; set; }
    }
    public class TemporaryDirectReport
    {
        public string EmployeeName { get; set; }
        public int ProfileID { get; set; }
        public int ID { get; set; }

        public DateTime Startdate { get; set; }
        public DateTime Enddate { get; set; }
        public bool IsActive { get; set; }

        public string NetworkID { get; set; }
        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; }


        public string ManagerID { get; set; }


    }
}