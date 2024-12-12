using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Harsco.HTS.Models
{
    public partial class BaseModel
    {
        public int UserId { get; set; } = 0;

        public short UserRoleAccessLevel { get; set; } = 0;

        public string UserRoleAccessLevelEntity { get; set; } = "0";

        [StringLength(20)]
        public string CreatedBy { get; set; }

        public DateTime? CreatedDate { get; set; }

        [StringLength(20)]
        public string ModifiedBy { get; set; }

        public DateTime? ModifiedDate { get; set; }
    }
}
