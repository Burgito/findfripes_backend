using findfripes_dotnet.Database;
using findfripes_dotnet.Models;
using Microsoft.EntityFrameworkCore;

namespace findfripes_dotnet.Repositories;

public interface IAddressesRepository
{
    Task<long> CreateAsync(Address address);
    Task<Address?> GetByIdAsync(long id);
    Task<IEnumerable<Address>> GetAllAsync();
    Task<IEnumerable<Address>> GetWithCityLikeAsync(string city);
    Task<IEnumerable<Address>> GetAllLimitOrderbyCityAsync(int nbResults);
}

public class AddressesRepository(PgFindfripesContext context) : IAddressesRepository
{
    private readonly PgFindfripesContext _context = context;
    public async Task<long> CreateAsync(Address address)
    {
        await _context.AddAsync(address);
        return await _context.SaveChangesAsync();
    }

    public async Task<IEnumerable<Address>> GetAllAsync()
    {
        return await _context.Addresses.ToListAsync();
    }

    public async Task<IEnumerable<Address>> GetAllLimitOrderbyCityAsync(int nbResults)
    {
        return await _context.Addresses
            .OrderBy(a => a.City)
            .Take(nbResults)
            .ToListAsync();
    }

    public async Task<Address?> GetByIdAsync(long id)
    {
        return await _context.Addresses.FirstOrDefaultAsync(f => f.Id == id);
    }

    public async Task<IEnumerable<Address>> GetWithCityLikeAsync(string city)
    {
        var addresses = await _context.Addresses
            .Where(a => a.City.ToLower().Contains(city.ToLower())).ToListAsync(); 
        return addresses.DistinctBy(a => a.City);
    }
}