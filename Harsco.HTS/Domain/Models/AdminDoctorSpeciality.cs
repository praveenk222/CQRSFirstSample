using System;
using System.Collections.Generic;

namespace Persistence.Models;

public partial class AdminDoctorSpeciality
{
    public int DoctorSpecialityId { get; set; }

    public int DoctorProfileId { get; set; }

    public string Speciality { get; set; } = null!;

    public DateOnly? CertificationDate { get; set; }

    public bool IsActive { get; set; }

    public DateTime DateCreated { get; set; }

    public int? CreatedBy { get; set; }

    public int? LastModifiedBy { get; set; }

    public DateTime? LastModifiedDate { get; set; }

    public virtual ICollection<AppointmentSlot> AppointmentSlots { get; set; } = new List<AppointmentSlot>();

    public virtual AdminUser? CreatedByNavigation { get; set; }

    public virtual AdminDoctorProfile DoctorProfile { get; set; } = null!;

    public virtual AdminUser? LastModifiedByNavigation { get; set; }
}
