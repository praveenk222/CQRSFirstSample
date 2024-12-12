using System;
using System.Collections.Generic;

namespace Persistence.Models;

public partial class AdminUser
{
    public int AdminId { get; set; }

    public string Username { get; set; } = null!;

    public string Password { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string? PhoneNumber { get; set; }

    public string Role { get; set; } = null!;

    public bool Active { get; set; }

    public DateTime DateCreated { get; set; }

    public DateTime? LastLogin { get; set; }

    public int? OrganizationId { get; set; }

    public int? CreatedBy { get; set; }

    public int? LastModifiedBy { get; set; }

    public DateTime? LastModifiedDate { get; set; }

    public bool? Status { get; set; }

    public int? RetryAttempt { get; set; }

    public DateTime? LastLoginFailedTime { get; set; }

    public virtual ICollection<AdminDoctorLocation> AdminDoctorLocationCreatedByNavigations { get; set; } = new List<AdminDoctorLocation>();

    public virtual ICollection<AdminDoctorLocation> AdminDoctorLocationLastModifiedByNavigations { get; set; } = new List<AdminDoctorLocation>();

    public virtual ICollection<AdminDoctorProfile> AdminDoctorProfileCreatedByNavigations { get; set; } = new List<AdminDoctorProfile>();

    public virtual ICollection<AdminDoctorProfile> AdminDoctorProfileLastModifiedByNavigations { get; set; } = new List<AdminDoctorProfile>();

    public virtual ICollection<AdminDoctorSpeciality> AdminDoctorSpecialityCreatedByNavigations { get; set; } = new List<AdminDoctorSpeciality>();

    public virtual ICollection<AdminDoctorSpeciality> AdminDoctorSpecialityLastModifiedByNavigations { get; set; } = new List<AdminDoctorSpeciality>();

    public virtual ICollection<AdminLocation> AdminLocationCreatedByNavigations { get; set; } = new List<AdminLocation>();

    public virtual ICollection<AdminLocation> AdminLocationLastModifiedByNavigations { get; set; } = new List<AdminLocation>();

    public virtual ICollection<AdminOrganization> AdminOrganizationCreatedByNavigations { get; set; } = new List<AdminOrganization>();

    public virtual ICollection<AdminOrganization> AdminOrganizationLastModifiedByNavigations { get; set; } = new List<AdminOrganization>();

    public virtual ICollection<AdminSpeciality> AdminSpecialityCreatedByNavigations { get; set; } = new List<AdminSpeciality>();

    public virtual ICollection<AdminSpeciality> AdminSpecialityLastModifiedByNavigations { get; set; } = new List<AdminSpeciality>();

    public virtual AdminUser? CreatedByNavigation { get; set; }

    public virtual ICollection<AdminUser> InverseCreatedByNavigation { get; set; } = new List<AdminUser>();

    public virtual ICollection<AdminUser> InverseLastModifiedByNavigation { get; set; } = new List<AdminUser>();

    public virtual AdminUser? LastModifiedByNavigation { get; set; }
}
