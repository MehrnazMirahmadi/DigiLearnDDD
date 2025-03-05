using DigiLearn.Application.DTOs;
using DigiLearn.Application.Services;
using DigiLearn.Shared.Abstraction.Queries;

namespace DigiLearn.Application.Queries.Course.Handlers;

public class GetCourseByIdHandler : IQueryHandler<GetCourseById, CourseDto>
{

    private readonly ICourseReadModelService _readService;

    public GetCourseByIdHandler(ICourseReadModelService readService)
    {
        _readService = readService;
    }

    public async Task<CourseDto> HandleAsync(GetCourseById query)
    {
        return (await _readService
            .GetCourseById(query.CourseId))
            .ToDto();
    }
}
