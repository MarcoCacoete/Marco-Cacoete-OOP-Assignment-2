namespace OOP_assignment_2;

static class Tutorial
{
    //Class responsible for the tutorial messages with instructions.

    public static void Message(int choice)  //Method calls to printing method for messages to user, these are printed in different colours. More info on printing method on printing class.
    {
       
            Printing.Print("Hi I'm the maths tutor, and I exist to help you be better at doing math!", 'b', 0);
            Console.WriteLine();
            Printing.Print("Maths is easy, let me help you, all you need to do is calculate the correct answer in your head or with pen and paper and enter it. Good luck! ", 'b', 0);
            Console.WriteLine();
            Printing.Print("Please round to 2 decimal places for division results with 2 or more decimal places!",'r',0);
            Console.WriteLine();
            Printing.Print("This is gonna be fun!", 'b', 0);
       
    }
}
    
