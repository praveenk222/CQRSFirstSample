using System;
using System.Collections.Generic;

namespace Harsco.HTS.API.Models
{
    public partial class EnterpriseCompetencies
    {
        public EnterpriseCompetencies()
        {
            Competencies = new HashSet<Competencies>();
            MidYearEmpMgrValues = new HashSet<MidYearEmpMgrValues>();
        }

        public int EnterpriseCompetencyId { get; set; }
        public string Title { get; set; }
        public bool ManagerRequired { get; set; }
        public bool EmployeeRequired { get; set; }
        public bool IsDeleted { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime ModifiedOn { get; set; }
        public byte[] TimeStamp { get; set; }

        public virtual ICollection<Competencies> Competencies { get; set; }
        public virtual ICollection<MidYearEmpMgrValues> MidYearEmpMgrValues { get; set; }
    }
}
