using System;
using System.Collections.Generic;

namespace NatureHub2.Models;

public partial class Remedy
{
    public int RemedyId { get; set; }

    public string Title { get; set; } = null!;

    public string? Description { get; set; }

    public string? Category { get; set; }

    public string? PreparationMethod { get; set; }

    public string? UsageInstructions { get; set; }
}
