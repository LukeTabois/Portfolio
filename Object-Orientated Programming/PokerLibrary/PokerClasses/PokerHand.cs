using PokerLibrary.CardClasses;
using PokerLibrary.PlayerClasses;
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

        public CardValue? Value { get; private set; } = null;

        public CardValue? SecondValue { get; private set; } = null;

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

        public override string ToString()
        {
            string message = "";
                        
            message += $"{Hand} ";
            if (SecondValue != null)
            {
                message += $"({Value} and {SecondValue})";
            }
            else if (Value != null)
            {
                message += $"({Value})";
            }
            else
            {
                message += $"({HighCard})";
            }          

            return message;
        }
    }
}
