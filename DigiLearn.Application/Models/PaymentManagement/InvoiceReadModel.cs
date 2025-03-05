using DigiLearn.Application.Models.CourseManagement;
using DigiLearn.Application.Models.UserManagement;

namespace DigiLearn.Application.Models.PaymentManagement;
public class InvoiceReadModel : BaseReadModel
{
    public decimal Amount { get; set; }
    public DateTime Date { get; set; }
    public Guid UserId { get; set; }
    public UserReadModel User { get; set; }
    public Guid CourseId { get; set; }
    public CourseReadModel Course { get; set; }
}



