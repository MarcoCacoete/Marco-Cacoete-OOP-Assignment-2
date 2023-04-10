using System.Data;

namespace OOP_assignment_2;
//Class with the Tutor exercises.
public class Exercises
{
    public static double CorrectQuestions;      //Some variables are delcared to be of use below.
    public static double WrongQuestions;
    public static double TotalAttempts;
    //Small method update total number of attempts.
    public static double Total(double total,double correct, double wrong)
    {
        TotalAttempts = correct + wrong;
        return TotalAttempts;
    }
    //Method that defines difficulty of exercises.
    public static void Difficulty(int option,List<Card> dealtCards)
    {
        if (option==1)
            EasyExercise(dealtCards);
        if (option==2)
            HardExercise(dealtCards);
    }
    //Method for easy exercise.
    private static void EasyExercise(List<Card> dealtCards)
    {
        string FirstNumber = Convert.ToString(dealtCards[0].Value);     //Takes either numerical value or suit from card objects, and assigns to string variables.
        string SecondNumber = Convert.ToString(dealtCards[2].Value);
        string Operator1 = "";
        double Result = 0;

        if (dealtCards[1].Suit == 1)                                    //Solution for determining what type of operation to execute using conditionals.
            Operator1 = "+";
        if (dealtCards[1].Suit == 2)
            Operator1 = "-";
        if (dealtCards[1].Suit == 3)
            Operator1 = "*";
        if (dealtCards[1].Suit == 4)
            Operator1 = "/";
        
        string expression = FirstNumber+Operator1+SecondNumber;         //Simple concatenation of strings representing the operation to be calculated.
        
        Result = Math.Round(Convert.ToDouble(new DataTable().Compute(expression, null)),2);   //Using Datatable method, it's possible to interpret the string expression as a math operation and produce a result.
                                                                                                   //Rounded double result to account for division.
        
        if(dealtCards[1].Suit == 3)                                                  //Overwrites multiplication operation * string to x to be able to print a better symbol to the user below.
            Operator1 = "x";

        Console.WriteLine();
        Printing.PrintT("What is the result of this operation?", 'g', 0); //Prompt for exercise, using my printing methods class which allows me to pick a text colour more easily.
        Printing.PrintT(FirstNumber, 'b', 1);
        Printing.PrintT(Operator1, 'r', 1);
        Printing.PrintT(SecondNumber, 'b', 0);
        Console.WriteLine();
        Printing.PrintT("This result is only shown for testing purposes. ",'r',0);
        Printing.PrintT("Calculated answer: ",'b',1 );
        Printing.PrintD(Result,'r',0);

        try                                                                 // Try catch method for error handling
        {
            double Answer = Math.Round(Convert.ToDouble(Console.ReadLine()), 2); //Converts user input to be used in comparison below, answer is formatted so that it matches calculated answer if user enters 2 decimals.

            if (Answer == Result)
            {
                Console.WriteLine();
                Printing.PrintT("You answered correctly!", 'g',
                    0); //If correct answer the program erases current dealt hand and recursively calls it again for a fresh exercise.
                Console.WriteLine();
                CorrectQuestions++;
                Statistics.Percentage(CorrectQuestions, WrongQuestions);
                Total(TotalAttempts, CorrectQuestions, WrongQuestions);
            }
            else
            {
                Console.WriteLine();
                Printing.PrintT("Sorry your answer is wrong, try again.", 'g',
                    0); //In case of incorrect answer the program offers user another chance, using same exercise.
                WrongQuestions++;
                Console.WriteLine();
                Statistics.Percentage(CorrectQuestions, WrongQuestions);
                EasyExercise(dealtCards);
                Console.WriteLine();
                Total(TotalAttempts, CorrectQuestions, WrongQuestions);

            }
        }
        catch
        {
            Printing.PrintT("Enter Valid Option!",'r',0);
            Console.WriteLine();
            EasyExercise(dealtCards);
        }
    }
        //Hard exercise method.
    private static void HardExercise(List<Card> dealtCards)
    {
        string FirstNumber = Convert.ToString(dealtCards[0].Value);
        string SecondNumber = Convert.ToString(dealtCards[2].Value);        //Same exact method as above, the only difference being the extra variables and operations for 5 cards instead of 3.
        string ThirdNUmber = Convert.ToString(dealtCards[4].Value);
        string Operator1 = "";
        string Operator2 = "";
        double Result = 0;

        if (dealtCards[1].Suit == 1)
            Operator1 = "+";
        if (dealtCards[1].Suit == 2)
            Operator1 = "-";
        if (dealtCards[1].Suit == 3)
            Operator1 = "*";
        if (dealtCards[1].Suit == 4)
            Operator1 = "/";
        if (dealtCards[3].Suit == 1)
            Operator2 = "+";
        if (dealtCards[3].Suit == 2)
            Operator2 = "-";
        if (dealtCards[3].Suit == 3)
            Operator2 = "*";
        if (dealtCards[3].Suit == 4)
            Operator2 = "/";
        
        
        string expression = FirstNumber+Operator1+SecondNumber+Operator2+ThirdNUmber;
        
        Result = Math.Round(Convert.ToDouble(new DataTable().Compute(expression, null)),2);
        
        if(dealtCards[1].Suit == 3)
            Operator1 = "x";
        if(dealtCards[3].Suit == 3)
            Operator2 = "x";
        
        Console.WriteLine();
        Printing.PrintT("What is the result of this operation?", 'g', 0);            
        Printing.PrintT(FirstNumber, 'b', 1);
        Printing.PrintT(Operator1, 'r', 1);
        Printing.PrintT(SecondNumber, 'b', 1);
        Printing.PrintT(Operator2, 'r', 1);
        Printing.PrintT(ThirdNUmber, 'b', 0);
        Console.WriteLine();
        Printing.PrintT("This result is only shown for testing purposes. ",'r',0);
        Printing.PrintT("Calculated answer: ",'b',1 );
        Printing.PrintD(Result,'r',0);
        try
        {
            double Answer = Math.Round(Convert.ToDouble(Console.ReadLine()), 2);

            if (Answer == Result)
            {
                Console.WriteLine();
                Printing.PrintT("You answered correctly!", 'g', 0);
                Console.WriteLine();
                CorrectQuestions++;
                Statistics.Percentage(CorrectQuestions, WrongQuestions);
                Total(TotalAttempts, CorrectQuestions, WrongQuestions);
            }
            else
            {
                Console.WriteLine();
                Printing.PrintT("Sorry your answer is wrong, try again.", 'g', 0);
                WrongQuestions++;
                Console.WriteLine();
                Statistics.Percentage(CorrectQuestions, WrongQuestions);
                HardExercise(dealtCards);
                Console.WriteLine();
                Total(TotalAttempts, CorrectQuestions, WrongQuestions);
            }
        }
        catch
        {
            Printing.PrintT("Enter Valid Option!",'r',0);
            Console.WriteLine();
            HardExercise(dealtCards);
        }
    }
}