using System;
using System.Collections.Generic;

namespace QcMaster.Models;

public partial class EtdFrontHead
{
    public string FhId { get; set; } = null!;

    public string ProId { get; set; } = null!;

    public string? MId { get; set; }

    public string FhLine { get; set; } = null!;

    public int FhPosition { get; set; }

    public string FhJudgement { get; set; } = null!;

    public DateTime? FhDate { get; set; }

    public DateTime? FirstStamptime { get; set; }

    public string? FhMode { get; set; }
}
