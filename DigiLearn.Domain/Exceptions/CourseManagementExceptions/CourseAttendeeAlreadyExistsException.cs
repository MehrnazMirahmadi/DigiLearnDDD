using DigiLearn.Shared.Abstraction.Exceptions;

namespace DigiLearn.Domain.Exceptions.CourseManagementExceptions;

public class CourseAttendeeAlreadyExistsException : CourseManagementException
{
    public CourseAttendeeAlreadyExistsException() : base("Course Attendee Already Exists...!")
    {
    }
}
