using System;
using System.Collections.Generic;

namespace API.Models;

public partial class FdCaption
{
    public int Id { get; set; }

    public string? EnUs { get; set; }

    public bool IsDeleted { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public string FacilityCode { get; set; } = null!;

    public virtual ICollection<FdForm> FdForms { get; set; } = new List<FdForm>();

    public virtual ICollection<FdMainMenu> FdMainMenus { get; set; } = new List<FdMainMenu>();

    public virtual ICollection<FdModule> FdModules { get; set; } = new List<FdModule>();

    public virtual ICollection<RdReport> RdReports { get; set; } = new List<RdReport>();
}
