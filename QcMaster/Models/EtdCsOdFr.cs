using System;
using System.Collections.Generic;

namespace QcMaster.Models;

public partial class EtdCsOdFr
{
    public string CsId { get; set; } = null!;

    public double CsFrOd1 { get; set; }

    public double CsFrOd2 { get; set; }

    public double CsFrOd3 { get; set; }

    public double CsFrOd4 { get; set; }

    public double CsFrOd5 { get; set; }

    public double CsFrFRank { get; set; }

    public string CsFrFRankC { get; set; } = null!;

    public double CsFrRRank { get; set; }

    public string CsFrRRankC { get; set; } = null!;

    public double CsFrRoundness1 { get; set; }

    public double CsFrRoundness2 { get; set; }

    public double CsFrRoundness3 { get; set; }

    public double CsFrRoundness4 { get; set; }

    public double CsFrRoundness5 { get; set; }

    public double CsFrFJudgeRoundness { get; set; }

    public double CsFrRJudgeRoundness { get; set; }

    public double CsFrFCylindricity { get; set; }

    public double CsFrRCylindricity { get; set; }

    public string CsFrJudgement { get; set; } = null!;

    public DateTime CsFrDate { get; set; }
}
