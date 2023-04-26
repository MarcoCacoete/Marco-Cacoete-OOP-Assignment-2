using System.Drawing;

namespace OOP_assignment_2;

public static class Printing
{
    //This class is responsible for printing to console in three different colour options, it does this by changing foreground colour, printing the data then reverting back to white.


    public static void Print(string text, char colour, int lineNoLine) // The following 3 methods are entry points that carry arguments for options when printing.
    {                                                                   // The char argument picks colour, the linenoline arguments, defines if something is printed on new line or not.
        if (lineNoLine == 0)
            Printer(text, colour, lineNoLine);
        else
        {
            Printer(text, colour, 1);
        }
    }

    public static void Print(int num, char colour, int lineNoLine)
    {
        if (lineNoLine == 0)
            Printer(num, colour, lineNoLine);
        else
        {
            Printer(num, colour, 1);
        }
    }

    public static void Print(double num, char colour, int lineNoLine)
    {
        if (lineNoLine == 0)
            Printer(num, colour, lineNoLine);
        else
        {
            Printer(num, colour, 1);
        }
    }
    public static void Print(char c, char colour, int lineNoLine)
    {
        if (lineNoLine == 0)
            Printer(c, colour, lineNoLine);
        else
        {
            Printer(c, colour, 1);
        }
    }


    private static void Printer(string text, char colour, int lineNoLine) //Private methods for changing foreground colours for printing, one for text one for integers and one for doubles.
    {                                                                     //Can easily add more colour options and data types as needed.
        if (lineNoLine == 0)
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
        }
        else
        {
            if (colour == 'g')
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(text);
                Console.ForegroundColor = ConsoleColor.White;
                return;
            }

            if (colour == 'b')
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write(text);
                Console.ForegroundColor = ConsoleColor.White;
                return;
            }

            if (colour == 'r')
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(text);
                Console.ForegroundColor = ConsoleColor.White;
                return;
            }
        }
    }

    private static void Printer(int number, char colour, int lineNoLine)
    {
        if (lineNoLine == 0)
        {

            if (colour == 'g')
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(number);
                Console.ForegroundColor = ConsoleColor.White;
                return;
            }

            if (colour == 'b')
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine(number);
                Console.ForegroundColor = ConsoleColor.White;
                return;
            }

            if (colour == 'r')
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(number);
                Console.ForegroundColor = ConsoleColor.White;
                return;
            }
        }
        else
        {
            if (colour == 'g')
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(number);
                Console.ForegroundColor = ConsoleColor.White;
                return;
            }

            if (colour == 'b')
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write(number);
                Console.ForegroundColor = ConsoleColor.White;
                return;
            }

            if (colour == 'r')
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(number);
                Console.ForegroundColor = ConsoleColor.White;
                return;
            }
        }
    }

    private static void Printer(double number, char colour, int lineNoLine)
    {
        if (lineNoLine == 0)
        {

            if (colour == 'g')
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(number);
                Console.ForegroundColor = ConsoleColor.White;
                return;
            }

            if (colour == 'b')
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine(number);
                Console.ForegroundColor = ConsoleColor.White;
                return;
            }

            if (colour == 'r')
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(number);
                Console.ForegroundColor = ConsoleColor.White;
                return;
            }
        }
        else
        {
            if (colour == 'g')
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(number);
                Console.ForegroundColor = ConsoleColor.White;
                return;
            }

            if (colour == 'b')
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write(number);
                Console.ForegroundColor = ConsoleColor.White;
                return;
            }

            if (colour == 'r')
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(number);
                Console.ForegroundColor = ConsoleColor.White;
                return;
            }
        }
    }
    private static void Printer(char text, char colour, int lineNoLine) //Private methods for changing foreground colours for printing, one for text one for integers and one for doubles.
    {                                                                     //Can easily add more colour options and data types as needed.
        if (lineNoLine == 0)
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
        }
        else
        {
            if (colour == 'g')
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(text);
                Console.ForegroundColor = ConsoleColor.White;
                return;
            }

            if (colour == 'b')
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write(text);
                Console.ForegroundColor = ConsoleColor.White;
                return;
            }

            if (colour == 'r')
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(text);
                Console.ForegroundColor = ConsoleColor.White;
                return;
            }
        }
    }
}
