using System;
using System.Collections.Generic;

namespace API.Models;

public partial class InsuranceCoverage
{
    public int CoverageId { get; set; }

    public string? Name { get; set; }

    public string Status { get; set; } = null!;

    public string? Type { get; set; }

    public int SubscriberId { get; set; }

    public string? SubscriberRelationship { get; set; }

    public int BeneficiaryId { get; set; }

    public DateTime? PeriodStartDate { get; set; }

    public DateTime? PeriodEndDate { get; set; }

    public int? PayorOrganizationId { get; set; }

    public int? PolicyHolderId { get; set; }

    public int? ContractId { get; set; }

    public string? Network { get; set; }

    public string? ClassType { get; set; }

    public string? ClassValue { get; set; }

    public int? OrderIndex { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? DateCreated { get; set; }

    public int? LastModifiedBy { get; set; }

    public DateTime? LastModifiedDate { get; set; }

    public virtual ICollection<OrganizationInsurancePlan> OrganizationInsurancePlans { get; set; } = new List<OrganizationInsurancePlan>();
}
