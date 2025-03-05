using DigiLearn.Domain.Entities.CourseManagement;
using DigiLearn.Domain.ValueObjects;

namespace DigiLearn.Domain.Factories.CourseManagement;

public interface ICourseFactory
{
    Course Create(BaseId id, Title title, Description description, bool isFree, Price price, BaseId instructorId);
}
