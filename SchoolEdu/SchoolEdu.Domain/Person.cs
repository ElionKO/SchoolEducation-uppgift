using System;

namespace SchoolEdu.Domain;

public abstract class Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Phone { get; set; }
    public string PersonalId { get; set; }
    public string Address { get; set; }
    public string ZipCode { get; set; }
    public string City { get; set; }

    public override string ToString()
    {
        return $"{FirstName} {LastName}, Ort: {City}";
    }
}
