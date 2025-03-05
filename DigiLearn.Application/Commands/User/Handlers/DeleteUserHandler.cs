using DigiLearn.Application.Exceptions;
using DigiLearn.Domain.Repositories.UserManagement;
using DigiLearn.Shared.Abstraction.Commands;

namespace DigiLearn.Application.Commands.User.Handlers;

public class DeleteUserHandler : ICommandHandler<DeleteUser>
{
    private readonly IUserRepository _repository;

    public DeleteUserHandler(IUserRepository repository)
    {
        _repository = repository;
    }

    public async Task HandleAsync(DeleteUser command)
    {
        var user = await _repository.GetAsync(command.Id);
        if (user == null)
        {
            throw new UserNotFoundException();
        }

        await _repository.RemoveAsync(user);
    }
}
