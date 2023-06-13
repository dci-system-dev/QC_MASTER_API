using System;
using System.Collections.Generic;

namespace QcMaster.Models;

public partial class PistonDataSet
{
    public string? PtId { get; set; }
    public double? PtIdRank { get; set; }
    public double? PtIdRoundness { get; set; }
    public double? PtIdCylindricity { get; set; }
    public double? PtIdPerpendicularity { get; set; }
    public double? PtIdConcentricity { get; set; }



    public double? PtOdRank { get; set; }
    public double? PtOdJudgeRoundness { get; set; }
    public double? PtOdCylindricity { get; set; }
    public double? PtOdPerpendicularity { get; set; }

    public double? PtBlRank { get; set; }
    public double? PtBlParallism { get; set; }
    public double? PtHeRank { get; set; }
    public double? PtHeParallism { get; set; }

    public string? Mid { get; set; }
}
