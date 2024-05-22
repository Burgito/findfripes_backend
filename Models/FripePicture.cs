namespace findfripes_dotnet.Models;

public partial class FripePicture
{
    public FripePicture()
    {
    }

    public FripePicture(FripePicture fp)
    {
        Id = fp.Id;
        Filename = fp.Filename;
        ShortDescription = fp.ShortDescription;
        FripeId = fp.FripeId;
        CreatedAt = fp.CreatedAt;
        UpdatedAt = fp.UpdatedAt;
        Fripe = fp.Fripe;
    }
    public int Id { get; set; }

    public string Filename { get; set; } = null!;

    public string ShortDescription { get; set; } = null!;

    public int? FripeId { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual Fripe? Fripe { get; set; }
}
