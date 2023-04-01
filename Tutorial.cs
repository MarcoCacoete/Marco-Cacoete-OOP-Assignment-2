using System.Net.Sockets;

namespace OOP_assignment_2;

public class Tutorial
{
    public static void Instructions(List<Card> cards)
    {
        Console.WriteLine();
        Printing.PrintT("Select difficulty please.",'b',0);
        string Difficulty = Console.ReadLine();
        if (Difficulty == "1")
        {
            EasyExercise(cards);
        }

        if (Difficulty == "2")
        {
            HardExercise(cards);
        }
    }

    private static void EasyExercise(List<Card> DealtCards)
    {
        double FirstNumber = DealtCards[0].Value;
        double SecondNumber = DealtCards[2].Value;

      if (DealtCards[1].Suit == 0)
        {
            Printing.PrintT("What is the result of this operation?",'g',0);
            Printing.PrintD(FirstNumber,'r',1);
            Printing.PrintT(" + ",'b',1);
            Printing.PrintD(SecondNumber,'r',0);

            double Answer = int.Parse(Console.ReadLine());
            double Result = FirstNumber + SecondNumber;

            if (Answer == Result)
            {
                Printing.PrintT("You answered correctly!" ,'g',0);
            }
            else
            {
                Printing.PrintT("Sorry your answer is wrong, try again.",'g',0);
            }
        }
      if (DealtCards[1].Suit == 1)
      {
          Printing.PrintT("What is the result of this operation?",'g',0);
          Printing.PrintD(FirstNumber,'r',1);
          Printing.PrintT(" - ",'b',1);
          Printing.PrintD(SecondNumber,'r',0);

          double Answer = int.Parse(Console.ReadLine());
          double Result = FirstNumber - SecondNumber;

          if (Answer == Result)
          {
              Printing.PrintT("You answered correctly!" ,'g',0);
          }
          else
          {
              Printing.PrintT("Sorry your answer is wrong, try again.",'g',0);
          }
      }
      if (DealtCards[1].Suit == 2)
      {
          Printing.PrintT("What is the result of this operation?",'g',0);
          Printing.PrintD(FirstNumber,'r',1);
          Printing.PrintT(" x ",'b',1);
          Printing.PrintD(SecondNumber,'r',0);

          double Answer = int.Parse(Console.ReadLine());
          double Result = FirstNumber * SecondNumber;

          if (Answer == Result)
          {
              Printing.PrintT("You answered correctly!" ,'g',0);
          }
          else
          {
              Printing.PrintT("Sorry your answer is wrong, try again.",'g',0);
          }
      }
      if (DealtCards[1].Suit == 3)
      {
          Printing.PrintT("What is the result of this operation?",'g',0);
          Printing.PrintD(FirstNumber,'r',1);
          Printing.PrintT(" / ",'b',1);
          Printing.PrintD(SecondNumber,'r',0);
          double Result = FirstNumber / SecondNumber;
          Result = Math.Round(Result, 2);
          Console.WriteLine(Result);


          double Answer = Convert.ToDouble(Console.ReadLine());

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
    
    private static void HardExercise(List<Card> DealtCards)
    {
        int FirstNumber = DealtCards[0].Value;
        int SecondNumber = DealtCards[2].Value;
        int ThirdNUmber = DealtCards[4].Value;

        //  if (DealtCards[1].Suit == 0)
        while(true)
        {
            Printing.PrintT("What is the result of this operation?",'g',0);
            Printing.PrintN(FirstNumber,'r',1);
            Printing.PrintT(" + ",'b',1);
            Printing.PrintN(SecondNumber,'r',1);
            Printing.PrintT(" + ",'b',1);
            Printing.PrintN(ThirdNUmber,'r',0);



            int Answer = int.Parse(Console.ReadLine());
            int ResultOne = MathOps.Add(FirstNumber, SecondNumber);
            int ResultTwo = MathOps.Add(ResultOne, ThirdNUmber);

            if (Answer == ResultTwo)
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