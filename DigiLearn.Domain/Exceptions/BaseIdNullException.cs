using DigiLearn.Shared.Abstraction.Exceptions;

namespace DigiLearn.Domain.Exceptions;

internal class BaseIdNullException : CourseManagementException
{
    public BaseIdNullException() : base("Id Can not be Empty")
    {
    }
}
