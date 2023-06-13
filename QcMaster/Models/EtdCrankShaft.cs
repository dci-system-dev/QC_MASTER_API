using System;
using System.Collections.Generic;

namespace QcMaster.Models;

public partial class EtdCrankShaft
{
    public string CsId { get; set; } = null!;

    public string ProId { get; set; } = null!;

    public string? MId { get; set; }

    public string CsLine { get; set; } = null!;

    public int CsPosition { get; set; }

    public string CsJudgement { get; set; } = null!;

    public DateTime? CsDate { get; set; }

    public DateTime? FirstStamptime { get; set; }

    public string? CsMode { get; set; }
}
