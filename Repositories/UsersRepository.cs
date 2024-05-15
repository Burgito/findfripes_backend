using findfripes_dotnet.Database;
using findfripes_dotnet.Models;
using Microsoft.EntityFrameworkCore;

namespace findfripes_dotnet.Repositories;

public interface IUsersRepository 
{
    Task<FFUser?> GetByIdAsync(Guid id);
    Task<FFUser?> GetByEmailAsync(string email);
    Task<long> CreateAsync(FFUser user);
}

public class UsersRepository(PgFindfripesContext context) : IUsersRepository
{
    private readonly PgFindfripesContext _context = context;
    public async Task<long> CreateAsync(FFUser user)
    {
        await _context.Users.AddAsync(user);
        return await _context.SaveChangesAsync();
    }

    public async Task<FFUser?> GetByEmailAsync(string email)
    {
        return await _context.Users.FirstOrDefaultAsync(u => u.Email != null 
            && u.Email.ToLower().Equals(email.ToLower()));
    }

    public async Task<FFUser?> GetByIdAsync(Guid id)
    {
        return await _context.Users.FirstOrDefaultAsync(u => u.Id == id);
    }
}