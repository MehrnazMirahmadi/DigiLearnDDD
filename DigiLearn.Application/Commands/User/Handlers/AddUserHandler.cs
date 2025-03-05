using DigiLearn.Application.Exceptions;
using DigiLearn.Application.Services;
using DigiLearn.Domain.Factories.UserManagement;
using DigiLearn.Domain.Repositories.UserManagement;
using DigiLearn.Shared.Abstraction.Commands;

namespace DigiLearn.Application.Commands.User.Handlers;

public class AddUserHandler : ICommandHandler<AddUser>
{
    private readonly IUserRepository _repository;
    private readonly IUserFactory _factory;
    private readonly IUserReadModelService _readService;

    public AddUserHandler(IUserRepository repository, IUserFactory factory, IUserReadModelService readService)
    {
        _repository = repository;
        _factory = factory;
        _readService = readService;
    }


    public async Task HandleAsync(AddUser command)
    {
        if (await _readService.IsUserExistsByEmail(command.email))
        {
            throw new UserWithInputEmailExistsException();
        }
        var user = _factory.Create(command.id, command.userName, command.password, command.email, command.isConfirmed);
        await _repository.AddAsync(user);
    }
}
