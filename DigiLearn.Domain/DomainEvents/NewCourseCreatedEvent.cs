using DigiLearn.Domain.Entities.CourseManagement;
using DigiLearn.Shared.Abstraction.Domain;

namespace DigiLearn.Domain.DomainEvents;

public record NewCourseCreatedEvent(Course course) : IDomanEvent;
