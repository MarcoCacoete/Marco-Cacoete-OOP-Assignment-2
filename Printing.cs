using System.Drawing;

namespace OOP_assignment_2;

public static class Printing
{
    //This class is responsible for printing.


    public static void PrintT(string text, char colour, int LineNoLine)
    {
        if (LineNoLine == 0)
            printer(text, colour, LineNoLine);
        else
        {
            printer(text, colour, 1);
        }
    }

    public static void PrintN(int num, char colour, int LineNoLine)
    {
        if (LineNoLine == 0)
            printer(num, colour, LineNoLine);
        else
        {
            printer(num, colour, 1);
        }
    }

    public static void PrintD(double num, char colour, int LineNoLine)
    {
        if (LineNoLine == 0)
            printer(num, colour, LineNoLine);
        else
        {
            printer(num, colour, 1);
        }
    }

    private static void printer(string text, char colour, int LineNoLine)
    {
        if (LineNoLine == 0)
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

    private static void printer(int number, char colour, int LineNoLine)
    {
        if (LineNoLine == 0)
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

    private static void printer(double number, char colour, int LineNoLine)
    {
        if (LineNoLine == 0)
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
}
