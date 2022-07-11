using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerLibrary.CardClasses
{
    public class Card
    {
        public CardSuit Suit { get; private set; }
        public CardValue Value { get; private set; }

        //TODO: add property for card image

        public Card(CardSuit cardSuit, CardValue cardValue)
        {
            Suit = cardSuit;
            Value = cardValue;
        }

        public override string ToString()
        {
            return $"{Value} of {Suit}";
        }

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
