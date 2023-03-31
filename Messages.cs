namespace OOP_assignment_2;

static class Messages
{
    //Class responsible for the greeting messages and the goodbye messages.

    public static void Message(int choice)
    {
        if (choice == 1)
        {
            MessageT("Welcome to the math game",'g',0);
            MessageT("This is gonna be fun dude teehee!",'b',0);
        }
        else
        {
            MessageT("Goodbye my man" ,'r',0);
        }
    }
    
    private static void MessageT(string text,char colour,int Choice)
    {
        Printing.PrintT(text,colour,Choice);
    }
    private static void MessageN(string text, char colour, int Choice)
    {
        Printing.PrintT(text,colour,Choice);

    }
}