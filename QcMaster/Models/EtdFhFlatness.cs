using System;
using System.Collections.Generic;

namespace QcMaster.Models;

public partial class EtdFhFlatness
{
    public string FhId { get; set; } = null!;

    public int FhFl1PointMax { get; set; }

    public int FhFl1PointMin { get; set; }

    public int FhFl2PointMax { get; set; }

    public int FhFl2PointMin { get; set; }

    public double FhFl1Max { get; set; }

    public double FhFl1Min { get; set; }

    public double FhFl2Max { get; set; }

    public double FhFl2Min { get; set; }

    public double FhFl1Judge { get; set; }

    public string FhFl1JudgeRank { get; set; } = null!;

    public double FhFl2Judge { get; set; }

    public string FhFl2JudgeRank { get; set; } = null!;

    public string FhFlJudgement { get; set; } = null!;

    public DateTime FhFlDate { get; set; }
}
