namespace OOP_assignment_2;

public class User
{
    private string Name1;
    private int RegistrationNo1;
    private string LicenseType1;

    public string Name
    {
        get => Name1;
        set => Name1 = value;
    }

    public int RegistrationNo
    {
        get => RegistrationNo1;
        set => RegistrationNo1 = value;
    }

    public string LicenseType
    {
        get => LicenseType1;
        set => LicenseType1 = value;
    }
    

    public static void Message()
    {
        Printing.PrintT("Are you a student user or professional user?", 'b', 0);
        Console.WriteLine();
        Printing.PrintT("1: Student.", 'g', 0);
        Printing.PrintT("2: Professional.", 'g', 0);
        Printing.PrintT("3: Tester.", 'g', 0);


        string License = Console.ReadLine();

        if (License == "1")
        {
            Student student = new Student();
            Printing.PrintT("Please register your name: ", 'g', 0);
            student.Name = Console.ReadLine();
            student.LicenseType = "Student";
            student.Register(student.Name);
        }

        if (License == "2")
        {
            Professional professional = new Professional();
            Printing.PrintT("Please register your name: ", 'g', 0);
            professional.Name = Console.ReadLine();
            professional.LicenseType = "Professional";
            Console.WriteLine();
            Printing.PrintT("Please insert license number: ", 'g', 0);
            professional.RegistrationNo = Convert.ToInt32(Console.ReadLine());
            professional.Register(professional.Name);
        }
        
        if (License == "3")
        {
            Tester tester = new Tester();
            Printing.PrintT("Please register your name: ", 'g', 0);
            tester.Name = Console.ReadLine();
            tester.LicenseType = "Professional";
            Console.WriteLine();
            tester.Register(tester.Name);
        }
    }
}

interface IRegistration
    {
        void Register(string Name);
    }

    public class Professional : User, IRegistration
    {
        public void Register(string Name)
        {
            Console.WriteLine();
            Printing.PrintT("Nice to meet you ",'b',1);
            Printing.PrintT(Name,'g',1);
            Printing.PrintT(".",'g',1);
            Console.WriteLine();
            Printing.PrintT("You're now registered as a professional user, enjoy your pro license.", 'b', 0);
            Console.WriteLine();
            Printing.PrintT("Press Enter to continue.", 'g', 0);
            Console.ReadLine();

        }
    }
public class Tester : Professional
{
    public void Register(string Name)
    {
        Console.WriteLine();
        Printing.PrintT("Nice to meet you ",'b',1);
        Printing.PrintT(Name,'g',1);
        Printing.PrintT(".",'g',1);
        Console.WriteLine();
        Printing.PrintT("You're now registered as a tester, thanks for your help.", 'b', 0);
        Console.WriteLine();
        Printing.PrintT("Press Enter to continue.", 'g', 0);
        Console.ReadLine();

    }
}

    public class Student : User, IRegistration
    {
        public void Register(string Name)
        {
            Console.WriteLine();
            Printing.PrintT("Nice to meet you ",'b',1);
            Printing.PrintT(Name,'g',1);
            Printing.PrintT(".",'g',1);
            Console.WriteLine();
            Printing.PrintT("You're registered as a student user, enjoy your free student license ", 'b', 0);
            Console.WriteLine();
            Printing.PrintT("Press Enter to continue.", 'g', 0);
            Console.ReadLine();
        }
    }

 


