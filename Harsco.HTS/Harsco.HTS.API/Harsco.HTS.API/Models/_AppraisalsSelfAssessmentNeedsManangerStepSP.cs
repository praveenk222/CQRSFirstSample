using System.ComponentModel.DataAnnotations;

namespace Harsco.HTS.API.Models
{
    public class _AppraisalsSelfAssessmentNeedsManangerStepSP
    {
        [Key]
        public int ProfileID { get; set; }
        public string EmployeeName { get; set; }
        public int AppraisalId { get; set; }
        public string NetworkId { get; set; }
    }

    public class _CompetencyNeedsManangerStepSP
    {
        [Key]
        public int ProfileID { get; set; }
        public string EmployeeName { get; set; }
        public int AppraisalId { get; set; }
        public string NetworkId { get; set; }
    }
}