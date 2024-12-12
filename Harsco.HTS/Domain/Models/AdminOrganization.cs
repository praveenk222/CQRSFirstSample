using System;
using System.Collections.Generic;

namespace Persistence.Models;

public partial class AdminOrganization
{
    public int OrganizationId { get; set; }

    public string Name { get; set; } = null!;

    public string? Type { get; set; }

    public string? Address { get; set; }

    public string? City { get; set; }

    public string? State { get; set; }

    public string? PostalCode { get; set; }

    public string? Country { get; set; }

    public string? PhoneNumber { get; set; }

    public string? Email { get; set; }

    public bool Active { get; set; }

    public DateTime DateCreated { get; set; }

    public int? CreatedBy { get; set; }

    public int? LastModifiedBy { get; set; }

    public DateTime? LastModifiedDate { get; set; }

    public double? Latitude { get; set; }

    public double? Longitude { get; set; }

    public string? ImageUrl { get; set; }

    public string? WebsiteUrl { get; set; }

    public virtual ICollection<AdminDoctorProfile> AdminDoctorProfiles { get; set; } = new List<AdminDoctorProfile>();

    public virtual ICollection<AdminOrganizationHoliday> AdminOrganizationHolidays { get; set; } = new List<AdminOrganizationHoliday>();

    public virtual AdminUser? CreatedByNavigation { get; set; }

    public virtual AdminUser? LastModifiedByNavigation { get; set; }

    public virtual ICollection<Mrn> Mrns { get; set; } = new List<Mrn>();

    public virtual ICollection<OrganizationInsurancePlan> OrganizationInsurancePlans { get; set; } = new List<OrganizationInsurancePlan>();

    public virtual ICollection<WhatsHappening> WhatsHappenings { get; set; } = new List<WhatsHappening>();
}
