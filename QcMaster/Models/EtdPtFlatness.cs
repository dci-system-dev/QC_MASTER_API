using System;
using System.Collections.Generic;

namespace QcMaster.Models;

public partial class EtdPtFlatness
{
    public string PtId { get; set; } = null!;

    public double PtFlMax { get; set; }

    public double PtFlMin { get; set; }

    public double PtFlRank { get; set; }

    public string PtFlJudgement { get; set; } = null!;

    public DateTime PtFlDate { get; set; }
}
