using DigiLearn.Shared.Abstraction.Exceptions;

namespace DigiLearn.Domain.Exceptions.CourseManagementExceptions;

internal class BiographyNullOrEmptyException: CourseManagementException
{
    public BiographyNullOrEmptyException() : base("Biography Can Not be Empty...!")
    {
    }
}


