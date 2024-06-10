using System.Text.Json.Serialization;

namespace findfripes_dotnet.Models;

public partial class FripeComment
{
    public int Id { get; set; }

    public string Text { get; set; } = null!;

    public Guid UserId { get; set; }

    public int FripeId { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    [JsonIgnore]
    public virtual Fripe Fripe { get; set; } = null!;

    public virtual FFUser User { get; set; } = null!;
}
