using System;
using System.Collections.Generic;

namespace ApiChemp.Models;

public partial class Patient
{
    public int Id { get; set; }

    public int? Userid { get; set; }

    public int Pasportn { get; set; }

    public int Pasports { get; set; }

    public DateTime Bethday { get; set; }

    public string Worck { get; set; } = null!;

    public string Strahovcompani { get; set; } = null!;

    public DateTime Datagetmeadcart { get; set; }

    public DateTime Datalastvisit { get; set; }

    public DateTime Datanextvisit { get; set; }

    public int Numberpolis { get; set; }

    public DateTime Datafinishpolis { get; set; }

    public virtual ICollection<Medcart> Medcarts { get; set; } = new List<Medcart>();

    public virtual User? User { get; set; }
}
