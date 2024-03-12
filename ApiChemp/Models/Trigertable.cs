using System;
using System.Collections.Generic;

namespace ApiChemp.Models;

public partial class Trigertable
{
    public int Id { get; set; }

    public int? Personcode { get; set; }

    public string? Personrole { get; set; }

    public string? Lastsecuritypointnumber { get; set; }

    public string? Lastsecuritypointdirection { get; set; }

    public DateTime? Lastsecuritypointtime { get; set; }
}
