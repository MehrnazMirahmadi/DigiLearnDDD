using DigiLearn.Domain.Primitives;
using DigiLearn.Domain.ValueObjects;

namespace DigiLearn.Domain.Entities.CourseManagement;

public class CourseAttendee : BaseEntity
{
    private BaseId _courseId;
    private BaseId _userId;
    internal CourseAttendee(BaseId id, BaseId courseId, BaseId userId) : base(id)
    {
        _courseId = courseId;
        _userId = userId;
    }
    public CourseAttendee(BaseId id) : base(id)
    {
    }
}
