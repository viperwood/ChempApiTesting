using System;
using System.Collections.Generic;

namespace ApiChemp.Models;

public partial class Raspisanie
{
    public int Id { get; set; }

    public DateTime Datapriema { get; set; }

    public int? Doctorid { get; set; }

    public string? Title { get; set; }

    public int? Napravlenie { get; set; }

    public virtual User? Doctor { get; set; }

    public virtual Napravlenium? NapravlenieNavigation { get; set; }
}
