using System.ComponentModel.DataAnnotations;

namespace Harsco.HTS.API.Models
{
    public class _GetHRUserWithPermissions_New
    {
        [Key]
        public int HRPermissionsId { get; set; }
        public int HRUserId { get; set; }
        public string UserName { get; set; }
        public bool SecurityUser { get; set; }
        public bool SuperUser { get; set; }
        public int BusinessGroupId { get; set; }
        public string DisplayName { get; set; }
        public string CountryId { get; set; }
        public string EmployeeName { get; set; }

        public bool HRBP { get; set; }  
    }
}