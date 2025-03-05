using DigiLearn.Domain.Entities.UserManagement;
using DigiLearn.Domain.Repositories.UserManagement;
using DigiLearn.Domain.ValueObjects;
using DigiLearn.Infrastructure.EF.Contexts;
using Microsoft.EntityFrameworkCore;

namespace DigiLearn.Infrastructure.EF.Repositories;

public class UserRepository : IUserRepository
{
    private readonly WriteDbContext _context;

    public UserRepository(WriteDbContext context)
    {
        _context = context;
    }

    public async Task AddAsync(User entity)
    {
        await _context.Users.AddAsync(entity);
        await _context.SaveChangesAsync();
    }

    public async Task<IReadOnlyList<User>> GetAll()
    {
        return await _context
            .Users
            .Include("_userRoles")
            .ToListAsync();
    }

    public async Task<User> GetAsync(BaseId Id)
    {
        return await _context.Users
            .SingleOrDefaultAsync(u => u.Id == Id);
    }

    public async Task RemoveAsync(User entity)
    {
        _context.Users.Remove(entity);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateAsync(User entity)
    {
        _context.Users.Update(entity);
        await _context.SaveChangesAsync();
    }
}

