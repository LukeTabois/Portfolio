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

        private List<Card> _communityCards;

        public IReadOnlyCollection<Card> CommunityCards
        {
            get
            {
                return _communityCards.AsReadOnly();
            }
        }

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
        private List<PokerPlayer> _players;

        public IReadOnlyCollection<PokerPlayer> Players
        {
            get
            {
                return _players.AsReadOnly();
            }
        }

        public PokerGame()
        {
            _deck = new Deck();
            _players = new List<PokerPlayer>();
            _communityCards = new List<Card>();
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
        // TODO: may need to be adjusted when betting is added
        public void Flop()
        {
            _communityCards.AddRange(_deck.Draw(3));
        }
        public void Turn()
        {
            _communityCards.AddRange(_deck.Draw(1));
        }
        public void River()
        {
            _communityCards.AddRange(_deck.Draw(1));
        }



        //TODO: method may need to be private as will be set internally at start of game
        //TODO: needs to handle changing of position throughout the game
        //TODO: when new players are added to the game
        //TODO: needs to handle when somone leave or cannot continue
        //TODO: needs to validate that it cannot be called mid round
        public void SetPlayersPositionsToDealer()
        {
            //TODO: this code will work for start of game
            for (int i = 0; i < _players.Count; i++)
            {
                _players[i].PositionToDealer = i;
            }
        }
        
        //TODO: can the player meet the minimum bet of the table
        //TODO: ensure player position is -1
        //TODO: check player is not duplicate of player at table
        //TODO: check if there is space at table for player to join
        public void Join(PokerPlayer playerToJoin)
        {
            _players.Add(playerToJoin);
        }

        // TODO: finish leave
        public void Leave(PokerPlayer playerToLeave)
        {
            _players.Remove(playerToLeave);
        }

    }

}
