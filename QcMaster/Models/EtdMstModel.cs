﻿using System;
using System.Collections.Generic;

namespace QcMaster.Models;

public partial class EtdMstModel
{
    public string MId { get; set; } = null!;

    public string MName { get; set; } = null!;

    public DateTime MDate { get; set; }

    public string MUser { get; set; } = null!;
}
