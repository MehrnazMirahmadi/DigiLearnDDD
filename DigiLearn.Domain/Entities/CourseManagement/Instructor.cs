using DigiLearn.Domain.Primitives;
using DigiLearn.Domain.ValueObjects;

namespace DigiLearn.Domain.Entities.CourseManagement;

public class Instructor : BaseEntity
{
    private FullName _fullName;
    private Biography _bio;
    private int _experience;
    private double _rating;
    private LinkedList<Course> _courses;

    internal Instructor(BaseId id, FullName fullName, Biography bio) : base(id)
    {
        _fullName = fullName;
        _bio = bio;
        _experience = 3;
        _rating = 0;
    }

    internal Instructor(BaseId id, FullName fullName, Biography bio, int experience) : base(id)
    {
        _fullName = fullName;
        _bio = bio;
        _experience = experience;
        _rating = 0;
    }

    internal Instructor(BaseId id, FullName fullName, Biography bio, int experience, double rating) : base(id)
    {
        _fullName = fullName;
        _bio = bio;
        _experience = experience;
        _rating = rating;
    }

    public Instructor(BaseId id) : base(id)
    {

    }

    public void UpdateFullName(FullName fullName)
    {
        _fullName = fullName;
    }
}

