namespace OOP_assignment_2;

public class Card
{

    //Base for the Card class.
    //Value: numbers 1 - 13
    //Suit: numbers 1 - 4

    private int cardValue;

    private int cardSuit;

    //constructor

    public Card(int value, int suit)
    {
        cardValue = value;
        cardSuit = suit;
        return; // Constructor returns ints for card value and suit as required by brief
    }

    public int Value
    {
        get { return cardValue; }
        set { cardValue = value; }
    }

    // gets and sets setup to keep give access to private variables, reinforcing the idea of encapsulation
    public int Suit
    {
        get { return cardSuit; }
        set { cardSuit = value; }
    }

    public override string
        ToString() // Override for the to string method used to return a string representation of card value and string. 
    {
        string valueString;
        // Switch statements which depending on case assign different string value to valueString and suitString. 
        switch (Value)
        {
            case 1:
                valueString = "A ";
                break;
            case 2:
                valueString = "2 ";
                break;
            case 3:
                valueString = "3 ";
                break;
            case 4:
                valueString = "4 ";
                break;
            case 5:
                valueString = "5 ";
                break;
            case 6:
                valueString =
                    "6 "; // Strings to replace card string value with respective value, some have extra spacing to make printed output line up better.
                break;
            case 7:
                valueString = "7 ";
                break;
            case 8:
                valueString = "8 ";
                break;
            case 9:
                valueString = "9 ";
                break;
            case 10:
                valueString = "10";
                break;
            case 11:
                valueString = "J ";
                break;
            case 12:
                valueString = "Q ";
                break;
            case 13:
                valueString = "K ";
                break;
            default:
                valueString = Value.ToString();
                break;
        }

        string suitString;
        switch (Suit)
        {
            case 1:
                suitString = "♠";
                break;
            case 2:
                suitString = "♦";
                break;
            case 3:
                suitString = "♥"; // Use of unicode to print symbols that match card suits.
                break;
            case 4:
                suitString = "♣";
                break;
            default:
                suitString = "?";
                break;
        }

        return
            "Card: " + valueString + " " +
            suitString; // Return for override, prints an abstracted version of card value and suit for end user testing code.
    }
}

