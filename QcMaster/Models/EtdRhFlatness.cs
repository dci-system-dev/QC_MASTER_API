using System;
using System.Collections.Generic;

namespace QcMaster.Models;

public partial class EtdRhFlatness
{
    public string RhId { get; set; } = null!;

    public int RhFl1PointMax { get; set; }

    public int RhFl1PointMin { get; set; }

    public int RhFl2PointMax { get; set; }

    public int RhFl2PointMin { get; set; }

    public double RhFl1Max { get; set; }

    public double RhFl1Min { get; set; }

    public double RhFl2Max { get; set; }

    public double RhFl2Min { get; set; }

    public double RhFl1Judge { get; set; }

    public string RhFl1JudgeRank { get; set; } = null!;

    public double RhFl2Judge { get; set; }

    public string RhFl2JudgeRank { get; set; } = null!;

    public string RhFlJudgement { get; set; } = null!;

    public DateTime RhFlDate { get; set; }
}
