using DigiLearn.Shared.Abstraction.Exceptions;

namespace DigiLearn.Domain.Exceptions.CourseManagementExceptions
{
    internal class TitleNullOrEmptyException : CourseManagementException
    {
        public TitleNullOrEmptyException() : base("Title Can not be Empty...!")
        {
        }
    }

}
