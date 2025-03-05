using DigiLearn.Application.Models.UserManagement;

namespace DigiLearn.Application.Models.CourseManagement;
public class CourseAttendeReadModel : BaseReadModel
{
    public Guid UserId { get; set; }
    public UserReadModel User { get; set; }

    public Guid CourseId { get; set; }
    public CourseReadModel Course { get; set; }
}
