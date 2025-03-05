using DigiLearn.Domain.ValueObjects;
using DigiLearn.Shared.Abstraction.Commands;

namespace DigiLearn.Application.Commands.User;

public record DeleteUser(BaseId Id) : ICommand;

