namespace OOP_assignment_2;
//Class responsible for User registration and options.
public class User : IRegistration
{                                       //Encapsulated variables are constructed when generating a user. These have gets and sets setup.
    private string _name1;
    private int _registrationNo1;
    private string _licenseType1;

    public string Name          //Variables for User Name, User license and License number.
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
    
    public void Register(string name)  //Method responsible for a few messages when registration of user is finished. this method is inherited by child classes below and overridden
    {                                  // to reflect differences between user types.
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

    protected virtual void Message() // Virtual method to be used by classes, it assigns name license type and also Name variable in Test class.
    {
        User user = new User();
        Printing.PrintT("Please register your name: ", 'g', 0);
        user.Name = Console.ReadLine();
        user.LicenseType = "Default";
        user.Register(user.Name);
        Test.UserName = user.Name;
    }
    public static void EnterDetails()  //Initial Greeting and credentials entry method.
    {
        Printing.PrintT("Welcome to the Math Tutor, please enter your details.", 'b', 0);
        Console.WriteLine();
        Printing.PrintT("Are you a student user or professional user?", 'b', 0); //Many options for user types and option to exit program.
        Console.WriteLine();
        Printing.PrintT("1: Student.", 'g', 0);
        Printing.PrintT("2: Professional.", 'g', 0);
        Printing.PrintT("3: Tester - Temporary test user.", 'r', 0);
        Console.WriteLine();
        Printing.PrintT("4: Exit.", 'r', 0);

       

        string License = Console.ReadLine();
        
        List<string> Check = new List<string>()   //Custom guard clause to prevent wrong type of user input by limiting allowed options to those contained in a list.
        {
            "1","2","3","4"
        };

        if (!Check.Contains(License))  //Guard clause that prints instructions for user in case they entered wrong option, calls initial method recursively.
        {
            Printing.PrintT("Enter Valid Option!",'r',0);
            Console.WriteLine();
            EnterDetails();
        }

        if (License == "1")   // THe following conditionals create respective type of user.
        {
            Student student = new Student();
            student.Message();
            return;
        }

        if (License == "2")
        {
            Professional professional = new Professional();
            professional.Message();
            return;
        }
        
        if (License == "3")
        {
            Tester tester = new Tester();
            tester.Message();
            return;
        }
        if (License == "4")
        {
            Console.WriteLine();
            Printing.PrintT("See ya Maths Wizard.",'r',0); //Friendly message printed in case user decides to exit program.
            Environment.Exit(0);
        }
    }
}

    interface IRegistration    //Interface for register method, inherited by all user types.
    {
       protected void Register(string Name);
    }

    public class Professional : User, IRegistration  //Professional user type, inheriting methods from parent class and interface.
    {
        protected override void Message()           //Overriden message method from parent class, with changes for professional type user.
        {
            
            Printing.PrintT("Please register your name: ", 'g', 0);  //It is similar to original method however has extra options.
            Name = Console.ReadLine();
            if (string.IsNullOrEmpty(Name))                                         //Guard clause to prevent null input.
            {
                Printing.PrintT("Enter Valid name!",'r',0);
                Console.WriteLine();
                Message();
            }

            foreach (char i in Name)
            {
                if (!Char.IsLetter(i) && i != ' ' && !Char.IsPunctuation(i))     //Custom guard clause that prevents User name from having Numbers, allows punctuation and spaces for multiple
                {                                                                // names and for honorifics like Dr. or Mr. Mrs.
                    Printing.PrintT("No numerical values please!", 'r', 0);  //Both guard clauses call message method in case requisites aren't fulfilled.  
                    Console.WriteLine();
                    Message();
                    return;
                }
            }

            LicenseCheck();     //I created a method for a license number system for professional users, it cross references a txt file with acceptable serial keys if pro user has a valid key
            void LicenseCheck() // they are awarded a pro license and access to the program.
            {
                Console.WriteLine();

                List<string> Licenses = File.ReadAllLines("Licenses.txt").ToList();  //This list includes the txt file strings with all valid keys.
                Printing.PrintT("List of valid license numbers, printed for testing", 'r', 0); // This list of codes is only printed for testing purposes.
                foreach (string i in Licenses)
                    Printing.PrintT(i, 'b', 0);
                Console.WriteLine();
                Printing.PrintT("Please insert 8 digit license number: ", 'g', 0); //Tells user to insert a valid 8 digit code.
                string RegistrationNo = Console.ReadLine();

                if (!Licenses.Contains(RegistrationNo))                                             // Checks list to see if it contains the code, if not it recalls license check method.
                {
                    Printing.PrintT("Enter Valid License key!", 'r', 0);
                    LicenseCheck();
                }
                
                LicenseType = "Professional";   //Defines license type as professional.
                Register(Name);                 //Calls registered message method.
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
    public class Tester : User  //Same logic as student and pro user, but for temporary test user.
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

    public class Student : User, IRegistration  //Same method as professional or tester user but for student user, is awarded a free students license.
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

 


