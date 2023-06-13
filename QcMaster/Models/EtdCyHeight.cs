using System;
using System.Collections.Generic;

namespace QcMaster.Models;

public partial class EtdCyHeight
{
    public string CyId { get; set; } = null!;

    public double CyHe1 { get; set; }

    public double CyHe2 { get; set; }

    public double CyHe3 { get; set; }

    public double CyHe4 { get; set; }

    public double CyHeRank { get; set; }

    public string CyHeRankC { get; set; } = null!;

    public double CyHeParallism { get; set; }

    public string CyHeJudgement { get; set; } = null!;

    public DateTime CyHeDate { get; set; }

    public string? CyHeMode { get; set; }
}
