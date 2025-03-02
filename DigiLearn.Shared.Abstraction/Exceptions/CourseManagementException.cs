namespace DigiLearn.Shared.Abstraction.Exceptions;

public abstract class CourseManagementException : Exception
{
    protected CourseManagementException(string message) : base(message)
    {
            
    }
}
