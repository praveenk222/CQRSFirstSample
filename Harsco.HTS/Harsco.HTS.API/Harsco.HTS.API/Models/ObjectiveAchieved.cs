﻿using System;
using System.Collections.Generic;

namespace Harsco.HTS.API.Models
{
    public partial class ObjectiveAchieved
    {
        public ObjectiveAchieved()
        {
            Objectives = new HashSet<Objectives>();
        }

        public int Id { get; set; }
        public string AchievedDesc { get; set; }
        public bool IsDeleted { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime ModifiedOn { get; set; }

        public virtual ICollection<Objectives> Objectives { get; set; }
    }
}
