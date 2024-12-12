using Harsco.HTS.ViewModels;
using System.Collections.Generic;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Harsco.HTS.API.Models
{
    public class tbl_EmpTaskstatus
    {
        internal int profileID;

        [Key]
        public int ID { get; set; }
        public int ObjectiveId { get; set; }
        public int AppraisalId { get; set; }
        public int ProfileID { get; set; }
        public string? Description { get; set; }
        public int StatusID { get; set; }
        public string? StatusComments { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }

    }
}
