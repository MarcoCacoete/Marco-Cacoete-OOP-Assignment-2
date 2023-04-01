namespace OOP_assignment_2;

public class Deal
{
    // Deal class, lots of code was trimmed out because it's not needed for the purposes of this app.
      private static List<Card> dealtCards = new List<Card>();
        // Some objects are crated to be used by several methods
        private static Card value;

        public static void dealer(int dealChoice, int amount,List<Card> cardPack)  // Small card dealing method added that accepts referals from testing class to access encapsulated methods
                                                               // depending on conditionals
        {
            if (dealChoice == 1)
            {
            }
            if (dealChoice == 2)
            {
                dealCard(amount,cardPack);
            }
        }
       
        //Deals the number of cards specified by 'amount'
        public static List<Card> dealCard(int amount,List<Card> cardPack)          // Similar method as above but with a counter equivalent to number of cards to deal
        {
            try
            {
                while (amount > 0)
                {

                    Card value = cardPack[0];                   // Creates a card with value matching the card at index 0 in cardPack

                    cardPack.RemoveAt(0);                       // Removes card at same index in cardPack

                    dealtCards.Add(value);                      // Adds card to dealt cards list

                    amount--;                                   // Decrements counter
                }
                Console.WriteLine("Your dealt cards so far.");
                foreach (Card card in dealtCards)
                {
                    Console.WriteLine(card.ToString());     // Prints all dealt cards
                }
                Console.WriteLine();
                string choice = "n";
                while (choice == "n")
                {
                    Tutorial.Instructions(dealtCards);
                    foreach (Card card in dealtCards)
                    {
                        cardPack.Add(card);
                    }
                    dealtCards.Clear();
                    Deal.dealer(2,5,cardPack);
                    Printing.PrintT("Would you like to continue? (y/n)",'b',0);
                    choice = Console.ReadLine();
                }
            }
            catch (Exception)
            {
                foreach (Card card in dealtCards)
                {
                    Console.WriteLine(card.ToString());     // Prints all dealt cards
                }
                Console.WriteLine("Your dealt cards so far.");
                Console.WriteLine("No more cards to be dealt, goodbye Dave"); // Same idea as above for when all cards are dealt
                Console.ReadLine();
                Environment.Exit(0);
            }
            return dealtCards;
        }
}