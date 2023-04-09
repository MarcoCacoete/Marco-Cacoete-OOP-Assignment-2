namespace OOP_assignment_2;

static class Tutorial
{
    //Class responsible for the greeting messages and the goodbye messages.

    public static void Message(int choice)
    {
       
            Printing.PrintT("Hi I'm the maths tutor, and I exist to help you be better at doing math!", 'b', 0);
            Console.WriteLine();
            Printing.PrintT("Maths is easy, let me help you, all you need to do is calculate the correct answer in your head or with pen and paper and enter it. Good luck! ", 'b', 0);
            Console.WriteLine();
            Printing.PrintT("Please round to 2 decimal places for division results with 2 or more decimal places.!",'r',0);
            Console.WriteLine();
            Printing.PrintT("This is gonna be fun!", 'b', 0);
       
    }
}
    
