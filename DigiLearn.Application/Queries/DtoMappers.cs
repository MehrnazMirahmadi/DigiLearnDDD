using DigiLearn.Application.DTOs;
using DigiLearn.Application.Models.CourseManagement;
using DigiLearn.Application.Models.UserManagement;

namespace DigiLearn.Application.Queries;

internal static class DtoMappers
{
    public static UserDto ToDto(this UserReadModel user)
    {
        return new UserDto
        {
            Id = user.Id,
            Email = user.Email,
            IsConfirmed = user.IsConfirmed,
            Password = user.Password,
            UserName = user.Username
        };
    }

    public static CourseDto ToDto(this CourseReadModel course)
    {
        return new CourseDto
        {
            Id = course.Id,
            Title = course.Title,
            Description = course.Description,
            InstructorId = course.InstructorId,
            IsFree = course.IsFree,
            Price = course.Price
        };
    }
}
