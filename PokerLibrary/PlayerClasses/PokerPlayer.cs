using PokerLibrary.CardClasses;
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

        public int PositionToDealer { get; set; }

        private List<Card> _holeCards;

        public IReadOnlyCollection<Card> HoleCards
        {
            get
            {
                return _holeCards.AsReadOnly();
            }
        }

        public PokerPlayer(string name)
        {
            Name = name;
            _holeCards = new List<Card>();
            // set default to -1 rather than 0 as the dealer will be 0
            PositionToDealer = -1;
        }

        public Deck SetHoleCards(Deck deck)
        {                 
            _holeCards.AddRange(deck.Draw(2));
            return deck;
        }

    }
}
