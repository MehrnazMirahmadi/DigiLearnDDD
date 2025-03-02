using DigiLearn.Shared.Abstraction.Exceptions;

namespace DigiLearn.Domain.Exceptions.CourseManagementExceptions
{
    public class CourseCatalogNotFoundException : CourseManagementException
    {
        public CourseCatalogNotFoundException() : base("Course Catalog Not Found...!")
        {
        }
    }
}
