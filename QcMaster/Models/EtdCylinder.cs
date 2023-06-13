using System;
using System.Collections.Generic;

namespace QcMaster.Models;

public partial class EtdCylinder
{
    public string CyId { get; set; } = null!;

    public string ProId { get; set; } = null!;

    public string? MId { get; set; }

    public string CyLine { get; set; } = null!;

    public int CyPosition { get; set; }

    public string CyJudgement { get; set; } = null!;

    public DateTime? CyDate { get; set; }

    public DateTime? FirstStamptime { get; set; }

    public string? CyMode { get; set; }
}
