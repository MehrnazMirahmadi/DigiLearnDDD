using DigiLearn.Shared.Abstraction.Exceptions;

namespace DigiLearn.Domain.Exceptions.CourseManagementExceptions;

public class InvalidInstructorRatingException : CourseManagementException
{
    public InvalidInstructorRatingException() : base("Instructor Rating Could not be Negative...!")
    {
    }
}