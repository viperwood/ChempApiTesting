using System;
using System.Collections.Generic;

namespace ApiChemp.Models;

public partial class Resept
{
    public int Id { get; set; }

    public int? Eventid { get; set; }

    public string Recomendation { get; set; } = null!;

    public string Preparat { get; set; } = null!;

    public string Procedur { get; set; } = null!;

    public virtual Event? Event { get; set; }
}
