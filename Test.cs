using System.Data;
using System.Net.Sockets;

namespace OOP_assignment_2;

public class Test
{
    //Entry point to tutorial methods, picks difficulty or exits program.
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
                EasyExercise(cards);
            }

            if (Difficulty == 2)
            {
                HardExercise(cards);
            }

            if (Difficulty == 3)
            {
                Console.WriteLine();
                Printing.PrintT("See ya 'Genius'.",'r',0);
                Environment.Exit(0);
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
        }
    }
    //Easy exercise method.
    private static void EasyExercise(List<Card> DealtCards)
    {
        string FirstNumber = Convert.ToString(DealtCards[0].Value);     //Takes either numerical value or suit from card objects, and assigns to string variables.
        string SecondNumber = Convert.ToString(DealtCards[2].Value);
        string Operator1 = "";
        double Result = 0;

        if (DealtCards[1].Suit == 1)                                    //Solution for determining what type of operation to execute.
            Operator1 = "+";
        if (DealtCards[1].Suit == 2)
            Operator1 = "-";
        if (DealtCards[1].Suit == 3)
            Operator1 = "*";
        if (DealtCards[1].Suit == 4)
            Operator1 = "/";
        
        string expression = FirstNumber+Operator1+SecondNumber;         //Simple concatenation of strings representing the operation to be calculated.
        
        Result = Math.Round(Convert.ToDouble(new DataTable().Compute(expression, null)),2);   //Using Datatable method, it's possible to interpret the string expression and produce a result.
                                                                                                   //Rounded double result to account for division.
        
        if(DealtCards[1].Suit == 3)                                                  //Overwrites multiplication operation * string to x to be able to print a better symbol to the user below.
            Operator1 = "x";
       

        Printing.PrintT("What is the result of this operation?", 'g', 0); //Prompt for exercise, using my printing methods class, that allows me to pick a text colour more easily.
        Printing.PrintT(FirstNumber, 'b', 1);
        Printing.PrintT(Operator1, 'r', 1);
        Printing.PrintT(SecondNumber, 'b', 0);
        Console.WriteLine(Result);


        double Answer = Convert.ToDouble(Console.ReadLine());                               //Converts user input to be used in comparison below.
        
        if (Answer == Result)
        {
            Console.WriteLine();
            Printing.PrintT("You answered correctly!", 'g', 0);           //If correct answer the program erases current dealt hand and recursively calls it again for a fresh exercise.
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine();
            Printing.PrintT("Sorry your answer is wrong, try again.", 'g', 0); //In case of incorrect answer the program offers a chance of trying again to user, using same exercise.
            EasyExercise(DealtCards);
            Console.WriteLine();
        }
    }
        //Hard exercise method.
    private static void HardExercise(List<Card> DealtCards)
    {
        string FirstNumber = Convert.ToString(DealtCards[0].Value);
        string SecondNumber = Convert.ToString(DealtCards[2].Value);        //Same exact method as above, the only difference being the extra variables and operations for 5 cards instead of 3.
        string ThirdNUmber = Convert.ToString(DealtCards[4].Value);
        string Operator1 = "";
        string Operator2 = "";
        double Result = 0;

        if (DealtCards[1].Suit == 1)
            Operator1 = "+";
        if (DealtCards[1].Suit == 2)
            Operator1 = "-";
        if (DealtCards[1].Suit == 3)
            Operator1 = "*";
        if (DealtCards[1].Suit == 4)
            Operator1 = "/";
        if (DealtCards[3].Suit == 1)
            Operator2 = "+";
        if (DealtCards[3].Suit == 2)
            Operator2 = "-";
        if (DealtCards[3].Suit == 3)
            Operator2 = "*";
        if (DealtCards[3].Suit == 4)
            Operator2 = "/";
        
        
        string expression = FirstNumber+Operator1+SecondNumber+Operator2+ThirdNUmber;
        
        Result = Math.Round(Convert.ToDouble(new DataTable().Compute(expression, null)),2);
        
        if(DealtCards[1].Suit == 3)
            Operator1 = "x";
        if(DealtCards[3].Suit == 3)
            Operator2 = "x";

        Printing.PrintT("What is the result of this operation?", 'g', 0);
        Printing.PrintT(FirstNumber, 'b', 1);
        Printing.PrintT(Operator1, 'r', 1);
        Printing.PrintT(SecondNumber, 'b', 1);
        Printing.PrintT(Operator2, 'r', 1);
        Printing.PrintT(ThirdNUmber, 'b', 0);
       

        Console.WriteLine(Result);

        double Answer = Convert.ToDouble(Console.ReadLine());
        
        if (Answer == Result)
        {
            Console.WriteLine();
            Printing.PrintT("You answered correctly!", 'g', 0);
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine();
            Printing.PrintT("Sorry your answer is wrong, try again.", 'g', 0);
            HardExercise(DealtCards);
            Console.WriteLine();
        }
    }
}