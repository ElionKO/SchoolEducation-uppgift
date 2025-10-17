using System;

namespace SchoolEdu.Domain;

public class Administrator : Supervisor
{
    public override string ToString()
    {
        return base.ToString() + " (Administratör)";
    }
}

