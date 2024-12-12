using System;
using System.Collections.Generic;

namespace Harsco.HTS.API.Models
{
    public partial class TestZcountry
    {
        public TestZcountry()
        {
            TestZcity = new HashSet<TestZcity>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<TestZcity> TestZcity { get; set; }
    }
}
