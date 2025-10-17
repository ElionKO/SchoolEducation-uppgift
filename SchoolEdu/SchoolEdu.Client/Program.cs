using SchoolEdu.Client;
using SchoolEdu.Domain;

namespace SchoolEdu.Client;

class Program
{
    static List<Course> kurser = new();
    static List<Student> studenter = new();
    static List<Teacher> larare = new();
    static List<Supervisor> handledare = new();
    static List<Administrator> administratorer = new();

    static void Main(string[] args)
    {
        bool kör = true;

        while (kör)
        {
            Console.WriteLine("\n--- MENY ---");
            Console.WriteLine("1. Lägg till kurs");
            Console.WriteLine("2. Lägg till student");
            Console.WriteLine("3. Lägg till lärare");
            Console.WriteLine("4. Lägg till handledare");
            Console.WriteLine("5. Lägg till administratör");
            Console.WriteLine("6. Lista kurser");
            Console.WriteLine("7. Lista studenter");
            Console.WriteLine("8. Lista lärare");
            Console.WriteLine("9. Lista handledare");
            Console.WriteLine("10. Lista administratörer");
            Console.WriteLine("11. Koppla student till kurs");
            Console.WriteLine("0. Avsluta");
            Console.Write("Välj: ");

            string val = Console.ReadLine();
            Console.WriteLine();

            switch (val)
            {
                case "1": LäggTillKurs(); break;
                case "2": LäggTillStudent(); break;
                case "3": LäggTillLärare(); break;
                case "4": LäggTillHandledare(); break;
                case "5": LäggTillAdmin(); break;
                case "6": ListaKurser(); break;
                case "7": ListaStudenter(); break;
                case "8": ListaLärare(); break;
                case "9": ListaHandledare(); break;
                case "10": ListaAdmin(); break;
                case "11": KopplaStudentTillKurs(); break;
                case "0": kör = false; break;
                default: Console.WriteLine("Ogiltigt val, försök igen!"); break;
            }
        }
    }

    // Metoder för att lägga till objekt
    static void LäggTillKurs()
    {
        Console.Write("Kurskod: ");
        string code = Console.ReadLine();
        Console.Write("Titel: ");
        string title = Console.ReadLine();
        Console.Write("Längd i veckor: ");
        int weeks = int.Parse(Console.ReadLine());
        Console.Write("Startdatum (yyyy-mm-dd): ");
        DateTime start = DateTime.Parse(Console.ReadLine());
        Console.Write("Slutdatum (yyyy-mm-dd): ");
        DateTime end = DateTime.Parse(Console.ReadLine());
        Console.Write("Typ (0 = Klassrum, 1 = Distans): ");
        CourseType type = (CourseType)int.Parse(Console.ReadLine());

        kurser.Add(new Course { CourseCode = code, Title = title, DurationWeeks = weeks, StartDate = start, EndDate = end, Type = type });
    }

    static void LäggTillStudent()
    {
        Student s = new Student();
        FyllIGrundPersonInfo(s);
        studenter.Add(s);
    }

    static void LäggTillLärare()
    {
        Teacher t = new Teacher();
        FyllIGrundPersonInfo(t);
        Console.Write("Kunskapsområde: ");
        t.Expertise = Console.ReadLine();
        larare.Add(t);
    }

    static void LäggTillHandledare()
    {
        Supervisor h = new Supervisor();
        FyllIGrundPersonInfo(h);
        Console.Write("Kunskapsområde: ");
        h.Expertise = Console.ReadLine();
        Console.Write("Anställningsdatum (yyyy-mm-dd): ");
        h.EmploymentDate = DateTime.Parse(Console.ReadLine());
        handledare.Add(h);
    }

    static void LäggTillAdmin()
    {
        Administrator a = new Administrator();
        FyllIGrundPersonInfo(a);
        Console.Write("Kunskapsområde: ");
        a.Expertise = Console.ReadLine();
        Console.Write("Anställningsdatum (yyyy-mm-dd): ");
        a.EmploymentDate = DateTime.Parse(Console.ReadLine());
        administratorer.Add(a);
    }

    // Listmetoder
    static void ListaKurser()
    {
        Console.WriteLine("--- Kurser ---");
        foreach (var k in kurser) Console.WriteLine(k);
    }

    static void ListaStudenter()
    {
        Console.WriteLine("--- Studenter ---");
        foreach (var s in studenter) Console.WriteLine(s);
    }

    static void ListaLärare()
    {
        Console.WriteLine("--- Lärare ---");
        foreach (var l in larare) Console.WriteLine(l);
    }

    static void ListaHandledare()
    {
        Console.WriteLine("--- Handledare ---");
        foreach (var h in handledare) Console.WriteLine(h);
    }

    static void ListaAdmin()
    {
        Console.WriteLine("--- Administratörer ---");
        foreach (var a in administratorer) Console.WriteLine(a);
    }

    //  Koppla student till kurs 
    static void KopplaStudentTillKurs()
    {
        if (studenter.Count == 0 || kurser.Count == 0)
        {
            Console.WriteLine("Det finns inga studenter eller kurser att koppla.");
            return;
        }

        Console.WriteLine("Välj student:");
        for (int i = 0; i < studenter.Count; i++)
            Console.WriteLine($"{i}: {studenter[i]}");

        int studentIndex = int.Parse(Console.ReadLine());

        Console.WriteLine("Välj kurs:");
        for (int i = 0; i < kurser.Count; i++)
            Console.WriteLine($"{i}: {kurser[i]}");

        int kursIndex = int.Parse(Console.ReadLine());

        studenter[studentIndex].EnrollInCourse(kurser[kursIndex]);
        Console.WriteLine("Studenten är nu kopplad till kursen!");
    }

    // Hjälpmetod för att fylla i Person-info 
    static void FyllIGrundPersonInfo(Person p)
    {
        Console.Write("Förnamn: ");
        p.FirstName = Console.ReadLine();
        Console.Write("Efternamn: ");
        p.LastName = Console.ReadLine();
        Console.Write("Telefon: ");
        p.Phone = Console.ReadLine();
        Console.Write("Personnummer: ");
        p.PersonalId = Console.ReadLine();
        Console.Write("Adress: ");
        p.Address = Console.ReadLine();
        Console.Write("Postnummer: ");
        p.ZipCode = Console.ReadLine();
        Console.Write("Ort: ");
        p.City = Console.ReadLine();
    }
}
