using System.Collections.Generic;

namespace Harsco.HTS.ViewModels
{
    public class vmMidYearSubmit : vmProfileBase
    {
        public List<vmMidYear> Objectives { get; set; }
        public List<vmMidYearEmpMgrValues> EmpMgrValues { get; set; }
        public List<vmMidYearEmpMgrDevPlan> EmpMgrDevlpmntPlan { get; set; }

    }
}