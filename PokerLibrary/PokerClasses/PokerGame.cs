using PokerLibrary.CardClasses;
using PokerLibrary.PlayerClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerLibrary.PokerClasses
{
    public class PokerGame
    {
        private Deck _deck;

        private List<Card> _communityCards;

        public int Pot { get; private set; }

        public int SmallBlind { get; private set; }

        public int BigBlind
        {
            get
            {
                return SmallBlind * 2;
            }
        }


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

        public PokerGame(int smallBlind)
        {
            _deck = new Deck();
            _players = new List<PokerPlayer>();
            _communityCards = new List<Card>();
            isRoundInPlay = false;
            Pot = 0;
            SmallBlind = smallBlind;
        }
        //TODO: optional constructor that will take a list of players

        public void StartRound()
        {
            CheckPlayersCanMeetBigBlind();
            isRoundInPlay = true;
            SetPlayersPositionsToDealer();
            TakeBlinds();

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
                if (player.PositionToDealer != -1)
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
                    if (player.PositionToDealer == ActivePlayers.Count - 1)
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
        //TODO: move small blind and big blind into start round as that is the first thing to happen??
        private void TakeBlinds()
        {
            foreach (PokerPlayer player in ActivePlayers)
            {
                if (player.PositionToDealer == 1)
                {
                    player.Stack = player.Stack - SmallBlind;
                    Pot = Pot + SmallBlind;
                }
                if (player.PositionToDealer == 2)
                {
                    player.Stack = player.Stack - BigBlind;
                    Pot = Pot + BigBlind;
                }
            }
        }

        private void CheckPlayersCanMeetBigBlind()
        {
            foreach (PokerPlayer player in _players.ToList())
            {
                if (player.Stack < BigBlind)
                {
                    Leave(player);
                }
            }
        }

        //TODO: confirm if need to be private

        public PokerPlayer Showdown()
        {
            PokerHand currentPlayerHand;
            PokerPlayer winningPlayer = ActivePlayers.First();
            PokerHand winningPlayerHand = winningPlayer.GetHandValue(_communityCards);

            foreach (PokerPlayer player in ActivePlayers)
            {
                currentPlayerHand = player.GetHandValue(_communityCards);
                // if current hand is better than the best hand so far
                if ((int)currentPlayerHand.Hand > (int)winningPlayerHand.Hand)
                {
                    winningPlayer = player;
                    winningPlayerHand = currentPlayerHand;
                }
                // if the current hand is the same as the best hand so far
                else if ((int)currentPlayerHand.Hand == (int)winningPlayerHand.Hand)
                {                    
                    if(currentPlayerHand.Value != null)
                    {
                        if ((int)currentPlayerHand.Value > (int)winningPlayerHand.Value)
                        {
                            winningPlayer = player;
                            winningPlayerHand = currentPlayerHand;
                        }
                        else if (currentPlayerHand.SecondValue != null)
                        {
                            if ((int)currentPlayerHand.SecondValue > (int)winningPlayerHand.SecondValue)
                            {
                                winningPlayer = player;
                                winningPlayerHand = currentPlayerHand;
                            }
                        }
                    }
                    else if ((int)currentPlayerHand.HighCard > (int)winningPlayerHand.HighCard)
                    {
                        winningPlayer = player;
                        winningPlayerHand = currentPlayerHand; 
                    }
                    // Check Value(check it has one first, e.g.flush does not)
                    // Check Second Value(e.g.check it has one first e.g.one pair does not)
                    // Check High Card
                }
            }

            return winningPlayer;
        }
                
        //TODO: NEXT SESSION
        
        // showdown method
        // give/split pot to players




    }

}
