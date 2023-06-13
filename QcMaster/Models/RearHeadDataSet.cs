using System;
using System.Collections.Generic;

namespace QcMaster.Models;

public partial class ReadHeaderDataSet
{
    public string RhId { get; set; } = null!;

    public double RhRank { get; set; }

    public double RhJudgeRoundness { get; set; }

    public double RhCylindricity { get; set; }

    public double RhPerpendicularity { get; set; }

    public double? RhConcentricity { get; set; }

    public string? RhJudgement { get; set; } = null!;

    public string Mid { get; set; }
}
