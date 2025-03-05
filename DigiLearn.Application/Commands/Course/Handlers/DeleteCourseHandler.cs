using DigiLearn.Application.Exceptions;
using DigiLearn.Domain.Repositories.CourseManagement;
using DigiLearn.Shared.Abstraction.Commands;

namespace DigiLearn.Application.Commands.Course.Handlers;

public class DeleteCourseHandler : ICommandHandler<DeleteCourse>
{
    private readonly ICourseRepository _repository;

    public DeleteCourseHandler(ICourseRepository repository)
    {
        _repository = repository;
    }

    public async Task HandleAsync(DeleteCourse command)
    {
        var course = await _repository.GetAsync(command.id);
        if (course == null)
        {
            throw new CourseNotFoundException();
        }

        await _repository.RemoveAsync(course);
    }
}
