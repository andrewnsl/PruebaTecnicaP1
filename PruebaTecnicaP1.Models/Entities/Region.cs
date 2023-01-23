using System;
using System.Collections.Generic;

namespace PruebaTecnicaP1.Models.Entities;

public partial class Region
{
    public long RegionId { get; set; }

    public string Descripcion { get; set; } = null!;

    public virtual ICollection<Covid> Covids { get; } = new List<Covid>();
}
