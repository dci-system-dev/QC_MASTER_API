using System;
using System.Collections.Generic;

namespace QcMaster.Models;

public partial class EtdPiston
{
    public string PtId { get; set; } = null!;

    public string ProId { get; set; } = null!;

    public string? MId { get; set; }

    public string PtLine { get; set; } = null!;

    public int PtPosition { get; set; }

    public string PtJudgement { get; set; } = null!;

    public DateTime? PtDate { get; set; }

    public DateTime? FirstStamptime { get; set; }

    public string? PtMode { get; set; }
}
