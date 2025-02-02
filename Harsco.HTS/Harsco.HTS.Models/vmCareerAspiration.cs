﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Harsco.HTS.ViewModels
{
    public class vmCareerAspiration: vmProfileBase
    {
        public int Id { get; set; }
        public int? ProfileId { get; set; }
        public string Aspiration { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
    }
}
