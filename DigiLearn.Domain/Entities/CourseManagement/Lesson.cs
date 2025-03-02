using DigiLearn.Domain.Primitives;
using DigiLearn.Domain.ValueObjects;

namespace DigiLearn.Domain.Entities.CourseManagement;

public class Lesson : BaseEntity
{
    private Title _title;
    private VideoUrl _videoUrl;
    private BaseId _courseCatalogId;

    public Lesson(BaseId id, Title title, VideoUrl videoUrl, BaseId courseCatalogId) : base(id)
    {
        _title = title;
        _videoUrl = videoUrl;
        _courseCatalogId = courseCatalogId;
    }

    public Lesson(BaseId id) : base(id)
    {

    }
}
