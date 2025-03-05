using DigiLearn.Domain.ValueObjects;
using DigiLearn.Shared.Abstraction.Commands;

namespace DigiLearn.Application.Commands.User;

public record UpdateUser(BaseId id, Username userName, Password password, Email email, bool isConfirmed) : ICommand;

