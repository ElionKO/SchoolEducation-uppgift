using System;

namespace SchoolEdu.Domain;

public enum CourseType { Klassrum, Distans }

public class Course
{
    public string CourseCode { get; set; }
    public string Title { get; set; }
    public int DurationWeeks { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public CourseType Type { get; set; }

    public override string ToString()
    {
        return $"{Title} ({CourseCode}), {Type}, {DurationWeeks} veckor, {StartDate:d} - {EndDate:d}";
    }
}

