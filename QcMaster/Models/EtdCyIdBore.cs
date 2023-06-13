using System;
using System.Collections.Generic;

namespace QcMaster.Models;

public partial class EtdCyIdBore
{
    public string CyId { get; set; } = null!;

    public double? CyBo1 { get; set; }

    public double? CyBo2 { get; set; }

    public double? CyBo3 { get; set; }

    public double CyBoRank { get; set; }

    public string CyBoRankC { get; set; } = null!;

    public double? CyBoRoundness1 { get; set; }

    public double? CyBoRoundness2 { get; set; }

    public double? CyBoRoundness3 { get; set; }

    public double CyBoJudgeRoundness { get; set; }

    public double CyBoCylindricity { get; set; }

    public double CyBoPerpendicularity { get; set; }

    public double CyBoConcentricity { get; set; }

    public string CyBoJudgement { get; set; } = null!;

    public DateTime CyBoDate { get; set; }
}
