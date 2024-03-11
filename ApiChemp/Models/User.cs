using System;
using System.Collections.Generic;

namespace ApiChemp.Models;

public partial class User
{
    public int Id { get; set; }

    public string Nameuser { get; set; } = null!;

    public int? Roleuser { get; set; }

    public string Phone { get; set; } = null!;

    public int? Genderuser { get; set; }

    public string Adres { get; set; } = null!;

    public string? Foto { get; set; }

    public string Emailuser { get; set; } = null!;

    public virtual ICollection<Event> Events { get; set; } = new List<Event>();

    public virtual Gender? GenderuserNavigation { get; set; }

    public virtual ICollection<Patient> Patients { get; set; } = new List<Patient>();

    public virtual Role? RoleuserNavigation { get; set; }
}
