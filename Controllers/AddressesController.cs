using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using findfripes_dotnet.Database;
using findfripes_dotnet.Models;
using findfripes_dotnet.Services;
using Microsoft.IdentityModel.Tokens;

namespace findfripes_dotnet.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AddressesController(IAddressesService addressesService) : ControllerBase
    {
        private readonly IAddressesService _addressesService = addressesService;

        // GET: api/Addresses
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Address>>> GetAddresses(string? city)
        {
            var addresses = city.IsNullOrEmpty() 
                ? await _addressesService.GetAllAddressesLimitOrderByCityAsync(30)
                : await _addressesService.GetDistinctCitiesLikeAsync(city!);
            return Ok(addresses);
        }
    }
}
