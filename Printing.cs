using System.Drawing;

namespace OOP_assignment_2;

public static class Printing
{
    //This class is responsible for printing.


    public static void PrintT(string text, char colour)
    {
        printer(text,colour);
        
    }
    
    public static void PrintN(int num, char colour)
    {
        printer(num,colour);
        
    }
    private static void printer(string text, char colour)
    {

        if (colour == 'g')
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(text);
            Console.ForegroundColor = ConsoleColor.White;
            return;

        }
        if (colour == 'b')
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(text);
            Console.ForegroundColor = ConsoleColor.White;
            return;

        }
        if (colour == 'r')
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(text);
            Console.ForegroundColor = ConsoleColor.White;
            return;

        }
        else
        {
            Console.WriteLine(text);
        }
    }
    
    private static void printer(int num, char colour)
    {
        Console.WriteLine(num);

    }
    
}