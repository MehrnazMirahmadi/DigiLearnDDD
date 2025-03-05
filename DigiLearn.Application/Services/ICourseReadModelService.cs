using DigiLearn.Application.Models.CourseManagement;

namespace DigiLearn.Application.Services;

public interface ICourseReadModelService
{
    Task<bool> IsCourseExistsByName(string courseName);
    Task<CourseReadModel> GetCourseById(Guid id);
    Task<IEnumerable<CourseReadModel>> SearchCourses(string searchPhrase);
}
