using DigiLearn.Domain.Entities.CourseManagement;
using DigiLearn.Shared.Abstraction.Domain;

namespace DigiLearn.Domain.DomainEvents;

public record CourseAttendeeAddedEvent(Course course, CourseAttendee attendee) : IDomainEvent;
