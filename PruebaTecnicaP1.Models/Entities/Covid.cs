using System;
using System.Collections.Generic;

namespace PruebaTecnicaP1.Models.Entities;

public partial class Covid
{
    public long CovidId { get; set; }

    public long RegionId { get; set; }

    public string Country { get; set; } = null!;

    public long? TotalCases { get; set; }

    public long? TotalTests { get; set; }

    public long? ActiveCases { get; set; }

    public virtual Region Region { get; set; } = null!;
}
