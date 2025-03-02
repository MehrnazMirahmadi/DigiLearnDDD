using DigiLearn.Shared.Abstraction.Exceptions;

namespace DigiLearn.Domain.Exceptions.CourseManagementExceptions;

internal class DescriptionNullOrEmptyException : CourseManagementException
{
    public DescriptionNullOrEmptyException() : base("Description Can not be Null Or Empty..!")
    {
    }
}