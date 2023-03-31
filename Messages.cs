namespace OOP_assignment_2;

static class Messages
{
    //Class responsible for the greeting messages and the goodbye messages.

    public static void Message(int choice)
    {
        if (choice == 1)
        {
            MessageT("Welcome to the math game",'g');
            MessageT("This is gonna be fun dude teehee!",'b');
        }
        else
        {
            MessageT("Goodbye my man" ,'r');
        }
    }
    
    private static void MessageT(string text,char colour)
    {
        Printing.PrintT(text,colour);
    }
    private static void MessageN(string text, char colour)
    {
        Printing.PrintT(text,colour);

    }
}