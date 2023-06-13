using System;
using System.Collections.Generic;

namespace QcMaster.Models;

public partial class EtdRearHead
{
    public string RhId { get; set; } = null!;

    public string ProId { get; set; } = null!;

    public string? MId { get; set; }

    public string RhLine { get; set; } = null!;

    public int RhPosition { get; set; }

    public string RhJudgement { get; set; } = null!;

    public DateTime? RhDate { get; set; }

    public DateTime? FirstStamptime { get; set; }

    public string? RhMode { get; set; }
}
