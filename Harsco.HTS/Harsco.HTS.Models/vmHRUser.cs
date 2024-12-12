namespace Harsco.HTS.ViewModels
{
    public class vmHRUser : vmProfileBase
    {
        public int HRUserId { get; set; }
        public string UserName { get; set; }
        public bool SecurityUser { get; set; }
        public bool SuperUser { get; set; }
        public string EmployeeName { get; set; }
    }
}