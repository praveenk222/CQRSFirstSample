using System;
using System.Collections.Generic;

namespace Harsco.HTS.API.Models
{
    public partial class TemporaryDirectReports
    {
        public int Id { get; set; }
        public string NetworkId { get; set; }
        public string ManagerId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string OriginalManagerId { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime ModifiedOn { get; set; }
    }
}
