using System;
using System.Collections.Generic;

namespace API.Models;

public partial class PatientUser
{
    public string PatientId { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string? ImageUrl { get; set; }

    public string? Id { get; set; }

    public string Gender { get; set; } = null!;

    public string PhoneNumber { get; set; } = null!;

    public string Email { get; set; } = null!;

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public string? Username { get; set; }

    public string? Password { get; set; }

    public string? IdentifierIc { get; set; }

    public string? IdentifierPassport { get; set; }

    public string? IdentifierMrn { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? MiddleName { get; set; }

    public DateTime? DateOfBirth { get; set; }

    public string? Address { get; set; }

    public string? City { get; set; }

    public string? State { get; set; }

    public string? PostalCode { get; set; }

    public string? Country { get; set; }

    public string? MaritalStatus { get; set; }

    public string? Language { get; set; }

    public string? Nationality { get; set; }

    public string? Religion { get; set; }

    public string? Ethnicity { get; set; }

    public string? BirthPlace { get; set; }

    public bool? Active { get; set; }

    public string? PreferredName { get; set; }

    public string? CreatedBy { get; set; }

    public string? UpdatedBy { get; set; }

    public string? Salutation { get; set; }

    public string? PassportIssuedCountry { get; set; }

    public string? PassportNumber { get; set; }

    public virtual ICollection<DependentAndOther> DependentAndOtherPatients { get; set; } = new List<DependentAndOther>();

    public virtual ICollection<DependentAndOther> DependentAndOtherRelations { get; set; } = new List<DependentAndOther>();

    public virtual ICollection<Identifier> Identifiers { get; set; } = new List<Identifier>();
}
