namespace OOP_assignment_2;

public class Pack
{
        private static List<Card> _cardPack = new List<Card>(); //encapsulation was used for this list of card objects
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

                        _cardPack.Add(new Card(suitCards, suit));      // Adds card objects to card list                     
                    }
                }
                foreach (Card card in _cardPack)
                {
                    Console.WriteLine(card);
                }
                Console.WriteLine("Your created pack above.");   // Prints pack
                Console.WriteLine();
            }
        }
        // Creates random object
        private static Random _rnd = new Random();

        public static bool ShuffleCardPack()
        {
            FisherYates();
            return true;
        }
        
        private static Card _value;
        
        private static void FisherYates() //private encapsulated method for fisher yates shuffle
        {
            List<Card> check = new List<Card>();  // Creates a check list whose elements are used to cross check

            int counter = -1;                     // Simple counter started at -1 for correct indexing

            while (check.Count < 52)              // Runs code until it fills check list 
            {
                int r = _rnd.Next(_cardPack.Count); // Picks random index from card list

                var value = _cardPack[r];         // Gives variable its card value

                if (!check.Contains(value))      // Checks check list to see it has been added already if it has it skips it
                {

                    _cardPack.RemoveAt(r);        // Removes card at index r

                    check.Add(value);            // Proceeds to add it to cardPack list

                    _cardPack.Add(value);         // Proceeds to add it to end of cardPack list

                    counter++;                   // Counter increases by 1
                }
            }
            Deal.Dealer(2,5,_cardPack);
        }
    }
    