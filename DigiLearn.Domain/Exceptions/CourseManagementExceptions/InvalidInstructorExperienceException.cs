using DigiLearn.Shared.Abstraction.Exceptions;

namespace DigiLearn.Domain.Exceptions.CourseManagementExceptions;

public class InvalidInstructorExperienceException : CourseManagementException
{
    public InvalidInstructorExperienceException() : base("Experience Could Not be Less Than 3 Years..!")
    {
    }
}
