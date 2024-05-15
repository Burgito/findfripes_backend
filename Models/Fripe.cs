using System;
using System.Collections.Generic;

namespace findfripes_dotnet.Models;

public partial class Fripe
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string ShortDescription { get; set; } = null!;

    public string LongDescription { get; set; } = null!;

    public string? GpsCoordinates { get; set; }

    public int AddressId { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual Address Address { get; set; } = null!;

    public virtual ICollection<FripeComment> FripeComments { get; set; } = new List<FripeComment>();

    public virtual ICollection<FripePicture> FripePictures { get; set; } = new List<FripePicture>();

    public virtual ICollection<FripeProductCategory> FripeProductCategories { get; set; } = new List<FripeProductCategory>();
}
