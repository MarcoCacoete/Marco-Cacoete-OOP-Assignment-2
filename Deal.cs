namespace OOP_assignment_2;

public class Deal
{
      private static List<Card> dealtCards = new List<Card>();
        // Some objects are crated to be used by several methods
        private static Card value;

        public static void dealer(int dealChoice, int amount,List<Card> cardPack)  // Small card dealing method added that accepts referals from testing class to access encapsulated methods
                                                               // depending on conditionals
        {
            if (dealChoice == 1)
            {
                dealCard(cardPack);
            }
            if (dealChoice == 2)
            {
                dealCard(amount,cardPack);
            }
        }
        public static Card dealCard(List<Card> cardPack)                          // Method used to deal 1 card in try catch for error handling
        {
            //Deals one card
            try
            {

                Card value = cardPack[0];                   // Creates a card with value matching the card at index 0 in cardPack

                cardPack.RemoveAt(0);                       // Removes card at same index in cardPack

                dealtCards.Add(value);                      // Adds this card to dealt cards list

                foreach (Card card in dealtCards)
                {
                    Console.WriteLine(card.ToString());     // Prints all dealt cards
                }
                return value;
            }
            catch (Exception)
            {
                foreach (Card card in dealtCards)
                {
                    Console.WriteLine(card.ToString());     // Prints all dealt cards
                }
                Console.WriteLine("Your dealt cards so far.");
                Console.WriteLine("No more cards to deal, goodbye Dave."); // This catch was created to stop the program from crashing after all cards are dealt 
                Console.ReadLine();                                        // with a cheeky reference to 2001 a space odyssey
                Environment.Exit(0);                                       // Because not much can be accomplished after all cards are dealt the program exits
            }
            return value;
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