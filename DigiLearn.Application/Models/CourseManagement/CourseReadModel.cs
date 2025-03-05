using DigiLearn.Application.Models.PaymentManagement;

namespace DigiLearn.Application.Models.CourseManagement;

public class CourseReadModel : BaseReadModel
{
    public string Title { get; set; }
    public string Description { get; set; }
    public bool IsFree { get; set; }
    public decimal Price { get; set; }
    public Guid InstructorId { get; set; }
    public InstructorReadModel Instructor { get; set; }
    public IReadOnlyList<CourseAttendeReadModel> CourseAttendees { get; set; }
    public IReadOnlyList<CourseCatalogReadModel> CourseCatalogs { get; set; }
    public IReadOnlyList<InvoiceReadModel> Invoices { get; set; }
}
