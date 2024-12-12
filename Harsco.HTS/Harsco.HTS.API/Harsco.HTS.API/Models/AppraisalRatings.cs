using Harsco.HTS.ViewModels;
using Microsoft.CodeAnalysis;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Harsco.HTS.API.Models
{
    public partial class AppraisalRatings
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public bool IsDeleted { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime ModifiedOn { get; set; }
    }
    public class AssessmentCyclesOnOff
    {
        public int ID { get; set; }
        public int AppraisalTypeID { get; set; }
        public bool IsDisabled { get; set; }
        public string Description { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime ModifiedOn { get; set; }
        public bool? IsActive { get; set; }

    }

    //added to save return to employee reason deatils
    public class SP_AssessmentCyclesOnOff
    {
        public int ID { get; set; }

        public int AppraisalTypeID { get; set; }

        public bool IsDisabled { get; set; }

        public string Description { get; set; }

        public string ModifiedBy { get; set; }

        public DateTime ModifiedOn { get; set; }

        public bool? IsActive { get; set; }


        public string? AppraisalTitle { get; set; }

    }
    public class ReturnToEmployeeDetails
    {
  
        public int ID { get; set; }
        public string ManagerID { get; set; }
        public string EmployeeID { get; set; }

        public string ActionerID { get; set; }  
        public int AppraisalTypeID { get; set; }
        public string Description { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime ModifiedOn { get; set; }
        public bool? IsActive { get; set; }
        public string ActionType { get; set; } 
    }
    public class SP_ReturnToEmployeeDetails
    {
        public int ID { get; set; }
        public string EmployeeName { get; set; }
        public string Title { get; set; }
        public string Code { get; set; }
        public string ManagerName { get; set; }
        public string Description { get; set; }

        public string ActionType { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime ModifiedOn { get; set; }
        public bool? IsActive { get; set; }
    }

}
