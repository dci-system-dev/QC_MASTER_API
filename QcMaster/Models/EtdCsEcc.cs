using System;
using System.Collections.Generic;

namespace QcMaster.Models;

public partial class EtdCsEcc
{
    public string CsId { get; set; } = null!;

    public double? CsEccRank { get; set; }

    public string? CsEccRankC { get; set; }

    public string CsEccJudgement { get; set; } = null!;

    public DateTime CsEccDate { get; set; }
}
