using System;
using System.Collections.Generic;

namespace QcMaster.Models;

public partial class CylinderDataSet
{
    public string? CyId { get; set; }
    public double? CyBuRank { get; set; }
    public double? CyBuJudgeRoundness { get; set; }
    public double? CyBuCylindricity { get; set; }
    public double? CyBuPerpendicularity {  get; set; }   



    public double? CyBoRank { get; set; }
    public double? CyBoJudgeRoundness { get; set; }
    public double? CyBoCylindricity { get; set; }
    public double? CyBoPerpendicularity { get; set; }
    public double? CyBoConcentricity { get; set; }
    public double? CyHeRank { get; set; }

    public double? CyHeParallism {  get; set; }

    public string? Mid { get; set; }
}
