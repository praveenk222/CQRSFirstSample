namespace Harsco.HTS.API.Models
{
    public class PostResult
    {
        public PostResult()
        {
            ID = "0";
            Status = "false";
            Message = "Failed";
        }
        public string ID { get; set; }
        public string Status { get; set; }
        public string Message { get; set; }
    }
}
