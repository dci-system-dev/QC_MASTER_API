using System;
using System.Collections.Generic;

namespace QcMaster.Models;

public partial class FrontHeadDataSet
{
    public string FhId { get; set; } = null!;

    public double FhRank { get; set; }

    public double FhJudgeRoundness { get; set; }

    public double FhCylindricity { get; set; }

    public double FhPerpendicularity { get; set; }

    public double? FhConcentricity { get; set; }

    public string? FhJudgement { get; set; } = null!;

    public string Mid { get; set; }
}
