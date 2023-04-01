namespace OOP_assignment_2;

static class Tutorial
{
    //Class responsible for the greeting messages and the goodbye messages.

    public static void Message(int choice)
    {
        if (choice == 1)
        {
            Printing.PrintT("Hi I'm the math tutor, and I exist to help you be better at doing math!", 'g', 0);
            Console.WriteLine();
            Printing.PrintT("Math is easy, let me help you, all you need to do is calculate the correct answer in your head or with pen and paper and enter it. Good luck! ", 'g', 0);
            Console.WriteLine();
            Printing.PrintT("Please use 2 decimal places for division questions!",'r',0);
            Console.WriteLine();
            Printing.PrintT("This is gonna be fun!", 'g', 0);
            Console.WriteLine();
        }

        if (choice == 2)
        {
            Printing.PrintT("See ya 'Genius'.", 'b', 0);
        }
    }
}
    
