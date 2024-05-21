using findfripes_dotnet.Models;
using findfripes_dotnet.Repositories;

namespace findfripes_dotnet.Services;

public interface IFripesService
{
    Task<IEnumerable<Fripe>> GetAllFripesAsync(int limit);
    Task<IEnumerable<Fripe>> GetFripesByCityAsync(string city);
    Task<Fripe?> GetByIdAsync(long id);
    Task<long> CreateAsync(Fripe fripe);
}

public class FripeService(IFripesRepository fripesRepository, IAddressesRepository addressesRepository) : IFripesService
{
    private readonly IFripesRepository _fripesRepository = fripesRepository;
    private readonly IAddressesRepository _addressesRepository = addressesRepository;
    public async Task<long> CreateAsync(Fripe fripe)
    {
        var createdAddresses = await _addressesRepository.CreateAsync(fripe.Address);
        return createdAddresses > 0 ? await _fripesRepository.CreateAsync(fripe) : -1;
    }

    public async Task<IEnumerable<Fripe>> GetAllFripesAsync(int limit)
    {
        return await _fripesRepository.GetAllFripesAsync(limit);
    }

    public async Task<Fripe?> GetByIdAsync(long id)
    {
        return await _fripesRepository.GetByIdAsync(id);
    }

    public async Task<IEnumerable<Fripe>> GetFripesByCityAsync(string city)
    {
        return await _fripesRepository.GetFripesByCityAsync(city);
    }
}