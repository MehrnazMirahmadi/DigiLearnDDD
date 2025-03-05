using DigiLearn.Application.Models.CourseManagement;
using DigiLearn.Application.Services;
using DigiLearn.Infrastructure.EF.Contexts;
using Microsoft.EntityFrameworkCore;

namespace DigiLearn.Infrastructure.EF.Services;

public class CourseReadModelService : ICourseReadModelService
{
    private readonly ReadDbContext _context;

    public CourseReadModelService(ReadDbContext context)
    {
        _context = context;
    }

    public async Task<CourseReadModel> GetCourseById(Guid id)
    {
        return await _context.Courses
            .SingleOrDefaultAsync(c => c.Id == id);
    }

    public async Task<bool> IsCourseExistsByName(string courseName)
    {
        return await _context.Courses
            .AnyAsync(c => c.Title == courseName);
    }

    public async Task<IEnumerable<CourseReadModel>> SearchCourses(string searchPhrase)
    {
        return await _context.Courses
            .Where(c => c.Title.Contains(searchPhrase))
            .ToListAsync();
    }
}

