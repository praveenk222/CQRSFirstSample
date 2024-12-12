using System;
using System.Collections.Generic;
using System.Text;

namespace Harsco.HTS.Models
{
    public class PostResult
    {
        public PostResult(string id, string status,  string msg)
        {
            ID = id;
            Status = status;
            Message = msg;
        }
        public string ID { get; set; }
        public string Status { get; set; }
        public string Message { get; set; }
    }
}
