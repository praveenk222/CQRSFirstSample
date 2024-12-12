using System;
using System.ComponentModel.DataAnnotations;

namespace Harsco.HTS.API.Models
{
    public class _TemporaryDirectReportsListAllGridSP_New
    {
        [Key]
        public int Id { get; set; }
        public string EmployeeId { get; set; }
        public string ManagerId { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string EmployeeName { get; set; }
        public string ManagerName { get; set; }
        public int EmpProfileID { get; set; }
        public int MgrProfileID { get; set; }
    }
}