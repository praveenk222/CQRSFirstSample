using System;
using System.Collections.Generic;
using System.Text;

namespace Harsco.HTS.Models
{
    public class SearchModel : BaseModel
    {
        public short PageNumber { get; set; } = 0;

        public string loggedinUserName { get; set; }

        public short PageSize { get; set; } = 15;

        public string SortBy { get; set; } = "Name";

        public IDictionary<string, string> SearchBy { get; set; }
    }
}
