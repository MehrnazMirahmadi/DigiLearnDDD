using DigiLearn.Domain.Entities.CourseManagement;
using DigiLearn.Domain.Repositories.CourseManagement;
using DigiLearn.Domain.ValueObjects;
using DigiLearn.Infrastructure.EF.Contexts;
using Microsoft.EntityFrameworkCore;

namespace DigiLearn.Infrastructure.EF.Repositories;

public class CourseRepository : ICourseRepository
{
    private readonly WriteDbContext _context;

    public CourseRepository(WriteDbContext context)
    {
        _context = context;
    }

    public async Task AddAsync(Course entity)
    {
        await _context.Courses.AddAsync(entity);
        await _context.SaveChangesAsync();
    }

    public async Task<IReadOnlyList<Course>> GetAll()
    {
        return await _context
                    .Courses
                    .Include("_courseAttendees")
                    .ToListAsync();
    }

    public async Task<Course> GetAsync(BaseId Id)
    {
        return await _context.Courses
            .SingleOrDefaultAsync(u => u.Id == Id);
    }

    public async Task RemoveAsync(Course entity)
    {
        _context.Courses.Remove(entity);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateAsync(Course entity)
    {
        _context.Courses.Update(entity);
        await _context.SaveChangesAsync();
    }
}
