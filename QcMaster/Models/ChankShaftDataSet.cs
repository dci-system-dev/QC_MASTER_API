using System;
using System.Collections.Generic;

namespace QcMaster.Models;

public partial class ChankShaftDataSet
{
    public string? CsId { get; set; } = null!;
    public double? CsEccRank { get; set; }
    public double? CsFrFCylindricity { get; set; }
    public double? CsFrFJudgeRoundness { get; set; }

    public double? CsFrFRank { get; set; }
    public double? CsFrRCylindricity { get; set; }
    public double? CsFrRJudgeRoundness { get; set; }
    public double? CsFrRRank { get; set; }
    public double? CsPinCylindricity { get; set; }
    public double? CsPinJudgeRoundness { get; set; }

    public double? CsPinRank {  get; set; }

    public string? Mid { get; set; }
    public string? Label { get; set; }  

    public string? Code { get; set; }   
}
