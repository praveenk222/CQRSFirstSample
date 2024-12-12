using System;
using System.Collections.Generic;

namespace Persistence.Models;

public partial class AdminDoctorProfile
{
    public int DoctorProfileId { get; set; }

    public string? Identifier { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string? MiddleName { get; set; }

    public string? Gender { get; set; }

    public DateOnly? DateOfBirth { get; set; }

    public string? PhoneNumber { get; set; }

    public string? Email { get; set; }

    public string? Address { get; set; }

    public string? City { get; set; }

    public string? State { get; set; }

    public string? PostalCode { get; set; }

    public string? Country { get; set; }

    public int? OrganizationId { get; set; }

    public bool Active { get; set; }

    public DateTime DateCreated { get; set; }

    public int? CreatedBy { get; set; }

    public int? LastModifiedBy { get; set; }

    public DateTime? LastModifiedDate { get; set; }

    public string ImageUrl { get; set; } = null!;

    public DateOnly NextAvailability { get; set; }

    public virtual ICollection<AdminDoctorLocation> AdminDoctorLocations { get; set; } = new List<AdminDoctorLocation>();

    public virtual ICollection<AdminDoctorSchedule> AdminDoctorSchedules { get; set; } = new List<AdminDoctorSchedule>();

    public virtual ICollection<AdminDoctorSpeciality> AdminDoctorSpecialities { get; set; } = new List<AdminDoctorSpeciality>();

    public virtual AdminUser? CreatedByNavigation { get; set; }

    public virtual ICollection<Language> Languages { get; set; } = new List<Language>();

    public virtual AdminUser? LastModifiedByNavigation { get; set; }

    public virtual AdminOrganization? Organization { get; set; }

    public virtual ICollection<PatientDoctorAppointment> PatientDoctorAppointments { get; set; } = new List<PatientDoctorAppointment>();
}
