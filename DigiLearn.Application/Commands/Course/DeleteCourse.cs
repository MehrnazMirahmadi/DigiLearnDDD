using DigiLearn.Domain.ValueObjects;
using DigiLearn.Shared.Abstraction.Commands;

namespace DigiLearn.Application.Commands.Course;

public record DeleteCourse(BaseId id) : ICommand;
