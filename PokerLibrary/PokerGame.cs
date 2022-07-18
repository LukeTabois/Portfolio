using PokerLibrary.CardClasses;
using PokerLibrary.PlayerClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerLibrary
{
    public class PokerGame
    {
        private Deck _deck;

        public int NumberOfCardsInDeck 
        { 
            get
            {
                return _deck.Cards.Count;
            }
        }

        //TODO: players cannot join mid round?
        //TODO: validate that there are at least 2 players per game?
        //TODO: limit player amount
        //TODO: VALIDATION RULES NEED REVIEW
        //TODO: maybe readonly collection with private field?
        public List<PokerPlayer> Players { get; private set; }

        public PokerGame()
        {
            _deck = new Deck();
            Players = new List<PokerPlayer>();
        }
        //TODO: optional constructor that will take a list of players

        //TODO: needs to validate that it cannot be called mid round
        public void Deal()
        {
            foreach (PokerPlayer player in Players)
            {
                _deck = player.SetHoleCards(_deck);
            }
            
        }

        //TODO: method may need to be private as will be set internally at start of game
        //TODO: needs to handle changing of position throughout the game
        //TODO: when new players are added to the game
        //TODO: needs to handle when somone leave or cannot continue
        //TODO: needs to validate that it cannot be called mid round
        public void SetPlayersPositionsToDealer()
        {
            //TODO: this code will work for start of game
            for (int i = 0; i < Players.Count; i++)
            {
                Players[i].PositionToDealer = i;
            }
        }
        
    }

}
