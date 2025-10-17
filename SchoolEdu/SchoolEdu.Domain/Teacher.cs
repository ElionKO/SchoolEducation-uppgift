using System;

namespace SchoolEdu.Domain;

using System.Collections.Generic;

public class Teacher : Person
{
    public string Expertise { get; set; }
    public List<Course> ResponsibleCourses { get; set; } = new();

    public override string ToString()
    {
        return base.ToString() + $", Kunskapsområde: {Expertise}";
    }
}

