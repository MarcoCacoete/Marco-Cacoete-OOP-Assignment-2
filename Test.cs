using System.Data;
using System.Net.Sockets;
using System.Security.Cryptography;

namespace OOP_assignment_2;

public class Test
{
    
    public static string UserName;


    //Entry point to test methods, picks difficulty or exits program.
    public static void Instructions(List<Card> cards)
    {
        try
        {
            Console.WriteLine();
            Printing.PrintT("Please select difficulty.", 'b', 0);  //Options to pick from.
            Printing.PrintT("1: Easy Exercise.", 'b', 0);
            Printing.PrintT("2: Hard Exercise.", 'b', 0);
            Console.WriteLine();
            Printing.PrintT("3: Exit.", 'r', 0);
            
            


            int Difficulty = Convert.ToInt32(Console.ReadLine());
            if (Difficulty == 1)                                                    //Calls for both exercise methods and exit program.
            {
                Exercises.Difficulty(1,cards);
            }

            if (Difficulty == 2)
            {
                Exercises.Difficulty(2,cards);
            }

            if (Difficulty == 3)
            {
                Exercises.TotalAttempts = Exercises.CorrectQuestions + Exercises.WrongQuestions;
                Statistics.DataString(UserName, Statistics.Percentage(Exercises.CorrectQuestions, Exercises.WrongQuestions),Exercises.TotalAttempts);
                Console.WriteLine();
                Printing.PrintT("See ya Maths Wizard.",'r',0);
                Environment.Exit(0);
            }
        }
        catch (Exception)
        {
            Printing.PrintT("Enter Valid Option!",'r',0);
            Console.WriteLine();
            Console.WriteLine("Your dealt cards so far.");
            foreach (Card card in cards)
            {
                Console.WriteLine(card.ToString());     // Prints all dealt cards
            }
            Instructions(cards);

        }
    }
    //Easy exercise method.
    
}