using System;
using System.Collections.Generic;

namespace ApiChemp.Models;

public partial class Event
{
    public int Id { get; set; }

    public int? Medcartid { get; set; }

    public int? Eventid { get; set; }

    public int? Doctor { get; set; }

    public DateTime Dataevent { get; set; }

    public string Nameevent { get; set; } = null!;

    public string Resultevent { get; set; } = null!;

    public string Opisanie { get; set; } = null!;

    public virtual User? DoctorNavigation { get; set; }

    public virtual Tipeevent? EventNavigation { get; set; }

    public virtual Medcart? Medcart { get; set; }

    public virtual ICollection<Resept> Resepts { get; set; } = new List<Resept>();
}
