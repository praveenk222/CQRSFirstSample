using System;
using System.Collections.Generic;

namespace Harsco.HTS.API.Models
{
    public partial class ZTblTest
    {
        public int ProfileId { get; set; }
        public string NetworkId { get; set; }
        public string CountryName { get; set; }
        public string DivisionName { get; set; }
        public int? ObjectiveId { get; set; }
        public int? ObjectiveApprovalId { get; set; }
        public string Objective { get; set; }
        public string ApproverId { get; set; }
        public string ManagerId { get; set; }
        public string Manager { get; set; }
        public DateTime? CreatedOn { get; set; }
    }
}
