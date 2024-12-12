using System;
using System.Collections.Generic;

namespace API.Models;

public partial class PatientsUser
{
    public int PatientId { get; set; }

    public string Name { get; set; } = null!;

    public string? ImageUrl { get; set; }

    public string Gender { get; set; } = null!;

    public string PhoneNumber { get; set; } = null!;

    public string Email { get; set; } = null!;

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public DateTime? DateOfBirth { get; set; }

    public string? Address { get; set; }

    public string? City { get; set; }

    public string? State { get; set; }

    public string? PostalCode { get; set; }

    public string? Country { get; set; }

    public string? MaritalStatus { get; set; }

    public string? Nationality { get; set; }

    public bool? Active { get; set; }

    public string? PreferredName { get; set; }

    public string CreatedBy { get; set; } = null!;

    public string? UpdatedBy { get; set; }
}
