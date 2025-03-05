using DigiLearn.Domain.Entities.CourseManagement;
using DigiLearn.Domain.ValueObjects;

namespace DigiLearn.Domain.Factories.CourseManagement;

public interface IInstructorFactory
{
    Instructor CreateWithoutExperienceAndRating(BaseId id, FullName fullName, Biography bio);
    Instructor CreateWithExperienceAndWithoutRating(BaseId id, FullName fullName, Biography bio, int experience);
    Instructor CreateWithExperienceAndRating(BaseId id, FullName fullName, Biography bio, int experience, double rating);
}
