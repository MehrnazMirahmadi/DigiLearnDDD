using DigiLearn.Application.DTOs;
using DigiLearn.Shared.Abstraction.Queries;

namespace DigiLearn.Application.Queries.Course;

public class GetCourseById : IQuery<CourseDto>
{
    public Guid CourseId { get; set; }
}
