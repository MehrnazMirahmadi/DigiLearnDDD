using DigiLearn.Shared.Abstraction.Exceptions;

public class CourseAttendeeNotFoundException : CourseManagementException
{
    public CourseAttendeeNotFoundException() : base("Course Attendee Not Found...!")
    {
    }
}