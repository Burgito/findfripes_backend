using findfripes_dotnet.Models;
using findfripes_dotnet.Repositories;

namespace findfripes_dotnet.Services;

public interface IAddressesService 
{
    Task<IEnumerable<Address>> GetAllAddressesAsync();
    Task<IEnumerable<Address>> GetAllAddressesLimitOrderByCityAsync(int number);
    Task<long> CreateAddressAsync(Address address);
    Task<IEnumerable<Address>> GetDistinctCitiesLikeAsync(string city);
}

public class AddressesService(IAddressesRepository addressesRepository) : IAddressesService
{
    private readonly IAddressesRepository _addressesRepository = addressesRepository;

    public async Task<long> CreateAddressAsync(Address address)
    {
        return await _addressesRepository.CreateAsync(address);
    }

    public async Task<IEnumerable<Address>> GetAllAddressesAsync()
    {
        return await _addressesRepository.GetAllAsync();
    }

    public async Task<IEnumerable<Address>> GetAllAddressesLimitOrderByCityAsync(int number)
    {
        return await _addressesRepository.GetAllLimitOrderbyCityAsync(number);
    }

    public async Task<IEnumerable<Address>> GetDistinctCitiesLikeAsync(string city)
    {
        return await _addressesRepository.GetWithCityLikeAsync(city);
    }
}
