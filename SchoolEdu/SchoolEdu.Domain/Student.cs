using System;

namespace SchoolEdu.Domain;

public class Student : Person
{
    public List<Course> Courses { get; set; } = new();

    public void EnrollInCourse(Course course)
    {
        Courses.Add(course);
    }

    public override string ToString()
    {
        string courseInfo = Courses.Count > 0
            ? $"Kurser: {string.Join(", ", Courses.ConvertAll(c => c.Title))}"
            : "Inga kurser ännu";

        return base.ToString() + $" | {courseInfo}";
    }
}

