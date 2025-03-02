﻿using DigiLearn.Domain.Primitives;
using DigiLearn.Domain.ValueObjects;

namespace DigiLearn.Domain.Entities.CourseManagement;

public class CourseCatalog : BaseEntity
{
    private Title _title;
    private Description _description;
    private BaseId _courseId;
    private LinkedList<Lesson> _lessons;


    internal CourseCatalog(BaseId id, Title title, Description description, BaseId courseId) : base(id)
    {
        _title = title;
        _description = description;
        _courseId = courseId;
    }
    public CourseCatalog(BaseId id) : base(id)
    {
    }
}
