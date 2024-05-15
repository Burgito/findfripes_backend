using Microsoft.AspNetCore.Identity;

namespace findfripes_dotnet.Models;

public partial class FFUser : IdentityUser<Guid>
{
    public string? FullName { get; set; }

    public int? AddressId { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual Address? Address { get; set; }

    public virtual ICollection<FripeComment> FripeComments { get; set; } = [];
}
