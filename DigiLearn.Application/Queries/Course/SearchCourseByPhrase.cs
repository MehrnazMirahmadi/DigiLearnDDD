using DigiLearn.Application.DTOs;
using DigiLearn.Shared.Abstraction.Queries;

namespace DigiLearn.Application.Queries.Course;

public class SearchCourseByPhrase : IQuery<IEnumerable<CourseDto>>
{
    public string SearchPhrase { get; set; }
}