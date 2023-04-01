using System.Data;
using System.Net.Sockets;

namespace OOP_assignment_2;

public class Tutorial
{
    public static void Instructions(List<Card> cards)
    {
        try
        {
            Console.WriteLine();
            Printing.PrintT("Select difficulty please.", 'b', 0);
            Printing.PrintT("1: Easy Exercise.", 'b', 0);
            Printing.PrintT("2: Hard Exercise.", 'b', 0);

            int Difficulty = Convert.ToInt32(Console.ReadLine());
            if (Difficulty == 1)
            {
                EasyExercise(cards);
            }

            if (Difficulty == 2)
            {
                HardExercise(cards);
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
        }
    }

    private static void EasyExercise(List<Card> DealtCards)
    {
        string FirstNumber = Convert.ToString(DealtCards[0].Value);
        string SecondNumber = Convert.ToString(DealtCards[2].Value);
        string Operator1 = "";
        double Result = 0;

        if (DealtCards[1].Suit == 1)
        {
            Operator1 = "+";
        }
        if (DealtCards[1].Suit == 2)
        {
            Operator1 = "-";
        }
        if (DealtCards[1].Suit == 3)
        {
            Operator1 = "*";
        }
        if (DealtCards[1].Suit == 4)
        {
            Operator1 = "/";
        }
        

        Printing.PrintT("What is the result of this operation?", 'g', 0);
        Printing.PrintT(FirstNumber, 'r', 1);
        Printing.PrintT(Operator1, 'b', 1);
        Printing.PrintT(SecondNumber, 'r', 0);
        
        string expression = FirstNumber+Operator1+SecondNumber;
        
        Result = Convert.ToDouble(new DataTable().Compute(expression, null));
        Result = Math.Round(Result,2);
        Console.WriteLine(Result);

        double Answer = Convert.ToDouble(Console.ReadLine());
        
        if (Answer == Result)
        {
            Printing.PrintT("You answered correctly!", 'g', 0);
        }
        else
        {
            Printing.PrintT("Sorry your answer is wrong, try again.", 'g', 0);
            EasyExercise(DealtCards);
        }
    }

    private static void HardExercise(List<Card> DealtCards)
    {
        string FirstNumber = Convert.ToString(DealtCards[0].Value);
        string SecondNumber = Convert.ToString(DealtCards[2].Value);
        string ThirdNUmber = Convert.ToString(DealtCards[4].Value);
        string Operator1 = "";
        string Operator2 = "";
        double Result = 0;

        if (DealtCards[1].Suit == 1)
        {
             Operator1 = "+";
        }
        if (DealtCards[1].Suit == 2)
        {
             Operator1 = "-";
        }
        if (DealtCards[1].Suit == 3)
        {
             Operator1 = "*";
        }
        if (DealtCards[1].Suit == 4)
        {
             Operator1 = "/";
        }
        if (DealtCards[3].Suit == 1)
        {
             Operator2 = "+";
        }
        if (DealtCards[3].Suit == 2)
        {
             Operator2 = "-";
        }
        if (DealtCards[3].Suit == 3)
        {
             Operator2 = "*";
        }
        if (DealtCards[3].Suit == 4)
        {
             Operator2 = "/";
        }

        Printing.PrintT("What is the result of this operation?", 'g', 0);
        Printing.PrintT(FirstNumber, 'r', 1);
        Printing.PrintT(Operator1, 'b', 1);
        Printing.PrintT(SecondNumber, 'r', 1);
        Printing.PrintT(Operator2, 'b', 1);
        Printing.PrintT(ThirdNUmber, 'r', 0);
        string expression = FirstNumber+Operator1+SecondNumber+Operator2+ThirdNUmber;
        
        Result = Convert.ToDouble(new DataTable().Compute(expression, null));
        Result = Math.Round(Result,2);

        Console.WriteLine(Result);

        double Answer = Convert.ToDouble(Console.ReadLine());
        
        if (Answer == Result)
        {
            Printing.PrintT("You answered correctly!", 'g', 0);
        }
        else
        {
            Printing.PrintT("Sorry your answer is wrong, try again.", 'g', 0);
            HardExercise(DealtCards);
        }
    }
}