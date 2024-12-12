using Microsoft.VisualBasic;
using System;
using System.ComponentModel.DataAnnotations;

namespace Harsco.HTS.ViewModels
{
    public class vmHRUserPermissions : vmProfileBase
    {
        public int HRPermissionsId { get; set; }

        public string BusinessGroupId { get; set; }
        public string CountryId { get; set; }

        public int HRUserId { get; set; }
        public string UserName { get; set; }
        public bool SecurityUser { get; set; }
        public bool SuperUser { get; set; }
        public int ProfileID { get; set; }

        public bool? HRPB { get; set; }
    }

    public class vmHRBPUserPermissions: vmProfileBase
    {
      
        public int Id { get; set; }

        public string NetworkID { get; set; }
        public string BusinessGroupId { get; set; }

        public string CountryId { get; set; }
        public string Updatedby { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public bool IsActive { get; set; }
       
    }
    public class vmGETHRReviewerDetails
    {
        [Key]
        public int Id { get; set; }

        public string NetworkID { get; set; }
        public int BusinessGroupId { get; set; }

        public string CountryId { get; set; }
        public string Updatedby { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public bool IsActive { get; set; }
        public string DisplayName { get;set; }

    }
    public class  HRReviewUsers
    {
        [Key]
        public int Id { get; set; }

        public string NetworkID { get; set; }
        public int BusinessGroupId { get; set; }

        public string CountryId { get; set; }
        public string Updatedby { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public bool IsActive { get; set; }

    }

    public class vmHRBPUsers
    {

        public string NetworkID { get; set; }
        public string EmployeeName { get; set; }

  

    }
}