using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerLibrary.CardClasses
{
    /// <summary>
    /// Represents a standard deck of 52 playing cards
    /// </summary>
    public class Deck
    {        
        private List<Card> cards;

        /// <summary>
        /// Cards in the deck (read only)
        /// </summary>
        public IReadOnlyCollection<Card> Cards
        {
            get 
            {
                return cards.AsReadOnly(); 
            }            
        }

        /// <summary>
        /// Creates a standard deck of 52 playing cards
        /// Note: the deck is shuffled
        /// </summary>
        public Deck()
        {
            Reset();
        }
               
        /// <summary>
        /// Draws a number of cards from the deck 
        /// </summary>
        /// <param name="numberOfCards">The number of cards to draw</param>
        /// <returns>The list of cards that were drawn</returns>
        /// <exception cref="ArgumentOutOfRangeException">Number of cards drawn must be more than 0 and less than the size of the deck</exception>
        public List<Card> Draw(int numberOfCards)
        {
            // throw error if drawing too many cards
            if (numberOfCards > cards.Count)
            {
                throw new ArgumentOutOfRangeException("Number of cards cannot exceed size of deck");
            }

            // check number of cards is bigger than zero
            if (numberOfCards <= 0)
            {
                throw new ArgumentOutOfRangeException("Number of cards cannot be less than the size of the deck");
            }

            List<Card> drawnCards = new List<Card>();

            // repeat based on amount of cards being drawn
            for (int i = 0; i < numberOfCards; i++)
            {
                // get the top card
                Card drawnCard = cards.First();

                // remove that taken card from the list
                cards.Remove(drawnCard);

                // add that taken card to another list
                drawnCards.Add(drawnCard);                
            }

            return drawnCards;
        }

        /// <summary>
        /// Shuffles this deck of cards
        /// </summary>
        public void Shuffle()
        {            
            cards = Extensions.Shuffle(cards);
        }

        /// <summary>
        /// Sets the deck back to a standard deck of 52 cards
        /// Note: the deck is shuffled
        /// </summary>
        public void Reset()
        {
            // creates the list
            cards = new List<Card>();

            // loops throuhg suits
            for (int a = 0; a < Enum.GetNames(typeof(CardSuit)).Length; a++)
            {
                // loops through value 
                // starts at 1 because no zero value on enum
                // added 1 to lenght to account for non zero based index
                for (int b = 1; b < Enum.GetNames(typeof(CardValue)).Length + 1; b++)
                {
                    // adds 52 cards to list
                    Card cardToAdd = new Card((CardSuit)a, (CardValue)b);
                    cards.Add(cardToAdd);
                }
            }
            Shuffle();
        }
    }

}
