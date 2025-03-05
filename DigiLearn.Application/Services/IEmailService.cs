using DigiLearn.Domain.Entities.CourseManagement;
using DigiLearn.Domain.Entities.UserManagement;

namespace DigiLearn.Application.Services;

public interface IEmailService
{
    Task SendWelcomeEmailToUser(User user);
    Task SendNewCourseAdvertise(Course course);
}

