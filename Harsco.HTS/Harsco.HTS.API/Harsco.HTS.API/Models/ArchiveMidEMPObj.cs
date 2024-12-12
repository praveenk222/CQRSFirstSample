using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace Harsco.HTS.API.Models
{
	public class ArchiveMidEMPObj
	{
		[Key]

		public int ArchivedProfileID { get; set; }
		public DateTime? ReviewDate { get; set; }

		public string EmployeeName { get; set; }

		public DateTime? EmpSignDate { get; set; }

		public DateTime? MgrSignDate { get; set; }

		public string ManagerName { get; set; }

	}
}
