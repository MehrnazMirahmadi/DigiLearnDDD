using DigiLearn.Domain.Entities.UserManagement;
using DigiLearn.Shared.Abstraction.Domain;

namespace DigiLearn.Domain.DomainEvents;

public record UserRegisteredEvent(User user) : IDomainEvent;
