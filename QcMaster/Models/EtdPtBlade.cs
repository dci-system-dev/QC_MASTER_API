using System;
using System.Collections.Generic;

namespace QcMaster.Models;

public partial class EtdPtBlade
{
    public string PtId { get; set; } = null!;

    public double? PtBl1 { get; set; }

    public double? PtBl2 { get; set; }

    public double? PtBl3 { get; set; }

    public double? PtBl4 { get; set; }

    public double? PtBl5 { get; set; }

    public double? PtBl6 { get; set; }

    public double PtBlRank { get; set; }

    public string PtBlRankC { get; set; } = null!;

    public double PtBlParallism { get; set; }

    public double PtBlPerpendicularity { get; set; }

    public string PtBlJudgement { get; set; } = null!;

    public DateTime PtBlDate { get; set; }
}
