using DigiLearn.Shared.Abstraction.Exceptions;

namespace DigiLearn.Domain.Exceptions.CourseManagementExceptions
{
    internal class VideoUrlNullOrEmptyException : CourseManagementException
    {
        public VideoUrlNullOrEmptyException() : base("Video Name Can Not be Empty...!")
        {
        }
    }
}
