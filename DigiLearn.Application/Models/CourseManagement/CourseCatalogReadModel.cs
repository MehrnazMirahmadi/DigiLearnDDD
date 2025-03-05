namespace DigiLearn.Application.Models.CourseManagement;

public class CourseCatalogReadModel : BaseReadModel
{
    public string Title { get; set; }
    public string Description { get; set; }
    public Guid CourseId { get; set; }
    public CourseReadModel Course { get; set; }
    public IReadOnlyList<LessonReadModel> Lessons { get; set; }
}
