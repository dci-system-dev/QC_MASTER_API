using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace QcMaster.Models;

public partial class EtdRhDetail
{
    public string RhId { get; set; } = null!;

    public double? RhId1 { get; set; }

    public double? RhId2 { get; set; }

    public double? RhId3 { get; set; }

    public double RhRank { get; set; }

    public string? RhRankC { get; set; }

    public double? RhRoundness1 { get; set; }

    public double? RhRoundness2 { get; set; }

    public double? RhRoundness3 { get; set; }

    public double RhJudgeRoundness { get; set; }

    public double RhCylindricity { get; set; }

    public double RhPerpendicularity { get; set; }

    public string? RhJudgement { get; set; }

    public DateTime RhDate { get; set; }
    [NotMapped]
    public string? Mid { get; set; }
}
