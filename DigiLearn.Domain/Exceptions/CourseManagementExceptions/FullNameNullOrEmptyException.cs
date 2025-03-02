using DigiLearn.Shared.Abstraction.Exceptions;

namespace DigiLearn.Domain.Exceptions.CourseManagementExceptions;

internal class FullNameNullOrEmptyException : CourseManagementException
{
    public FullNameNullOrEmptyException() : base("Full Name Can Not Be Empty...!")
    {
    }
}

