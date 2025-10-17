using System;

namespace SchoolEdu.Domain;

public class Supervisor : Teacher
{
    public DateTime EmploymentDate { get; set; }

    public override string ToString()
    {
        return base.ToString() + $", Anställningsdatum: {EmploymentDate:d} (Handledare)";
    }
}

