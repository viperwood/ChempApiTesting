using System;
using System.Collections.Generic;

namespace ApiChemp.Models;

public partial class Issledtipe
{
    public int Id { get; set; }

    public string Nameissled { get; set; } = null!;

    public virtual ICollection<Resept> Resepts { get; set; } = new List<Resept>();
}
