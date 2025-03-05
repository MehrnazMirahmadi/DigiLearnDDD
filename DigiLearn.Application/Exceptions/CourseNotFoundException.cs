using DigiLearn.Shared.Abstraction.Exceptions;

namespace DigiLearn.Application.Exceptions;

public class CourseNotFoundException : CourseManagementException
{
    public CourseNotFoundException() : base("Course Not Found...!")
    {
    }
}
