using System;
using System.Collections.Generic;

namespace API.Models;

public partial class RdReport
{
    public int Id { get; set; }

    public string ReportName { get; set; } = null!;

    public int? FormId { get; set; }

    public int CaptionId { get; set; }

    public string? Rdlfile { get; set; }

    public int ReportModuleId { get; set; }

    public bool IsDeleted { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public string FacilityCode { get; set; } = null!;

    public virtual FdCaption Caption { get; set; } = null!;

    public virtual ICollection<FdMainMenu> FdMainMenus { get; set; } = new List<FdMainMenu>();
}
