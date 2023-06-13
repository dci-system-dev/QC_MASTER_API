using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace QcMaster.Models;

public partial class EtdFhDetail
{
    public string FhId { get; set; } = null!;

    public double? FhId1 { get; set; }

    public double? FhId2 { get; set; }

    public double? FhId3 { get; set; }

    public double? FhRank { get; set; }

    public string? FhRankC { get; set; } = null!;

    public double? FhRoundness1 { get; set; }

    public double? FhRoundness2 { get; set; }

    public double? FhRonudness3 { get; set; }

    public double FhJudgeRoundness { get; set; }

    public double FhCylindricity { get; set; }

    public double FhPerpendicularity { get; set; }

    public double? FhConcentricity { get; set; }

    public string? FhJudgement { get; set; } = null!;

    [NotMapped]
    public string? Mid { get; set; } 

    public DateTime FhDate { get; set; }
}
