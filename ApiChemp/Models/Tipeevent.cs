using System;
using System.Collections.Generic;

namespace ApiChemp.Models;

public partial class Tipeevent
{
    public int Id { get; set; }

    public string Nameevent { get; set; } = null!;

    public virtual ICollection<Event> Events { get; set; } = new List<Event>();
}
