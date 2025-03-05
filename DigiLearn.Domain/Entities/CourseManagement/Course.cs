using DigiLearn.Domain.DomainEvents;
using DigiLearn.Domain.Exceptions.CourseManagementExceptions;
using DigiLearn.Domain.Primitives;
using DigiLearn.Domain.ValueObjects;
using DigiLearn.Shared.Abstraction.Domain;

namespace DigiLearn.Domain.Entities.CourseManagement;

public class Course : AggregateRoot<BaseId>
{
    private Title _title;
    private Description _description;
    private bool _isFree;
    private Price _price;
    private BaseId _instructorId;
    private LinkedList<CourseAttendee> _courseAttendees;
    private LinkedList<CourseCatalog> _courseCatalogs;

    internal Course(BaseId id, Title title, Description description, bool isFree, Price price, BaseId instructorId)
    {
        Id = id;
        _title = title;
        _description = description;
        _isFree = isFree;
        _price = price;
        _instructorId = instructorId;
        RaiseDomainEvent(new NewCourseCreatedEvent(this));
    }

    public Course()
    {

    }

    #region Course Attendees Activities
    public void AddCourseAttendee(CourseAttendee courseAttendee)
    {
        var attendeeExists = _courseAttendees.Any(a => a.Id == courseAttendee.Id);
        if (attendeeExists)
        {
            throw new CourseAttendeeAlreadyExistsException();
        }

        _courseAttendees.AddLast(courseAttendee);
        RaiseDomainEvent(new CourseAttendeeAddedEvent(this, courseAttendee));
    }

    public void RemoveCourseAttendee(BaseId id)
    {
        var attendee = GetAttendee(id);
        _courseAttendees.Remove(attendee);
    }

    private CourseAttendee GetAttendee(BaseId id)
    {
        var attendee = _courseAttendees.SingleOrDefault(a => a.Id == id);

        if (attendee == null)
        {
            throw new CourseAttendeeNotFoundException();
        }

        return attendee;
    }

    #endregion

    #region Course Catalog Activitiess
    public void AddCourseCatalog(CourseCatalog courseCatalog)
    {
        var catalogExists = _courseAttendees.Any(c => c.Id == courseCatalog.Id);
        if (catalogExists)
        {
            throw new CourseCatalogAlreadyExistsException();
        }

        _courseCatalogs.AddLast(courseCatalog);
    }

    public void RemoveCourseCatalog(BaseId id)
    {
        var catalog = GetCourseCatalog(id);
        _courseCatalogs.Remove(catalog);
    }

    private CourseCatalog GetCourseCatalog(BaseId id)
    {
        var catalog = _courseCatalogs.SingleOrDefault(c => c.Id == id);

        if (catalog == null)
        {
            throw new CourseCatalogNotFoundException();
        }

        return catalog;
    }

    #endregion

}