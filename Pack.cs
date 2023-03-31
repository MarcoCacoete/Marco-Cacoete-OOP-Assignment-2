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

            if (typeOfShuffle == 2)
            {
                riffleShuffle(); // another encapsulated shuffle, can only be called from here
            }

            if (typeOfShuffle == 3)
            {
                Console.WriteLine("Your deck is not shuffled.");
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
                dealCard();
            }
            if (dealChoice == 2)
            {
                dealCard(amount);
            }
        }
        public static Card dealCard()                          // Method used to deal 1 card in try catch for error handling
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

            foreach (Card card in cardPack)
            {
                Console.WriteLine(card.ToString()); // Prints card pack
            }

            Console.WriteLine("I can shuffle now Dave");
            Console.WriteLine();

            Console.WriteLine("Your shuffled pack above.");
            
            Deal.dealer(2,3,cardPack);
        }

        //private encapsulated method for riffle shuffle based on real life steps with randomized card order
        private static void riffleShuffle()
        {
            int riffleCounter = 5;         // Counter for how many times shuffle needs to be done, recommended number is between 4 and 7

            while (riffleCounter > 0)      // While loop to run code till it reaches 0
            {
                riffle();                  // Calls riffle function

                riffleCounter--;            // Decrements counter

                void riffle()               // main method for riffle shuffle 
                {
                    int r = rnd.Next(0, 6);         // Generates random range for cutting the pack in half for uneven split

                    int counter1 = 21 + r;
                    int counter2 = 52 - counter1;   // Establishes size of two uneven split card stacks with counters corresponding to number of cards to be added to each side
                    int iterator = -1;

                    List<Card> leftHand = new List<Card>();  //Creates two lists one for each hand holding split pack
                    List<Card> rightHand = new List<Card>();

                    while (counter1 > 0)
                    {
                        iterator++;

                        leftHand.Add(cardPack[iterator]);   // Adds cards to left hand

                        counter1--;
                    }

                    while (counter2 > 0)
                    {
                        iterator++;

                        rightHand.Add(cardPack[iterator]);  // and to right hand

                        counter2--;
                    }

                    int iteratorLeft = 0;
                    int iteratorRight = 0;                  // Three new iterator variables
                    iterator = 52;

                    while (iterator > 0)                    // Uses iterator to check how many cards left need to be added to shuffled pack
                    {
                        int coinFlip = rnd.Next(0, 2);      // Coin flip decides which card is going in first to randomize stack, while creating "chunks" of same suited cards
                                                            // Tried to use randomnmess to simulate real life shuffling chance
                        if (leftHand.Count > 0)
                        {
                            if (coinFlip > 0)
                            {
                                if (iteratorLeft != leftHand.Count)  // Stops trying to remove cards from left stack once they are all shuffled in
                                {
                                    cardPack.RemoveAt(0);
                                    cardPack.Add(leftHand[iteratorLeft]);
                                    iterator--;
                                    iteratorLeft++;
                                }
                            }
                        }

                        if (rightHand.Count > 0)
                        {
                            if (coinFlip == 0)
                            {
                                if (iteratorRight != rightHand.Count)
                                {
                                    cardPack.RemoveAt(0);
                                    cardPack.Add(rightHand[iteratorRight]);   // Same logic as above but for right hand
                                    iterator--;
                                    iteratorRight++;
                                }
                            }
                        }
                    }
                    foreach (Card card in cardPack)
                    {
                        Console.WriteLine(card);
                    }
                    Console.WriteLine("I can shuffle now Dave");   // Prints shuffled deck
                    Console.WriteLine();

                    Console.WriteLine("Your shuffled pack above.");
                }
            }
        }
    }
    