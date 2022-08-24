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
        private List<PokerPlayer> _players;
        public IReadOnlyCollection<PokerPlayer> Players
        {
            get
            {
                return _players.OrderBy(p => p.PositionToDealer).ToList().AsReadOnly();
            }
        }

        public IReadOnlyCollection<PokerPlayer> ActivePlayers
        {
            get
            {
                return _players.Where(p => p.PositionToDealer != -1).OrderBy(p => p.PositionToDealer).ToList().AsReadOnly();
            }
        }

        public IReadOnlyCollection<PokerPlayer> InactivePlayers
        {
            get
            {
                return _players.Where(p => p.PositionToDealer == -1).OrderBy(p => p.PositionToDealer).ToList().AsReadOnly();
            }
        }

        public bool isRoundInPlay { get; private set; }

        public PokerGame()
        {
            _deck = new Deck();
            _players = new List<PokerPlayer>();
            _communityCards = new List<Card>();
            isRoundInPlay = false;
        }
        //TODO: optional constructor that will take a list of players

        public void StartRound()
        {
            isRoundInPlay = true;
            SetPlayersPositionsToDealer();

        }

        public void EndRound()
        {
            isRoundInPlay = false;
        }

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
            // check if all player need a position
            bool areAllPlayerNew = true;
            foreach (PokerPlayer player in _players)
            {
                if(player.PositionToDealer != -1)
                {
                    areAllPlayerNew = false;
                }
            }

            // this code will work for start of game
            // assign all players a position
            if (areAllPlayerNew == true)
            {
                for (int i = 0; i < _players.Count; i++)
                {
                    _players[i].PositionToDealer = i;
                }
            }            
            // bump position up by 1
            else
            {                
                // add 1 to position existing players at table
                foreach (PokerPlayer player in ActivePlayers)
                {
                    if (player.PositionToDealer == ActivePlayers.Count -1)
                    {
                        // bump last player back up to 0
                        player.PositionToDealer = 0;
                    }
                    else
                    {
                        player.PositionToDealer++;
                    }                    
                }

                // new players joining table
                foreach (PokerPlayer player in InactivePlayers)
                {
                    player.PositionToDealer = ActivePlayers.Count;
                }

            }
        }
        
        //TODO: can the player meet the minimum bet of the table
        //TODO: ensure player position is -1
        //TODO: check player is not duplicate of player at table
        //TODO: check if there is space at table for player to join
        public void Join(PokerPlayer playerToJoin)
        {
            if (isRoundInPlay == true)
            {
                throw new Exception("Player cannot join mid round");
            }
            else
            {
                _players.Add(playerToJoin);
            }
            
        }

        // TODO: finish leave
        public void Leave(PokerPlayer playerToLeave)
        {
            if (isRoundInPlay == true)
            {
                throw new Exception("Player cannot leave mid round");
            }
            else
            {
                // if the player trying to leave is active
                if (playerToLeave.PositionToDealer != -1)
                {
                    // for everyone after the player leaving 
                    foreach (PokerPlayer player in ActivePlayers)
                    {
                        if (player.PositionToDealer > playerToLeave.PositionToDealer)
                        {
                            player.PositionToDealer--;
                        }
                    }
                }

                _players.Remove(playerToLeave);
            }
        }


        //TODO: NEXT SESSION
        // take big blind and small blind
        // we need players to have chips
        // we need a pot 




    }

}
