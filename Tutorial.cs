namespace OOP_assignment_2;

public class Tutorial
{
    public static void Instructions(List<Card> cards)
    {
        Printing.PrintT("Maths is easy, let us help you, all you need to do is calculate the correct answer in your head or with pen and paper and enter it. Good luck! ", 'b',0);
        Console.WriteLine();
        Printing.PrintT("Select difficulty please.",'b',0);
        string Difficulty = Console.ReadLine();
        if (Difficulty == "1")
        {
            EasyExercise(cards);
        }

        if (Difficulty == "2")
        {
            
        }
    }

    private static void EasyExercise(List<Card> DealtCards)
    {
        int FirstNumber = DealtCards[0].Value;
        int SecondNumber = DealtCards[2].Value;

      //  if (DealtCards[1].Suit == 0)
      while(true)
        {
            Printing.PrintT("What is the result of this operation?",'g',0);
            Printing.PrintN(FirstNumber,'r',1);
            Printing.PrintT(" + ",'b',1);
            Printing.PrintN(SecondNumber,'r',0);

            int Answer = int.Parse(Console.ReadLine());
            int Result = FirstNumber + SecondNumber;

            if (Answer == Result)
            {
                Printing.PrintT("You answered correctly!" ,'g',0);
            }
            else
            {
                Printing.PrintT("Sorry your answer is wrong, try again.",'g',0);
            }
        }
    }
}