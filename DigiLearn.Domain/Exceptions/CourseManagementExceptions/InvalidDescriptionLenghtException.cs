using DigiLearn.Shared.Abstraction.Exceptions;

namespace DigiLearn.Domain.Exceptions.CourseManagementExceptions;

internal class InvalidDescriptionLenghtException : CourseManagementException
{
    public InvalidDescriptionLenghtException(int validLenght) : base($"Description Can Not be More Than {validLenght} Characters")
    {
    }
}