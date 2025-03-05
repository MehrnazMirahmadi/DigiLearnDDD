using DigiLearn.Domain.Entities.CourseManagement;
using DigiLearn.Domain.ValueObjects;

namespace DigiLearn.Domain.Factories.CourseManagement;

public class CourseAttendeeFactory : ICourseAttendeeFactory
{
    public CourseAttendee Create(BaseId id, BaseId courseId, BaseId userId)
    {
        return new CourseAttendee(id, courseId, userId);
    }
}
