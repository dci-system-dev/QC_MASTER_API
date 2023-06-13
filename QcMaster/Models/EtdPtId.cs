using System;
using System.Collections.Generic;

namespace QcMaster.Models;

public partial class EtdPtId
{
    public string PtId { get; set; } = null!;

    public double? PtId1 { get; set; }

    public double? PtId2 { get; set; }

    public double? PtId3 { get; set; }

    public double PtIdRank { get; set; }

    public string PtIdRankC { get; set; } = null!;

    public double? PtIdRoundness1 { get; set; }

    public double? PtIdRoundness2 { get; set; }

    public double? PtIdRoundness3 { get; set; }

    public double PtIdRoundness { get; set; }

    public double PtIdCylindricity { get; set; }

    public double PtIdPerpendicularity { get; set; }

    public double? PtIdConcentricity { get; set; }

    public string PtIdJudgement { get; set; } = null!;

    public DateTime PtIdDate { get; set; }
}
