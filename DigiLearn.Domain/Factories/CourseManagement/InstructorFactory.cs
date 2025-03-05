using DigiLearn.Domain.Entities.CourseManagement;
using DigiLearn.Domain.Exceptions.CourseManagementExceptions;
using DigiLearn.Domain.ValueObjects;

namespace DigiLearn.Domain.Factories.CourseManagement;

public class InstructorFactory : IInstructorFactory
{
    public Instructor CreateWithoutExperienceAndRating(BaseId id, FullName fullName, Biography bio)
    {
        return new Instructor(id, fullName, bio);
    }

    public Instructor CreateWithExperienceAndWithoutRating(BaseId id, FullName fullName, Biography bio, int experience)
    {
        if (experience < 3)
        {
            throw new InvalidInstructorExperienceException();
        }

        return new Instructor(id, fullName, bio, experience);
    }

    public Instructor CreateWithExperienceAndRating(BaseId id, FullName fullName, Biography bio, int experience, double rating)
    {
        if (experience < 3)
        {
            throw new InvalidInstructorExperienceException();
        }
        if (rating < 0)
        {
            throw new InvalidInstructorRatingException();
        }

        return new Instructor(id, fullName, bio, experience, rating);
    }

}
