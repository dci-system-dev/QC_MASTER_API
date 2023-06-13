using System;
using System.Collections.Generic;

namespace QcMaster.Models;

public partial class EtdCyIdBush
{
    public string CyId { get; set; } = null!;

    public double? CyBu1 { get; set; }

    public double? CyBu2 { get; set; }

    public double? CyBu3 { get; set; }

    public double CyBuRank { get; set; }

    public string CyBuRankC { get; set; } = null!;

    public double? CyBuRoundness1 { get; set; }

    public double? CyBuRoundness2 { get; set; }

    public double? CyBuRoundness3 { get; set; }

    public double CyBuJudgeRoundness { get; set; }

    public double CyBuPerpendicularity { get; set; }

    public string CyBuJudgement { get; set; } = null!;

    public DateTime CyBuDate { get; set; }

    public double? CyBuCylindricity { get; set; }
}
