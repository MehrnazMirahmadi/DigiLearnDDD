using DigiLearn.Application.Exceptions;
using DigiLearn.Domain.Factories.CourseManagement;
using DigiLearn.Domain.Repositories.CourseManagement;
using DigiLearn.Shared.Abstraction.Commands;

namespace DigiLearn.Application.Commands.Course.Handlers;

public class UpdateCourseHandler : ICommandHandler<UpdateCourse>
{
    private readonly ICourseRepository _repository;
    private readonly ICourseFactory _factory;

    public UpdateCourseHandler(ICourseRepository repository, ICourseFactory factory)
    {
        _repository = repository;
        _factory = factory;
    }

    public async Task HandleAsync(UpdateCourse command)
    {
        var course = await _repository.GetAsync(command.id);
        if (course == null)
        {
            throw new CourseNotFoundException();
        }

        course = _factory.Create(course.Id, command.title, command.description, command.isFree, command.price, command.instructorId);
    }
}
