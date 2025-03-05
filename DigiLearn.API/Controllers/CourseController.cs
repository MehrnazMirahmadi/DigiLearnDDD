using DigiLearn.Application.Commands.Course;
using DigiLearn.Application.DTOs;
using DigiLearn.Application.Queries.Course;
using DigiLearn.Shared.Abstraction.Commands;
using DigiLearn.Shared.Abstraction.Queries;
using Microsoft.AspNetCore.Mvc;

namespace DigiLearn.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CourseController : ControllerBase
{
    private readonly ICommandDispatcher _commandDispatcher;
    private readonly IQueryDispatcher _queryDispatcher;

    public CourseController(ICommandDispatcher commandDispatcher, IQueryDispatcher queryDispatcher)
    {
        _commandDispatcher = commandDispatcher;
        _queryDispatcher = queryDispatcher;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<CourseDto>>> SearchCourseByName([FromQuery] SearchCourseByPhrase query)
    {
        var result = await _queryDispatcher.FetchAsync(query);
        return Ok(result);
    }

    [HttpPost]
    public async Task<IActionResult> CreateCourse([FromBody] AddCourse command)
    {
        await _commandDispatcher.DispatchAsync(command);
        return Ok();
    }
}

