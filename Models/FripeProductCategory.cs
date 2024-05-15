namespace findfripes_dotnet.Models;

public partial class FripeProductCategory
{
    public int Id { get; set; }

    public int? FripeId { get; set; }

    public int? ProductCategoryId { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual Fripe? Fripe { get; set; }

    public virtual ProductCategory? ProductCategory { get; set; }
}
