using DigiLearn.Application.Models.CourseManagement;
using DigiLearn.Application.Models.PaymentManagement;

namespace DigiLearn.Application.Models.UserManagement;

public class UserReadModel : BaseReadModel
{
    public string Username { get; set; }
    public string Password { get; set; }
    public string Email { get; set; }
    public bool IsConfirmed { get; set; }
    public IReadOnlyList<CourseAttendeReadModel> CourseAttendes { get; set; }
    public IReadOnlyList<UserRoleReadModel> UserRoles { get; set; }
    public IReadOnlyList<InvoiceReadModel> Invoices { get; set; }
}
