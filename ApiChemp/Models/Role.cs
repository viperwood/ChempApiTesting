using System;
using System.Collections.Generic;

namespace ApiChemp.Models;

public partial class Role
{
    public int Id { get; set; }

    public string Namerole { get; set; } = null!;

    public virtual ICollection<User> Users { get; set; } = new List<User>();
}
