using DigiLearn.Shared.Abstraction.Commands;

namespace DigiLearn.Application.Commands.User;
public record AddUser(Guid id, string userName, string password, string email, bool isConfirmed) : ICommand;

