namespace OOP_assignment_2;

public class User : IRegistration
{
    private string _name1;
    private int _registrationNo1;
    private string _licenseType1;

    public string Name
    {
        get => _name1;
        set => _name1 = value;
    }

    public int RegistrationNo
    {
        get => _registrationNo1;
        set => _registrationNo1 = value;
    }

    public string LicenseType
    {
        get => _licenseType1;
        set => _licenseType1 = value;
    }
    
    public void Register(string name)
    {
        Console.WriteLine();
        Printing.PrintT("Nice to meet you ",'b',1);
        Printing.PrintT(name,'g',1);
        Printing.PrintT(".",'g',1);
        Console.WriteLine();
        Printing.PrintT("You're now registered as a user, enjoy your experience.", 'b', 0);
        Console.WriteLine();
        Printing.PrintT("Press Enter to continue.", 'g', 0);
        Console.ReadLine();

    }

    protected virtual void Message()
    {
        User user = new User();
        Printing.PrintT("Please register your name: ", 'g', 0);
        user.Name = Console.ReadLine();
        user.LicenseType = "Student";
        user.Register(user.Name);
        Test.UserName = user.Name;
    }
    public static void EnterDetails()
    {
        Printing.PrintT("Welcome to the Math Tutor, please enter your details.", 'b', 0);
        Console.WriteLine();
        Printing.PrintT("Are you a student user or professional user?", 'b', 0);
        Console.WriteLine();
        Printing.PrintT("1: Student.", 'g', 0);
        Printing.PrintT("2: Professional.", 'g', 0);
        Printing.PrintT("3: Tester - Temporary test user.", 'r', 0);
        Console.WriteLine();
        Printing.PrintT("4: Exit.", 'r', 0);

       

        string License = Console.ReadLine();
        
        List<string> Check = new List<string>()
        {
            "1","2","3","4"
        };

        if (!Check.Contains(License))
        {
            Printing.PrintT("Enter Valid Option!",'r',0);
            Console.WriteLine();
            EnterDetails();
        }
        

        if (License == "1") 
        {
            Student student = new Student();
            student.Message();
        }

        if (License == "2")
        {
            Professional professional = new Professional();
            professional.Message();
        }
        
        if (License == "3")
        {
            Tester tester = new Tester();
            tester.Message();
        }
        if (License == "4")
        {
            Console.WriteLine();
            Printing.PrintT("See ya Maths Wizard.",'r',0);
            Environment.Exit(0);
        }
    }
}

    interface IRegistration
    {
       protected void Register(string Name);
    }

    public class Professional : User, IRegistration
    {
        protected override void Message()
        {
            
            Printing.PrintT("Please register your name: ", 'g', 0);
            Name = Console.ReadLine();
            if (string.IsNullOrEmpty(Name))
            {
                Printing.PrintT("Enter Valid name!",'r',0);
                Console.WriteLine();
                Message();
            }
            foreach(char i in Name)
                if(!Char.IsLetter(i) &&  i != ' ' && !Char.IsPunctuation(i))
            {
                Printing.PrintT("No numerical values please!",'r',0);
                Console.WriteLine();
                Message();
            }

            LicenseCheck();
            void LicenseCheck()
            {
                Console.WriteLine();

                List<string> Licenses = File.ReadAllLines("Licenses.txt").ToList();
                Printing.PrintT("List of valid license numbers, printed for testing", 'r', 0);
                foreach (string i in Licenses)
                    Printing.PrintT(i, 'b', 0);
                Console.WriteLine();
                Printing.PrintT("Please insert 8 digit license number: ", 'g', 0);
                string RegistrationNo = Console.ReadLine();

                if (!Licenses.Contains(RegistrationNo))
                {
                    Printing.PrintT("Enter Valid License key!", 'r', 0);
                    LicenseCheck();
                }
                
                LicenseType = "Professional";
                Register(Name);
                Test.UserName = Name;
            }
        }
        private void Register(string name)
        {
            Console.WriteLine();
            Printing.PrintT("Nice to meet you ",'b',1);
            Printing.PrintT(name,'g',1);
            Printing.PrintT(".",'g',0);
            Console.WriteLine();
            Printing.PrintT("You're now registered as a professional user, enjoy your pro license.", 'b', 0);
            Console.WriteLine();
            Printing.PrintT("Press Enter to continue.", 'g', 0);
            Console.ReadLine();
        }
    }
    public class Tester : User
    {
        protected override void Message()
        {
            
            Printing.PrintT("Please register your name: ", 'g', 0);
            Name = Console.ReadLine();
            if (string.IsNullOrEmpty(Name))
            {
                Printing.PrintT("Enter Valid name!",'r',0);
                Console.WriteLine();
                Message();
            }
            foreach(char i in Name)
                if(!Char.IsLetter(i) &&  i != ' ' && !Char.IsPunctuation(i))
                {
                    Printing.PrintT("No numerical values please!",'r',0);
                    Console.WriteLine();
                    Message();
                }
            LicenseType = "Tester";
            Register(Name);
            Test.UserName = Name;
            
        }

        private void Register(string name)
        {
            Console.WriteLine();
            Printing.PrintT("Nice to meet you ",'b',1);
            Printing.PrintT(name,'g',1);
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
        protected override void Message()
        {
            
            Printing.PrintT("Please register your name: ", 'g', 0);
            Name = Console.ReadLine();
            if (string.IsNullOrEmpty(Name))
            {
                Printing.PrintT("Enter Valid name!",'r',0);
                Console.WriteLine();
                Message();
            }

            foreach (char i in Name)
            {
                if (!Char.IsLetter(i) && i != ' ' && !Char.IsPunctuation(i))
                {
                    Printing.PrintT("No numerical values please!", 'r', 0);
                    Console.WriteLine();
                    Message();
                    return;
                }
            }

            LicenseType = "Student";
            Register(Name);
            Test.UserName = Name;
        }

        private void Register(string name)
        {
            Console.WriteLine();
            Printing.PrintT("Nice to meet you ",'b',1);
            Printing.PrintT(name,'g',1);
            Printing.PrintT(".",'g',0);
            Console.WriteLine();
            Printing.PrintT("You're registered as a student user, enjoy your free student license ", 'b', 0);
            Console.WriteLine();
            Printing.PrintT("Press Enter to continue.", 'g', 0);
            Console.ReadLine();
        }
    }

 


