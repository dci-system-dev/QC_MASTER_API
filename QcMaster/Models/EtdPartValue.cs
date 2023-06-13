using System;
using System.Collections.Generic;

namespace QcMaster.Models;

public partial class EtdPartValue
{
    public string PartNo { get; set; } = null!;

    public string MufflerId { get; set; } = null!;

    public int PId { get; set; }
}
