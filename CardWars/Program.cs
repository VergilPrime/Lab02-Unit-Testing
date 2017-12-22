using System;

namespace War
{
    public class CardWars
    {
        public static void Main(string[] args)
        {
            string[] deck = {
                "h-2", "h-3", "h-4", "h-5", "h-6", "h-7",
                "h-8", "h-9", "h-10", "h-11", "h-12", "h-13", "h-14",
                "d-2", "d-3", "d-4", "d-5", "d-6", "d-7",
                "d-8", "d-9", "d-10", "d-11", "d-12", "d-13", "d-14",
                "s-2", "s-3", "s-4", "s-5", "s-6", "s-7",
                "s-8", "s-9", "s-10", "s-11", "s-12", "s-13", "s-14",
                "c-2", "c-3", "c-4", "c-5", "c-6", "c-7",
                "c-8", "c-9", "c-10", "c-11", "c-12", "c-13", "c-14"
            };

            int score = 0;

            Console.Write("Welcome to CardWars, press enter to draw a card.");
            Console.Read();

            while (true)
            {
                Random random = new Random();
                int pindex = random.Next(deck.Length);
                int oindex = random.Next(deck.Length);

                // some convoluted thing to make sure they arent the same index goes here

                string pcard = deck[pindex];
                string ocard = deck[oindex];



                Console.Clear();
                Console.WriteLine("You drew a " + CardDisplay(pcard) + ".");
                Console.Read();
                Console.WriteLine("The Opponent drew a " + CardDisplay(ocard) + ".");

                char[] seperator = { '-' };

                string[] psections = pcard.Split(seperator);
                int pvalue = int.Parse(psections[1]) * 10;

                switch (psections[0])
                {
                    case "s":
                        pvalue += 1;
                        break;
                    case "c":
                        pvalue += 2;
                        break;
                    case "d":
                        pvalue += 3;
                        break;
                    case "h":
                        pvalue += 4;
                        break;
                }

                string[] osections = ocard.Split(seperator);
                int ovalue = int.Parse(osections[1]) * 10;

                switch (osections[0])
                {
                    case "s":
                        ovalue += 1;
                        break;
                    case "c":
                        ovalue += 2;
                        break;
                    case "d":
                        ovalue += 3;
                        break;
                    case "h":
                        ovalue += 4;
                        break;
                }

                if (pvalue > ovalue)
                {
                    Console.WriteLine("You Win!");
                    score++;
                }
                else if (pvalue < ovalue)
                {
                    Console.WriteLine("The Opponent Won.");
                    score--;
                }
                else
                {
                    Console.WriteLine("It's a tie!");
                }
                Console.WriteLine("Your score is " + score + ".");
                Console.WriteLine("Press Enter to play again, or hold enter to speedplay.");
                Console.Read();
            }
        }

        public static string CardDisplay(string cardCode)
        {
            string suit = "";
            string value = "";

            char[] seperator = { '-' };
            string[] sections = cardCode.Split(seperator);
            string suitchar = sections[0];
            short valuenum = short.Parse(sections[1]);

            switch (suitchar)
            {
                case "h":
                    suit = "Hearts";
                    break;
                case "d":
                    suit = "Diamonds";
                    break;
                case "s":
                    suit = "Spades";
                    break;
                case "c":
                    suit = "Clubs";
                    break;
            }

            switch (valuenum)
            {
                case 2:
                    value = "Two";
                    break;
                case 3:
                    value = "Three";
                    break;
                case 4:
                    value = "Four";
                    break;
                case 5:
                    value = "Five";
                    break;
                case 6:
                    value = "Six";
                    break;
                case 7:
                    value = "Seven";
                    break;
                case 8:
                    value = "Eight";
                    break;
                case 9:
                    value = "Nine";
                    break;
                case 10:
                    value = "Ten";
                    break;
                case 11:
                    value = "Jack";
                    break;
                case 12:
                    value = "Queen";
                    break;
                case 13:
                    value = "King";
                    break;
                case 14:
                    value = "Ace";
                    break;
            }

            return value + " of " + suit;
        }
    }
}
