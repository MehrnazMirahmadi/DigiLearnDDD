using DigiLearn.Application.Services;
using DigiLearn.Domain.DomainEvents;
using DigiLearn.Shared.Abstraction.Domain;

namespace DigiLearn.Application.DomainEvents;


public class UserRegisteredEventHandler : IDomainEventHandler<UserRegisteredEvent>
{
    private readonly IEmailService _emailService;

    public UserRegisteredEventHandler(IEmailService emailService)
    {
        _emailService = emailService;
    }

    public async Task HandleAsync(UserRegisteredEvent @event)
    {
        await _emailService.SendWelcomeEmailToUser(@event.user);
    }
}