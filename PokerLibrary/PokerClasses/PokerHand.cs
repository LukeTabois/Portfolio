using PokerLibrary.CardClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerLibrary.PokerClasses
{
    public class PokerHand 
    {
        public PokerHandValue Hand { get; private set; }

        public CardValue Value { get; private set; }

        public CardValue SecondValue { get; private set; }

        public CardValue HighCard { get; private set; }

        public PokerHand(PokerHandValue hand, CardValue highCard)
        {
            Hand = hand;            
            HighCard = highCard;
        }

        public PokerHand(PokerHandValue hand, CardValue highCard, CardValue value) : this(hand, highCard)
        {
            Value = value;            
        }

        public PokerHand(PokerHandValue hand, CardValue highCard, CardValue value, CardValue secondValue) : this(hand, highCard, value)
        {
            SecondValue = secondValue;
        }

    }
}
