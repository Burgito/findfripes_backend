namespace findfripes_dotnet.Models;

public partial class ProductCategory
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string IconFilename { get; set; } = null!;

    public string ShortDescription { get; set; } = null!;

    public string? LongDescription { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual ICollection<FripeProductCategory> FripeProductCategories { get; set; } = new List<FripeProductCategory>();
}
