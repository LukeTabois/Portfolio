using PokerLibrary.CardClasses;
using PokerLibrary.PokerClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerLibrary.PlayerClasses
{
    public class PokerPlayer
    {
        public string Name { get; set; }

        //TODO: stack will probably have to be private
        public int Stack { get; set; }

        //TODO: do we need to lock this down more ???
        public int PositionToDealer { get; set; }


        private List<Card> _holeCards;

        public IReadOnlyCollection<Card> HoleCards
        {
            get
            {
                return _holeCards.AsReadOnly();
            }
        }

        public PokerPlayer(string name, int stack)
        {
            Name = name;
            _holeCards = new List<Card>();
            // set default to -1 rather than 0 as the dealer will be 0
            PositionToDealer = -1;
            Stack = stack;
        }

        public Deck SetHoleCards(Deck deck)
        {                 
            _holeCards.AddRange(deck.Draw(2));
            return deck;
        }
        
        public PokerHandValue GetHandValue(List<Card> communityCards)
        {
            // gets all cards to evaluate            
            List<Card> cards = new List<Card>();
            cards.AddRange(communityCards);
            cards.AddRange(_holeCards);

            // check no more than 7 cards (2 hole cards + 5 comm cards)
            if (cards.Count > 7)
            {                
                throw new ArgumentOutOfRangeException(nameof(cards), "Cannot get hand value for more than seven cards");
            }

            //TODO: GET HANDS VALUES!!!

            return PokerHandValue.HighCard;

        }
        
    }
}
