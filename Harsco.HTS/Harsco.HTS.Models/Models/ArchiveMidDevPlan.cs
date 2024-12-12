using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace Harsco.HTS.API.Models
{
	public class ArchiveMidDevPlan
	{
		[Key]
		public int ArchiveMidYearEmpMgrDevID { get; set; }
		public string EmpDevPlan { get; set; }

		public string MgrDevPlan { get; set; }

		public string PointOfEntry { get; set; }

		public string ActivityLoop { get; set; }

		public string DevelopmentLoop { get; set; }

		public DateTime? DateDue { get; set; }

		public string Activity { get; set; }
	}
}
