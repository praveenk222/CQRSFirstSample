using System;
using System.Collections.Generic;

namespace Harsco.HTS.API.ArchiveModels
{
    public partial class LicsCertsProfOrgs
    {
        public int ArchiveLicCertProfOrgId { get; set; }
        public int OriginalLicCertProfOrgId { get; set; }
        public int ArchiveProfileId { get; set; }
        public string Description { get; set; }
        public string LicenseCategory { get; set; }
        public string LicenseNumber { get; set; }
        public string CertificationNumber { get; set; }
        public string ProfessionalOrganizationName { get; set; }
        public DateTime? DateReceived { get; set; }
        public DateTime? ExpirationDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime ModifiedOn { get; set; }

        public virtual Profiles ArchiveProfile { get; set; }
    }
}
