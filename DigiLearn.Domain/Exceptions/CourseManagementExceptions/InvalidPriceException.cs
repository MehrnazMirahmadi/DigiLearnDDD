using DigiLearn.Shared.Abstraction.Exceptions;

namespace DigiLearn.Domain.Exceptions.CourseManagementExceptions
{
    internal class InvalidPriceException :CourseManagementException
    {
        public InvalidPriceException() : base("Price Can not be Negative...!")
        {

        }
    }

}
