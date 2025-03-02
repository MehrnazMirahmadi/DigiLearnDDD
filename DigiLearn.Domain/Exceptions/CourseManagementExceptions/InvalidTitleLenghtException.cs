using DigiLearn.Shared.Abstraction.Exceptions;

namespace DigiLearn.Domain.Exceptions.CourseManagementExceptions;

internal class InvalidTitleLenghtException : CourseManagementException
{
    public InvalidTitleLenghtException(int validLenght) : base($"Title Can not be More Than {validLenght} Characters")
    {
    }
}
