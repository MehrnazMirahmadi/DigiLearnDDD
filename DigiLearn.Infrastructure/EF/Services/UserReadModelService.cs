using DigiLearn.Application.Models.UserManagement;
using DigiLearn.Application.Services;
using DigiLearn.Infrastructure.EF.Contexts;
using Microsoft.EntityFrameworkCore;

namespace DigiLearn.Infrastructure.EF.Services;

public class UserReadModelService : IUserReadModelService
{
    private readonly ReadDbContext _context;

    public UserReadModelService(ReadDbContext context)
    {
        _context = context;
    }

    public async Task<UserReadModel> GetUserById(Guid id)
    {
        return await _context.Users.SingleOrDefaultAsync(u => u.Id == id);
    }

    public async Task<IEnumerable<UserReadModel>> GetUsers()
    {
        return await _context.Users
            .AsNoTracking()
            .ToListAsync();
    }

    public async Task<bool> IsUserExistsByEmail(string email)
    {
        return await _context.Users
            .AnyAsync(u => u.Email == email);
    }
}

