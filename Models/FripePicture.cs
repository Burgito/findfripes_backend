namespace findfripes_dotnet.Models;

public partial class FripePicture
{
    public int Id { get; set; }

    public string Filename { get; set; } = null!;

    public string ShortDescription { get; set; } = null!;

    public int? FripeId { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual Fripe? Fripe { get; set; }
}
