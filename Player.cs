using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace durakTesting
{
    public class Player
    {
        //private readonly PlayingCard[] card = new PlayingCard[5];
        //private List<List<PlayingCard>> playerHands = new List<List<PlayingCard>>();

        private List<PlayingCard> hand = new List<PlayingCard>();
        private String playerName;

        public Player()
        {
            Hand = null;
        }

        public Player(String playerName)
        {
            Hand = null;
            this.PlayerName = playerName;
        }



        public static bool playerAttacking;

        public List<PlayingCard> Hand { get => hand; set => hand = value; }
        public string PlayerName { get => playerName; set => playerName = value; }

        /// <summary>
        /// TakeCard - Method for taking a card from the pile
        /// </summary>
        public void TakeCard()
        {

        }
        /// <summary>
        /// PlayCard - Method for playing a card from hand
        /// </summary>
        virtual public void PlayCard()
        {
            char userInput = Console.ReadKey().KeyChar;
            if (userInput == '1')
            {
                Program.River.Add(Hand[0]);
            }
            else if (userInput == '2')
            {
                Program.River.Add(Hand[1]);
            }
            else if (userInput == '3')
            {
                Program.River.Add(Hand[2]);
            }
            else if (userInput == '4')
            {
                Program.River.Add(Hand[3]);
            }
            else if (userInput == '5')
            {
                Program.River.Add(Hand[4]);
            }
            else if (userInput == '6')
            {
                Program.River.Add(Hand[5]);
            }
            else if (userInput == 'S'|| userInput =='s')
            {
            }
        }

        public PlayingCard LowestCard(PlayingCard trumpCard)
        {
            //create playing card object to return
            PlayingCard theCard = null;

            //create list of playing cards to isolate for lowest card
            List<PlayingCard> cardsWithTrumpSuit = new List<PlayingCard>();

            //find all cards that match trump card suit
            foreach(PlayingCard card in this.Hand)
            {
                if (card.Suit == trumpCard.Suit)
                    cardsWithTrumpSuit.Add(card);
            }
            //find lowest card in cardsWithTrumpSuit if anything was added in cardsWithTrumpSuit
            if(cardsWithTrumpSuit.Count > 0)
            {
                //assume first card is the smallest
                PlayingCard minValueCard = cardsWithTrumpSuit[0];
                // iterate through the list to find the actual smallest card
                for (int i = 0; i <= cardsWithTrumpSuit.Count - 2; i++)
                {   
                    if (cardsWithTrumpSuit[i+1].Value < minValueCard.Value)
                    {
                        minValueCard = cardsWithTrumpSuit[i + 1];
                    }
                }
                theCard = minValueCard;
            }
            
            return theCard;
        }

        public void Dump()
        {
            Console.WriteLine(ToString());
        }

        public override String ToString()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append("\n******Player " + this.PlayerName +" Hand******");
            foreach (PlayingCard card in Hand)
            {
                builder.Append("\n" + card);
            }
            return builder.ToString();
        }


    }
}

