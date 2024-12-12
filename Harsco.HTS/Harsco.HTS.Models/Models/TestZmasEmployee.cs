using System;
using System.Collections.Generic;

namespace Harsco.HTS.API.Models
{
    public partial class TestZmasEmployee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public int? DeptId { get; set; }
        public int? MangerId { get; set; }
        public bool? Status { get; set; }
    }
}
