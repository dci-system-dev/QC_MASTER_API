using System;
using System.Collections.Generic;

namespace QcMaster.Models;

public partial class EtdPtOd
{
    public string PtId { get; set; } = null!;

    public double? PtOd1 { get; set; }

    public double? PtOd2 { get; set; }

    public double? PtOd3 { get; set; }

    public double PtOdRank { get; set; }

    public string PtOdRankC { get; set; } = null!;

    public double? PtOdRoundness1 { get; set; }

    public double? PtOdRoundness2 { get; set; }

    public double? PtOdRoundness3 { get; set; }

    public double PtOdJudgeRoundness { get; set; }

    public double PtOdCylindricity { get; set; }

    public double PtOdPerpendicularity { get; set; }

    public string PtOdJudgement { get; set; } = null!;

    public DateTime PtOdDate { get; set; }
}
