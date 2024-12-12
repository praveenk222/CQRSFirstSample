using System;
using System.Collections.Generic;

namespace Harsco.HTS.API.Models
{
    public partial class TestZcity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? CountryId { get; set; }

        public virtual TestZcountry Country { get; set; }
    }
}
