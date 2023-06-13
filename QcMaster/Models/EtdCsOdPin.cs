using System;
using System.Collections.Generic;

namespace QcMaster.Models;

public partial class EtdCsOdPin
{
    public string CsId { get; set; } = null!;

    public double? CsPinOd1 { get; set; }

    public double? CsPinOd2 { get; set; }

    public double? CsPinOd3 { get; set; }

    public double? CsPinRank { get; set; }

    public string? CsPinRankC { get; set; }

    public double? CsPinRoundness1 { get; set; }

    public double? CsPinRoundness2 { get; set; }

    public double? CsPinRoundness3 { get; set; }

    public double? CsPinJudgeRoundness { get; set; }

    public double? CsPinCylindricity { get; set; }

    public string CsPinJudgement { get; set; } = null!;

    public DateTime? CsPinDate { get; set; }
}
