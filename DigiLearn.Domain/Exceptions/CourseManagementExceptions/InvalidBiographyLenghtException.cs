using DigiLearn.Shared.Abstraction.Exceptions;

namespace DigiLearn.Domain.Exceptions.CourseManagementExceptions;

internal class InvalidBiographyLenghtException : CourseManagementException
{
    public InvalidBiographyLenghtException() : base("Biography Can Not be More Than 300 Characters")
    {
    }
}
