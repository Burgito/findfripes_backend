using System;
using System.Collections.Generic;

namespace findfripes_dotnet.Models;

public partial class Address
{
    public int Id { get; set; }

    public string Line1 { get; set; } = null!;

    public string? Line2 { get; set; }

    public string? Line3 { get; set; }

    public string City { get; set; } = null!;

    public string PostCode { get; set; } = null!;

    public string Country { get; set; } = null!;

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual ICollection<Fripe> Fripes { get; set; } = new List<Fripe>();

    public virtual ICollection<FFUser> Users { get; set; } = new List<FFUser>();
}
