using DigiLearn.Shared.Abstraction.Exceptions;

namespace DigiLearn.Domain.Exceptions.CourseManagementExceptions;

public class CourseCatalogAlreadyExistsException : CourseManagementException
{
    public CourseCatalogAlreadyExistsException() : base("Course Catalog Not Found...!")
    {
    }
}
