using DigiLearn.Application.Services;
using DigiLearn.Domain.Entities.CourseManagement;
using DigiLearn.Domain.Entities.UserManagement;

namespace DigiLearn.Infrastructure.Services;

public class EmailService : IEmailService
{

    public Task SendNewCourseAdvertise(Course course)
    {
        return Task.CompletedTask;
    }

    public Task SendWelcomeEmailToUser(User user)
    {
        return Task.CompletedTask;
    }
}
