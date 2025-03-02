using DigiLearn.Shared.Abstraction.Exceptions;

namespace DigiLearn.Domain.Exceptions.CourseManagementExceptions;

internal class InvalidFullNameLenghtException : CourseManagementException
{
    public InvalidFullNameLenghtException(int validLenght) : base($"Full Name Can Not be More Than {validLenght} Characters")
    {
    }
}
