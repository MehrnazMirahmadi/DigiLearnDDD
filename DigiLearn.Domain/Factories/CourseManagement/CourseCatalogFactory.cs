using DigiLearn.Domain.Entities.CourseManagement;
using DigiLearn.Domain.ValueObjects;

namespace DigiLearn.Domain.Factories.CourseManagement;

public class CourseCatalogFactory : ICourseCatalogFactory
{
    public CourseCatalog Create(BaseId id, Title title, Description description, BaseId courseId)
    {
        return new CourseCatalog(id, title, description, courseId);
    }
}
