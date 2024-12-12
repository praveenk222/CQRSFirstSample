using System;
using System.Collections.Generic;

namespace Harsco.HTS.API.Models
{
    public partial class Headcount
    {
        public int RowWid { get; set; }
        public string EmployeeUniqueId { get; set; }
        public string EmployeeId { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public DateTime? RehireDate { get; set; }
        public string JobTitle { get; set; }
        public string JobFamily { get; set; }
        public string AssignmentCategory { get; set; }
        public string UnionFlag { get; set; }
        public string AssignmentStatus { get; set; }
        public string SalaryBasis { get; set; }
        public string ExemptFlag { get; set; }
        public string DirectIndirect { get; set; }
        public string SupervisorId { get; set; }
        public string SupervisorUniqueId { get; set; }
        public string SupervisorNm { get; set; }
        public string LocationCd { get; set; }
        public string LocationNm { get; set; }
        public string CountryCd { get; set; }
        public string CountryNm { get; set; }
        public string RegionCd { get; set; }
        public string RegionNm { get; set; }
        public string OrganizationCd { get; set; }
        public string OrganizationNm { get; set; }
        public string DivisionCd { get; set; }
        public string DivisionNm { get; set; }
        public string Source { get; set; }
        public int? DatasourceNumId { get; set; }
        public string GeneralReportingCategory { get; set; }
        public string Email { get; set; }
        public string Language { get; set; }
        public string AdUsername { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? ModifiedOn { get; set; }
    }
}
