using System;
using System.Collections.Generic;

namespace Harsco.HTS.API.Models
{
    public partial class DuplicateAd
    {
        public int RowWid { get; set; }
        public string CorrectAdName { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string JobTitle { get; set; }
        public string JobFamily { get; set; }
        public string AssignmentCategory { get; set; }
        public string UnionFlag { get; set; }
        public string AssignmentStatus { get; set; }
        public string SalaryBasis { get; set; }
        public string ExemptFlag { get; set; }
        public string DirectIndirect { get; set; }
        public string SupervisorNm { get; set; }
        public string OrganizationNm { get; set; }
        public string LocationNm { get; set; }
        public string CountryNm { get; set; }
        public string RegionNm { get; set; }
        public string DivisionNm { get; set; }
        public string Adname { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
    }
}
