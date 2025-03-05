using DigiLearn.Domain.ValueObjects;
using DigiLearn.Shared.Abstraction.Commands;

namespace DigiLearn.Application.Commands.Course;

public record UpdateCourse(BaseId id, Title title, Description description, bool isFree, Price price, BaseId instructorId) : ICommand;
