namespace OOP_assignment_2;

static class Tutorial
{
    //Class responsible for the greeting messages and the goodbye messages.

    public static void Message(int choice)
    {
       
            Printing.PrintT("Hi I'm the maths tutor, and I exist to help you be better at doing math!", 'g', 0);
            Console.WriteLine();
            Printing.PrintT("Maths is easy, let me help you, all you need to do is calculate the correct answer in your head or with pen and paper and enter it. Good luck! ", 'g', 0);
            Console.WriteLine();
            Printing.PrintT("Please use 1 decimal place for division questions!",'r',0);
            Console.WriteLine();
            Printing.PrintT("This is gonna be fun!", 'g', 0);
       
    }
}
    
