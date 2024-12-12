using System;

namespace Harsco.HTS.ViewModels
{
    public class vmLicsCertsProfOrgs : vmProfileBase
    {
        public int LicCertProfOrgId { get; set; }
        public int ProfileId { get; set; }
        public string Description { get; set; }
        public int LicenseCategoryId { get; set; }
        public string LicenseCategoryOther { get; set; }
        public string LicenseNumber { get; set; }
        public string CertificationNumber { get; set; }
        public string ProfessionalOrganizationName { get; set; }
        public DateTime? DateReceived { get; set; }
        public DateTime? ExpirationDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime ModifiedOn { get; set; }
        public string LicenseCategoryName { get; set; }
    }
}