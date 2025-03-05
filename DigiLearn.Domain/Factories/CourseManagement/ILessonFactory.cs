using DigiLearn.Domain.Entities.CourseManagement;
using DigiLearn.Domain.ValueObjects;

namespace DigiLearn.Domain.Factories.CourseManagement;

public interface ILessonFactory
{
    Lesson Create(BaseId id, Title title, VideoUrl videoUrl, BaseId courseCatalogId);
}
