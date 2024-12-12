using System;
using System.Collections.Generic;

namespace API.Models;

public partial class OrganizationInsurancePlan
{
    public int OrganizationInsurancePlanId { get; set; }

    public int? OrganizationId { get; set; }

    public int? InsurancePlanId { get; set; }

    public string? CoverageArea { get; set; }

    public string? Network { get; set; }

    public DateOnly? PeriodStart { get; set; }

    public DateOnly? PeriodEnd { get; set; }

    public string? Status { get; set; }

    public virtual InsuranceCoverage? InsurancePlan { get; set; }

    public virtual AdminOrganization? Organization { get; set; }
}
