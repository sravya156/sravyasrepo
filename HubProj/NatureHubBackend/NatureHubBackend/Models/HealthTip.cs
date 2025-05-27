using System;
using System.Collections.Generic;

namespace NatureHub2.Models;

public partial class HealthTip
{
    public int TipId { get; set; }

    public string? Category { get; set; }

    public string? Content { get; set; }
}
