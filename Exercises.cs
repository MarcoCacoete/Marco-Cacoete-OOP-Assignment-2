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
        if (option==3)
            CustomExercise();
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
        Printing.Print("What is the result of this operation?", 'g', 0); //Prompt for exercise, using my printing methods class which allows me to pick a text colour more easily.
        Printing.Print(FirstNumber, 'b', 1);
        Printing.Print(Operator1, 'r', 1);
        Printing.Print(SecondNumber, 'b', 0);
        Console.WriteLine();
        Printing.Print("This result is only shown for testing purposes. ",'r',0);
        Printing.Print("Calculated answer: ",'b',1 );
        Printing.Print(Result,'r',0);

        try                                                                 // Try catch method for error handling
        {
            double Answer = Math.Round(Convert.ToDouble(Console.ReadLine()), 2); //Converts user input to be used in comparison below, answer is formatted so that it matches calculated answer if user enters 2 decimals.

            if (Answer == Result)
            {
                Console.WriteLine();
                Printing.Print("You answered correctly!", 'g',
                    0); //If correct answer the program erases current dealt hand and recursively calls it again for a fresh exercise.
                Console.WriteLine();
                CorrectQuestions++;
                Statistics.Percentage(CorrectQuestions, WrongQuestions);
                Total(TotalAttempts, CorrectQuestions, WrongQuestions);
            }
            else
            {
                Console.WriteLine();
                Printing.Print("Sorry your answer is wrong, try again.", 'g',
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
            Printing.Print("Enter Valid Option!",'r',0);
            Console.WriteLine();
            EasyExercise(dealtCards);
        }
        return;
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
        Printing.Print("What is the result of this operation?", 'g', 0);            
        Printing.Print(FirstNumber, 'b', 1);
        Printing.Print(Operator1, 'r', 1);
        Printing.Print(SecondNumber, 'b', 1);
        Printing.Print(Operator2, 'r', 1);
        Printing.Print(ThirdNUmber, 'b', 0);
        Console.WriteLine();
        Printing.Print("This result is only shown for testing purposes. ",'r',0);
        Printing.Print("Calculated answer: ",'b',1 );
        Printing.Print(Result,'r',0);
        try
        {
            double Answer = Math.Round(Convert.ToDouble(Console.ReadLine()), 2);

            if (Answer == Result)
            {
                Console.WriteLine();
                Printing.Print("You answered correctly!", 'g', 0);
                Console.WriteLine();
                CorrectQuestions++;
                Statistics.Percentage(CorrectQuestions, WrongQuestions);
                Total(TotalAttempts, CorrectQuestions, WrongQuestions);
            }
            else
            {
                Console.WriteLine();
                Printing.Print("Sorry your answer is wrong, try again.", 'g', 0);
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
            Printing.Print("Enter Valid Option!",'r',0);
            Console.WriteLine();
            HardExercise(dealtCards);
        }
        return;
    }
    //Mostly the same exercise as hard exercise, the difference is the user can enter a custom string as a math expression with added parenthesis
    private static void CustomExercise()
    {
        try
        {
            double Result = 0;
            
            Printing.Print("Enter your own exercise, or use calculator. Allowed Operators: ( ) - + * /.",'b',0);

            string expression = Console.ReadLine();
            
            Result = Math.Round(Convert.ToDouble(new DataTable().Compute(expression, null)),2);
            
            ExpressionPrint();
            
            void ExpressionPrint()
            {
                

                Console.WriteLine();
                Printing.Print("What is the result of this operation?", 'g', 0); //Small block of code to print custom expression in same style as other exercises.
                Console.WriteLine();
                foreach (char i in expression)
                {
                    if (i == '*')
                        Printing.Print("x", 'r', 1);
                    else if (i == '-')
                        Printing.Print("-", 'r', 1);
                    else if (i == '+')
                        Printing.Print("+", 'r', 1);
                    else if (i == '/')
                        Printing.Print("/", 'r', 1);
                    else if (i == '(')
                        Printing.Print("(", 'r', 1);
                    else if (i == ')')
                        Printing.Print(")", 'r', 1);
                    else
                    {
                        Printing.Print(i, 'b', 1);
                    }

                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Printing.Print("This result is only shown for testing purposes. ",'r',0);
            Printing.Print("Calculated answer: ",'b',1 );
            Printing.Print(Result,'r',0);
            
                double Answer = Math.Round(Convert.ToDouble(Console.ReadLine()), 2);

                if (Answer == Result)
                {
                    Console.WriteLine();
                    Printing.Print("You answered correctly!", 'g', 0);
                    Console.WriteLine();
                    CorrectQuestions++;
                    Statistics.Percentage(CorrectQuestions, WrongQuestions);
                    Total(TotalAttempts, CorrectQuestions, WrongQuestions);
                }
                else
                {
                    Console.WriteLine();
                    Printing.Print("Sorry your answer is wrong, try again.", 'g', 0);
                    WrongQuestions++;
                    Console.WriteLine();
                    ExpressionPrint();
                    Statistics.Percentage(CorrectQuestions, WrongQuestions);
                    CustomExercise();
                    Console.WriteLine();
                    Total(TotalAttempts, CorrectQuestions, WrongQuestions);
                }
        }
        catch
        {
            Printing.Print("Enter Valid math expression!",'r',0);
            Console.WriteLine();
            CustomExercise();
        }

        return;
    }
}