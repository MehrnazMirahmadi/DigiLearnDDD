using DigiLearn.Domain.Entities.CourseManagement;
using DigiLearn.Domain.ValueObjects;

namespace DigiLearn.Domain.Factories.CourseManagement;

public interface ICourseCatalogFactory
{
    CourseCatalog Create(BaseId id, Title title, Description description, BaseId courseId);
}