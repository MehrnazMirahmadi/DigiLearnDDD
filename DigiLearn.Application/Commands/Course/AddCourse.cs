using DigiLearn.Shared.Abstraction.Commands;

namespace DigiLearn.Application.Commands.Course;

public record AddCourse(Guid id, string title, string description, bool isFree, decimal price, Guid instructorId) : ICommand;

