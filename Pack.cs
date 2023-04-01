namespace OOP_assignment_2;

public class Pack
{
        private static List<Card> cardPack = new List<Card>(); //encapsulation was used for this list of card objects
        //constructor
        static Pack()
        {
            int packSize = -1; // Packsize iterator variable

            int suit = 0; // Suit variable for second iteration

            // Card pack generator

            while (packSize < 51) // While loop lets it run until it fills a pack with 52 cards
            {
                while (suit < 4) // Iterates for each of the 4 suits and creates suited cards until all 13 are in
                {
                    int suitCards = 0;
                    suit++;
                    while (suitCards < 13)
                    {
                        suitCards++;

                        packSize++;                                   // Counter iterator for packsize to stop operation when pack is complete

                        cardPack.Add(new Card(suitCards, suit));      // Adds card objects to card list                     
                    }
                }
                foreach (Card card in cardPack)
                {
                    Console.WriteLine(card);
                }
                Console.WriteLine("Your created pack above.");   // Prints pack
                Console.WriteLine();
            }
        }
        // Creates random object
        private static Random rnd = new Random();

        // Executes one of 3 methods to shuffle based on the type of shuffle
        public static bool shuffleCardPack(int typeOfShuffle)
        {

            if (typeOfShuffle == 1)
            {
                fisherYates(); //used encapsulation on both shuffles
            }

            return true;
        }

        private static List<Card> dealtCards = new List<Card>();
        // Some objects are crated to be used by several methods
        private static Card value;

        public static void dealer(int dealChoice, int amount)  // Small card dealing method added that accepts referals from testing class to access encapsulated methods
                                                               // depending on conditionals
        {
            if (dealChoice == 1)
            {
            }
            if (dealChoice == 2)
            {
                dealCard(amount);
            }
        }
        
        //Deals the number of cards specified by 'amount'
        public static List<Card> dealCard(int amount)          // Similar method as above but with a counter equivalent to number of cards to deal
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
        private static void fisherYates() //private encapsulated method for fisher yates shuffle
        {
            List<Card> check = new List<Card>();  // Creates a check list whose elements are used to cross check

            int counter = -1;                     // Simple counter started at -1 for correct indexing

            while (check.Count < 52)              // Runs code until it fills check list 
            {
                int r = rnd.Next(cardPack.Count); // Picks random index from card list

                var value = cardPack[r];         // Gives variable its card value

                if (!check.Contains(value))      // Checks check list to see it has been added already if it has it skips it
                {

                    cardPack.RemoveAt(r);        // Removes card at index r

                    check.Add(value);            // Proceeds to add it to cardPack list

                    cardPack.Add(value);         // Proceeds to add it to end of cardPack list

                    counter++;                   // Counter increases by 1
                }
            }
            Deal.dealer(2,5,cardPack);
        }
    }
    