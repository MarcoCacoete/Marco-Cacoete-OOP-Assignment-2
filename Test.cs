using System.Data;
using System.Diagnostics;
using System.Net.Sockets;
using System.Security.Cryptography;

namespace OOP_assignment_2;

public class Test
{
    public static string UserName;

    //Entry point to test methods, picks difficulty or exits program.
    public static void Instructions(List<Card> cards)
    {
        try                                                         //Try catch method for error handling.
        {
            Console.WriteLine();
            Printing.Print("Please select difficulty.", 'b', 0);  //Options to pick from.
            Printing.Print("1: Easy Exercise.", 'b', 0);
            Printing.Print("2: Hard Exercise.", 'b', 0);
            Printing.Print("3: Custom Exercise/calculator.", 'b', 0);

            Console.WriteLine();
            Printing.Print("4: Exit.", 'r', 0);
            
            


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
                Exercises.Difficulty(3,cards);
            }


            if (Difficulty == 4)        // This conditional option terminates the program gracefully, before doing so it makes calls to calculate statistics and writing results to a file.
            {                           // It also includes a friendly message directed at user before exiting program.
                Exercises.TotalAttempts = Exercises.CorrectQuestions + Exercises.WrongQuestions; //Updates total attempts made so far.
                Statistics.DataString(UserName, Statistics.Percentage(Exercises.CorrectQuestions, Exercises.WrongQuestions),Exercises.TotalAttempts);
                Console.WriteLine();
                Printing.Print("See ya Maths Wizard.",'r',0); //Friendly flavour message for user.
                Environment.Exit(0);   //Exits program.
            }
        }
        catch (Exception)
        {                           // This catch recursively calls Instructions method with same hand of cards dealt in case of user error.
            Printing.Print("Enter Valid Option!",'r',0);
            Console.WriteLine();
            Console.WriteLine("Your dealt cards so far.");
            foreach (Card card in cards)
            {
                Console.WriteLine(card.ToString());     // Prints all dealt cards
            }
            Instructions(cards);

        }
    }
    // Tester method called from User class to test the math exercise, using Debug Assertion.
   public static void Tester()
    {                                               // Creates a new hand of 5 cards and compares result with a pre established correct result.
        List<Card> TestList = new List<Card>();
        Card card1 = new Card(5, 3);
        TestList.Add(card1);
        Card card2 = new Card(8, 3);
        TestList.Add(card2);
        Card card3 = new Card(9, 3);
        TestList.Add(card3);
        Card card4 = new Card(8, 2);
        TestList.Add(card4);
        Card card5 = new Card(8, 4);
        TestList.Add(card5);

        double Result =  TestExercise(TestList);
                   
        Debug.Assert(Result== 37,"Test failed");
        
        List<Card> TestList2 = new List<Card>();
        Card card6 = new Card(9, 3);
        TestList2.Add(card6);
        Card card7 = new Card(8, 4);
        TestList2.Add(card7);
        Card card8 = new Card(6, 3);
        TestList2.Add(card8);
        Card card9 = new Card(8, 1);
        TestList2.Add(card9);
        Card card = new Card(7, 4);
        TestList2.Add(card);
        
        double Result2 =  TestExercise(TestList2);
        
        Debug.Assert(Result2== 8.5,"Test failed");



    }
   // This is a copy of the hard exercise method, edited down to be used in this testing environment, this version returns a double to be compared with pre established answer.
    private static double TestExercise(List<Card> dealtCards)
    {
        string FirstNumber = Convert.ToString(dealtCards[0].Value);
        string SecondNumber = Convert.ToString(dealtCards[2].Value);        //Same exact method as exercises class, with some unnecessary portions removed for testing purposes.
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
        Printing.Print(Result, 'r', 0);
        return Result;
    }
}