using DigiLearn.Shared.Abstraction.Exceptions;

namespace DigiLearn.Domain.Exceptions.CourseManagementExceptions;

internal class InvalidVideoExtensionException : CourseManagementException
{
    public InvalidVideoExtensionException() : base("Only .mp4 is Valid Extension For Videos...")
    {
    }
}