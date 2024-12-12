using System;
using System.Collections.Generic;

namespace Persistence.Models;

public partial class User
{
    public int Id { get; set; }

    public string? Gender { get; set; }

    public DateTime? BirthOfDate { get; set; }

    public DateTime? RegistrationDate { get; set; }

    public string? MyKadMyKidMyPr { get; set; }

    public string? CmndPassportNumberBirthCertificate { get; set; }

    public string? NomorKtpNomorPassporNomorSimNomorSuratLahir { get; set; }

    public string? PassportNumber { get; set; }

    public string? Passcode { get; set; }

    public string PhoneNumber { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string? Country { get; set; }

    public string? ProfileImage { get; set; }

    public bool? UserType { get; set; }

    public string? Password { get; set; }

    public bool? LocationEnable { get; set; }

    public string? Name { get; set; }

    public string? PreferredName { get; set; }

    public bool? NotificationEnabled { get; set; }

    public bool? SosbuttonEnabled { get; set; }

    public bool? BioAuthenticationEnabled { get; set; }

    public string UserId { get; set; } = null!;

    public int? RetryAttempt { get; set; }

    public DateTime? LastLoginFailedTime { get; set; }

    public bool? Status { get; set; }

    public string? Nationality { get; set; }

    public DateTime? PassportExpiryDate { get; set; }

    public string? PassportIssueCountry { get; set; }

    public string Uhid { get; set; } = null!;

    public string? Salutation { get; set; }

    public virtual ICollection<Dependent> Dependents { get; set; } = new List<Dependent>();

    public virtual ICollection<Mrn> Mrns { get; set; } = new List<Mrn>();

    public virtual ICollection<PatientDoctorAppointment> PatientDoctorAppointments { get; set; } = new List<PatientDoctorAppointment>();
}
