using DigiLearn.Domain.Primitives;
using DigiLearn.Domain.ValueObjects;

namespace DigiLearn.Domain.Entities.CourseManagement;

public class Instructor : BaseEntity
{
    private FullName _fullName;
    private Biography _bio;
    private LinkedList<Course> _courses;

    public Instructor(BaseId id, FullName fullName, Biography bio) : base(id)
    {
        _fullName = fullName;
        _bio = bio;
    }

    public Instructor(BaseId id) : base(id)
    {

    }
}
