using DigiLearn.Shared.Abstraction.Exceptions;

namespace DigiLearn.Application.Exceptions;

public class CourseWithInputNameExistsException : CourseManagementException
{
    public CourseWithInputNameExistsException() : base("Course With Input Name Exists...!")
    {
    }
}
