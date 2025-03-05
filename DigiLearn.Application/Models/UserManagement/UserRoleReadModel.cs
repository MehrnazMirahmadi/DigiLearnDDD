namespace DigiLearn.Application.Models.UserManagement;

public class UserRoleReadModel
{
    public Guid UserId { get; set; }
    public UserReadModel User { get; set; }
    public Guid RoleId { get; set; }
    public RoleReadModel Role { get; set; }
}
