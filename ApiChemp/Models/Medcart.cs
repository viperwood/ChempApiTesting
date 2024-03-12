using System;
using System.Collections.Generic;

namespace ApiChemp.Models;

public partial class Medcart
{
    public int Id { get; set; }

    public int? Patientid { get; set; }

    public int Numbermedcart { get; set; }

    public string Diagnos { get; set; } = null!;

    public string? Anamnis { get; set; }

    public string? Simptomatica { get; set; }

    public virtual ICollection<Event> Events { get; set; } = new List<Event>();

    public virtual Patient? Patient { get; set; }
}
