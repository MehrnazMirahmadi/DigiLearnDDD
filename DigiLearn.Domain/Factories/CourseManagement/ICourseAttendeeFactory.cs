using DigiLearn.Domain.Entities.CourseManagement;
using DigiLearn.Domain.ValueObjects;

namespace DigiLearn.Domain.Factories.CourseManagement;

public interface ICourseAttendeeFactory
{
    CourseAttendee Create(BaseId id, BaseId courseId, BaseId userId);
}
