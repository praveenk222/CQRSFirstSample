using System;
using System.Collections.Generic;

namespace API.Models;

public partial class AppointmentSlot
{
    public int SlotId { get; set; }

    public DateTime SlotStart { get; set; }

    public DateTime SlotEnd { get; set; }

    public string Period { get; set; } = null!;

    public string Status { get; set; } = null!;

    public string? ServiceCategory { get; set; }

    public string? ServiceType { get; set; }

    public int? DoctorSpecialityId { get; set; }

    public int? DoctorProfileId { get; set; }

    public virtual AdminDoctorSpeciality? DoctorSpeciality { get; set; }

    public virtual ICollection<PatientDoctorAppointment> PatientDoctorAppointments { get; set; } = new List<PatientDoctorAppointment>();
}
