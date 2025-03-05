using DigiLearn.Application.Exceptions;
using DigiLearn.Domain.Factories.UserManagement;
using DigiLearn.Domain.Repositories.UserManagement;
using DigiLearn.Shared.Abstraction.Commands;

namespace DigiLearn.Application.Commands.User.Handlers;

public class UpdateUserHandler : ICommandHandler<UpdateUser>
{
    private readonly IUserRepository _repository;
    private readonly IUserFactory _factory;

    public UpdateUserHandler(IUserRepository repository, IUserFactory factory)
    {
        _repository = repository;
        _factory = factory;
    }

    public async Task HandleAsync(UpdateUser command)
    {
        var user = await _repository.GetAsync(command.id);
        if (user == null)
        {
            throw new UserNotFoundException();
        }
        user = _factory.Create(user.Id, command.userName, command.password, command.email, command.isConfirmed);
        await _repository.UpdateAsync(user);
    }
}

