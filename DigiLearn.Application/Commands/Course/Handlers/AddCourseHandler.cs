using DigiLearn.Application.Exceptions;
using DigiLearn.Application.Services;
using DigiLearn.Domain.Factories.CourseManagement;
using DigiLearn.Domain.Repositories.CourseManagement;
using DigiLearn.Shared.Abstraction.Commands;

namespace DigiLearn.Application.Commands.Course.Handlers;

public class AddCourseHandler : ICommandHandler<AddCourse>
{
    private readonly ICourseRepository _repository;
    private readonly ICourseFactory _factory;
    private readonly ICourseReadModelService _readService;

    public AddCourseHandler(ICourseRepository repository, ICourseFactory factory, ICourseReadModelService readService)
    {
        _repository = repository;
        _factory = factory;
        _readService = readService;
    }

    public async Task HandleAsync(AddCourse command)
    {
        if (await _readService.IsCourseExistsByName(command.title))
        {
            throw new CourseWithInputNameExistsException();
        }
        var course = _factory.Create(command.id, command.title, command.description, command.isFree, command.price, command.instructorId);
        await _repository.AddAsync(course);
    }
}
