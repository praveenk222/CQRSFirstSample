using System;
using System.Collections.Generic;

namespace API.Models;

public partial class EmployeeTypeMaster
{
    public byte Id { get; set; }

    public string EmployeeTypeCode { get; set; } = null!;

    public string EmployeeTypeName { get; set; } = null!;

    public bool IsDeleted { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public string FacilityCode { get; set; } = null!;
}
