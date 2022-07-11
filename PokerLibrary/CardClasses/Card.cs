using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerLibrary.CardClasses
{
    /// <summary>
    /// Represents a singular card from a standard deck of cards
    /// </summary>
    public class Card
    {
        /// <summary>
        /// The suit of this card
        /// </summary>
        public CardSuit Suit { get; private set; }
        
        /// <summary>
        /// The value of this card
        /// </summary>
        public CardValue Value { get; private set; }

        //TODO: add property for card image

        /// <summary>
        /// Creates a standard playing card
        /// </summary>
        /// <param name="cardSuit">The suit of the card</param>
        /// <param name="cardValue">The value of the card</param>
        public Card(CardSuit cardSuit, CardValue cardValue)
        {
            Suit = cardSuit;
            Value = cardValue;
        }

        /// <summary>
        /// Gets the value and suit of this card as a string
        /// </summary>        
        public override string ToString()
        {
            return $"{Value} of {Suit}";
        }

        /// <summary>
        /// Check if this card is the same suit and value as another card
        /// </summary>
        /// <param name="obj">The card to compare to</param>
        /// <returns>True or false based on if the cards are the same</returns>
        public override bool Equals(object? obj)
        {
            // converting (casting) obj parameter to a Card
            Card card = obj as Card;

            // if obj is not a Card then false
            if (card == null)
            {
                return false;
            }

            // check if species name and type are the same
            if (card.Value == this.Value && card.Suit == this.Suit)
            {
                return true;
            }
            return false;
        }
        
    }
}
