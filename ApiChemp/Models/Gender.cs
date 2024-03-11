using System;
using System.Collections.Generic;

namespace ApiChemp.Models;

public partial class Gender
{
    public int Id { get; set; }

    public string Namegender { get; set; } = null!;

    public virtual ICollection<User> Users { get; set; } = new List<User>();
}
