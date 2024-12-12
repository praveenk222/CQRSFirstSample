using System;
using System.Collections.Generic;
using System.Text;

namespace Harsco.HTS.ViewModels
{
    public class vmEmployeereportees
    {
        public int ProfileID { get; set; }
        public string EmployeeName { get; set; }
        public string NetworkID { get; set; }
        public int ManagerID { get; set; }
        public int EmpLevel { get; set; }
        public List<vmEmployeereportees> SubReportees { get; set; }

        public vmEmployeereportees()
        {
            SubReportees = new List<vmEmployeereportees>();
        }
    }

    public class vmEmployeereporteesList
    {
        public List<vmEmployeereportees> Reportees { get; set; }
    }

}
