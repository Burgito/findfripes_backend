using findfripes_dotnet.Database;
using findfripes_dotnet.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;

namespace findfripes_dotnet.Repositories;

public interface IFripesRepository
{
    Task<IEnumerable<Fripe>> GetAllFripesAsync(int limit);
    Task<IEnumerable<Fripe>> GetFripesByCityAsync(string city);
    Task<Fripe?> GetByIdAsync(long id);
    Task<long> CreateAsync(Fripe fripe);
}

public class FripesRepository(PgFindfripesContext context) : IFripesRepository
{
    private readonly PgFindfripesContext _context = context;

    public async Task<long> CreateAsync(Fripe fripe)
    {
        await _context.Fripes.AddAsync(fripe);
        return await _context.SaveChangesAsync();
    }

    public async Task<IEnumerable<Fripe>> GetAllFripesAsync(int limit)
    {
        return await _context
            .Fripes
            .Include(f => f.Address)
            .Take(limit)
            .AsNoTracking()
            .ToListAsync();
    }

    public async Task<Fripe?> GetByIdAsync(long id)
    {
        return await _context.Fripes.FirstOrDefaultAsync(f => f.Id == id);
    }

    public async Task<IEnumerable<Fripe>> GetFripesByCityAsync(string city)
    {
        var fripes = await _context.Fripes
            .Include(f => f.Address)
            .Include(f => f.FripePictures)
            .Where(f => f.Address.City.ToLower().Contains(city.ToLower()))
            .Take(50)
            .AsNoTracking()
            .Select(f =>
                new Fripe()
                {
                    Address = f.Address,
                    AddressId = f.AddressId,
                    CreatedAt = f.CreatedAt,
                    FripePictures = f.FripePictures.IsNullOrEmpty()
                        ? new List<FripePicture>()
                        : new List<FripePicture>() { new(f.FripePictures.First()) },
                    FripeProductCategories = f.FripeProductCategories,
                    GpsCoordinates = f.GpsCoordinates,
                    Id = f.Id,
                    ShortDescription = f.ShortDescription,
                    Name = f.Name
                }
            )
            .ToListAsync();
        return fripes;
    }
}