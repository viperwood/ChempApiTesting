using System;
using System.Collections.Generic;

namespace ApiChemp.Models;

public partial class Napravlenium
{
    public int Id { get; set; }

    public string Namenaprav { get; set; } = null!;

    public virtual ICollection<Raspisanie> Raspisanies { get; set; } = new List<Raspisanie>();
}
