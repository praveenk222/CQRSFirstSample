using System;
using System.Collections.Generic;

namespace API.Models;

public partial class AdminLocation
{
    public int LocationId { get; set; }

    public string Name { get; set; } = null!;

    public string? Address { get; set; }

    public string? City { get; set; }

    public string? State { get; set; }

    public string? PostalCode { get; set; }

    public string? Country { get; set; }

    public string? PhoneNumber { get; set; }

    public bool Active { get; set; }

    public DateTime DateCreated { get; set; }

    public int? CreatedBy { get; set; }

    public int? LastModifiedBy { get; set; }

    public DateTime? LastModifiedDate { get; set; }

    public string? Identifier { get; set; }

    public string? Status { get; set; }

    public string? Description { get; set; }

    public string? LocationType { get; set; }

    public string? PhysicalType { get; set; }

    public string? AddressLine1 { get; set; }

    public string? AddressLine2 { get; set; }

    public double? Latitude { get; set; }

    public double? Longitude { get; set; }

    public double? Altitude { get; set; }

    public int? ManagingOrganizationId { get; set; }

    public int? PartOfLocationId { get; set; }

    public string? Mode { get; set; }

    public string? FloorMap { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual ICollection<AdminDoctorLocation> AdminDoctorLocations { get; set; } = new List<AdminDoctorLocation>();

    public virtual AdminUser? CreatedByNavigation { get; set; }

    public virtual ICollection<AdminLocation> InversePartOfLocation { get; set; } = new List<AdminLocation>();

    public virtual AdminUser? LastModifiedByNavigation { get; set; }

    public virtual AdminLocation? PartOfLocation { get; set; }

    public virtual ICollection<PatientDoctorAppointment> PatientDoctorAppointments { get; set; } = new List<PatientDoctorAppointment>();
}
