using findfripes_dotnet.Database;
using findfripes_dotnet.Models;
using Microsoft.EntityFrameworkCore;

namespace findfripes_dotnet.Repositories;

public interface IFripesRepository 
{
    Task<IEnumerable<Fripe>> GetAllFripesAsync();
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

    public async Task<IEnumerable<Fripe>> GetAllFripesAsync()
    {
        return await _context.Fripes.ToListAsync();
    }

    public async Task<Fripe?> GetByIdAsync(long id)
    {
        return await _context.Fripes.FirstOrDefaultAsync(f => f.Id == id);
    }

    public async Task<IEnumerable<Fripe>> GetFripesByCityAsync(string city)
    {
        var fripes = await _context.Fripes
            .Include(f => f.Address)
            .Where(f => f.Address.City.ToLower().Contains(city.ToLower()))
            .ToListAsync();
        return fripes;
    }
}