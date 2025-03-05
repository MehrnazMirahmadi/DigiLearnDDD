using DigiLearn.Application.Services;
using DigiLearn.Domain.DomainEvents;
using DigiLearn.Shared.Abstraction.Domain;

namespace DigiLearn.Application.DomainEvents
{
    public class NewCourseCreatedEventHandler : IDomainEventHandler<NewCourseCreatedEvent>
    {
        private readonly IEmailService _emailService;

        public NewCourseCreatedEventHandler(IEmailService emailService)
        {
            _emailService = emailService;
        }

        public async Task HandleAsync(NewCourseCreatedEvent @event)
        {
            await _emailService.SendNewCourseAdvertise(@event.course);
        }
    }

}
