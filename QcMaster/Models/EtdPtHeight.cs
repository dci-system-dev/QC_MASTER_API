using System;
using System.Collections.Generic;

namespace QcMaster.Models;

public partial class EtdPtHeight
{
    public string PtId { get; set; } = null!;

    public double PtHe1 { get; set; }

    public double PtHe2 { get; set; }

    public double PtHe3 { get; set; }

    public double PtHe4 { get; set; }

    public double PtHeRank { get; set; }

    public string PtHeRankC { get; set; } = null!;

    public double PtHeParallism { get; set; }

    public string PtHeJudgement { get; set; } = null!;

    public DateTime PtHeDate { get; set; }

    public string? PtHeMode { get; set; }
}
