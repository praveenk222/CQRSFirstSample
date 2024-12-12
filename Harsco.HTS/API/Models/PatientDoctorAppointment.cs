using System;
using System.Collections.Generic;

namespace API.Models;

public partial class PatientDoctorAppointment
{
    public int AppointmentId { get; set; }

    public int DoctorProfileId { get; set; }

    public int SlotId { get; set; }

    public string? VisitType { get; set; }

    public string? PaymentMethod { get; set; }

    public DateTime StartDateTime { get; set; }

    public DateTime? EndDateTime { get; set; }

    public string? SlotType { get; set; }

    public string? Status { get; set; }

    public string? ReasonCode { get; set; }

    public string? Notes { get; set; }

    public string? Description { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? DateCreated { get; set; }

    public int? LastModifiedBy { get; set; }

    public DateTime? LastModifiedDate { get; set; }

    public DateTime? CheckInTime { get; set; }

    public bool? IsBlacklisted { get; set; }

    public string? PatientId { get; set; }

    public int? AppointmentLocationId { get; set; }

    public virtual AdminLocation? AppointmentLocation { get; set; }

    public virtual AdminDoctorProfile DoctorProfile { get; set; } = null!;

    public virtual User? Patient { get; set; }

    public virtual AppointmentSlot Slot { get; set; } = null!;
}
