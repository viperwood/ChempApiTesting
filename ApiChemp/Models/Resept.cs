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

    public string? Doza { get; set; }

    public string? Format { get; set; }

    public string? Napravlen { get; set; }

    public int? Issledovanie { get; set; }

    public string? Procedure { get; set; }

    public virtual Event? Event { get; set; }

    public virtual Issledtipe? IssledovanieNavigation { get; set; }
}
