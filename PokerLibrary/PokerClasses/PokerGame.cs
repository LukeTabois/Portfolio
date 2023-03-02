using PokerLibrary.CardClasses;
using PokerLibrary.PlayerClasses;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Numerics;
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

        public int MinimumBet { get; set; }

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

        public IReadOnlyCollection<PokerPlayer> FoldedPlayers
        {
            get
            {
                return _players.Where(p => p.PositionToDealer != -1 && p.HasFolded == true).OrderBy(p => p.PositionToDealer).ToList().AsReadOnly();
            }
        }

        public IReadOnlyCollection<PokerPlayer> InRoundPlayers
        {
            get
            {
                return _players.Where(p => p.PositionToDealer != -1 && p.HasFolded == false).OrderBy(p => p.PositionToDealer).ToList().AsReadOnly();
            }
        }

        public int LowestStackInPlay 
        { 
            get
            {
                int lowestStack = InRoundPlayers.First().StackOfChips;                

                foreach (PokerPlayer player in InRoundPlayers)
                {
                    if (player.StackOfChips < lowestStack)
                    {
                        lowestStack = player.StackOfChips;
                    }
                }

                return lowestStack;
            }
        }

        public bool SkipToShowdown 
        { 
            get
            {
                return _players.Any(p => p.StackOfChips == 0);                
            }
        }


        public bool isRoundInPlay { get; private set; }

        public int PositionOfPlayerToBet { get; set; } = -1;

        public PokerStageOfGame Stage { get; set; }

        public List<string> Log { get; set; }

        public List<string> DisplayLog { get; set; }

        public PokerGame(int smallBlind)
        {
            _deck = new Deck();
            _players = new List<PokerPlayer>();
            _communityCards = new List<Card>();
            isRoundInPlay = false;
            Pot = 0;
            SmallBlind = smallBlind;
            MinimumBet = 0;
            Stage = PokerStageOfGame.Ready;
            Log = new List<string>();
            DisplayLog = new List<string>();
        }
        
        //TODO: needs to validate that it cannot be called mid round
        public void StartHand()
        {
            // reset properties ready for new game
            DisplayLog.Clear();
            Log.Clear();
            _communityCards.Clear();
            _deck.Reset();
            Pot = 0;

            // ensure that players can meet minimum bet amount 
            // and removes players that can't
            CheckPlayersCanMeetBigBlind();

            // set round in play flag to true to prevent players from leaving mid game
            isRoundInPlay = true;

            // set stage of game to deal
            Stage = PokerStageOfGame.Deal;

            // start game log
            Log.Add($"New hand started{Environment.NewLine}");

            // manages postion of players to dealer throughout a game
            // at this point add 1 to postion for existing players
            // and add joining players to the end
            SetPlayersPositionsToDealer();
            
            // takes small blind from posistion 1 and big blind from postion 2
            // for two player games takes small blind from 0 and big blind from 1
            TakeBlinds();

            // deals new hole cards to each player
            foreach (PokerPlayer player in Players)
            {
                player.ClearHoleCards();
                _deck = player.SetHoleCards(_deck);
                Log.Add($"{player.Name} was dealt hole cards");
            }
            Log.Add($"{Environment.NewLine}");
            DisplayLog.Add("- Hole Cards Dealt -");
            // set postion to player to bet to -1
            // so that a new round of betting is started rather than continuing
            PositionOfPlayerToBet = -1;

            // commented out as we will work on the UI interaction
            //Log.Add($"Start round of betting for hole cards{Environment.NewLine}");
            //RoundOfBetting();
        }
        // TODO: may need to be adjusted when betting is added
        public void Flop()
        {            
            Stage = PokerStageOfGame.Flop;
            DisplayLog.Add("- Flop Revealed -");
            Log.Add("Flop begins");
            List<Card> flop = _deck.Draw(3);
            foreach (Card card in flop)
            {
                Log.Add($"{card.ToString()} was revealed to the table");
            }
            Log.Add($"{Environment.NewLine}");
            _communityCards.AddRange(flop);
            // this will start a new round of betting rather than continuing
            PositionOfPlayerToBet = -1;
            Log.Add($"Start round of betting for flop{Environment.NewLine}");
            ContinueGame();
        }
        public void Turn()
        {
            Stage = PokerStageOfGame.Turn;
            DisplayLog.Add("- Turn Revealed -");
            Log.Add("Turn begins");
            List<Card> turn = _deck.Draw(1);
            foreach (Card card in turn)
            {
                Log.Add($"{card.ToString()} was revealed to the table");
            }
            Log.Add($"{Environment.NewLine}");
            _communityCards.AddRange(turn);
            // this will start a new round of betting rather than continuing
            PositionOfPlayerToBet = -1;
            Log.Add($"Start round of betting for turn{Environment.NewLine}");
            ContinueGame();
        }
        public void River()
        {
            Stage = PokerStageOfGame.River;
            DisplayLog.Add("- River Revealed -");
            Log.Add("River begins");
            List<Card> river = _deck.Draw(1);
            foreach (Card card in river)
            {
                Log.Add($"{card.ToString()} was revealed to the table");
            }
            Log.Add($"{Environment.NewLine}");
            _communityCards.AddRange(river);
            // this will start a new round of betting rather than continuing
            PositionOfPlayerToBet = -1;
            Log.Add($"Start round of betting for river{Environment.NewLine}");
            ContinueGame();
        }

        public void ContinueGame()
        {            
            // this is called at the beginning of each round of betting
            if (PositionOfPlayerToBet == -1)
            {
                if (ActivePlayers.Count > 2)
                {
                    // sets pointer to 1 to initialise loop on games with more than 2 players
                    PositionOfPlayerToBet = 1;
                }
                else
                {
                    // sets pointer to 0 to initialise loop on games with 2 players
                    PositionOfPlayerToBet = 0;
                }

                // if it's a new round of betting
                // and it's not a new game
                if (Stage != PokerStageOfGame.Deal)
                {
                    // set the minimum bet to 0 to allow for "checks"
                    MinimumBet = 0;
                }
                // if it's a new round of betting
                // and it's a new game
                else
                {
                    // set the minimum bet to the big blind for the very first round of betting
                    MinimumBet = BigBlind;
                }
                
                // for all active players resets their flag that says they have placed a bet
                // and resets amount they have bet for the round when it's not the deal
                foreach (PokerPlayer player in ActivePlayers)
                {
                    // we only do this when it is not the deal
                    // to ensure we don't overwrite the blinds
                    if (Stage != PokerStageOfGame.Deal)
                    {
                        player.AmountBetInRound = 0;
                    }
                    
                    player.BetPlacedInRound = false;
                }
            }


            // checks if there is only 1 player left in round of betting
            // this is to handle when everyone else has folded
            if (InRoundPlayers.Count == 1)
            {
                Log.Add("Only one player remains, move straight to showdown");
                Showdown();
            }
            // if there is more than 1 player left....
            else
            {                

                // gets current poker player
                // (active player where position to dealer is equal to postion of player to bet)
                PokerPlayer currentPlayerToBet = ActivePlayers.Single(p => p.PositionToDealer == PositionOfPlayerToBet);

                // updates loop pointer ready for next betting player
                // this needs to be done before betting options
                // so that it doesn't error when humans players break out the method
                if (PositionOfPlayerToBet == ActivePlayers.Count - 1)
                {
                    PositionOfPlayerToBet = 0;
                }
                else
                {
                    PositionOfPlayerToBet++;
                }

                // checks the current betting player has not folded
                if (currentPlayerToBet.HasFolded == false)
                {
                    // checks whether the current betting player is human or AI
                    if (currentPlayerToBet.IsHuman)
                    {                                                
                        // if the current betting player is human
                        // break out of the loop to allow player to choose their own betting option
                        // round of betting must be called to continue the the game once player has made their bet
                        return;
                    }
                    else
                    {
                        // if the current betting player is an AI
                        // automatically choose a betting option and let the game continue
                        currentPlayerToBet.ChooseBettingOption(this);                        
                    }
                }                

                // checks if all players in the round have placed a bet
                // we need this to determine if we continue betting or go to the next stage
                bool allPlayersPlacedBet = true;
                foreach (PokerPlayer player in InRoundPlayers)
                {
                    if (player.BetPlacedInRound == false)
                    {
                        allPlayersPlacedBet = false;
                    }
                }

                // checks if all players in the round have bet equal amounts
                // we need this to determine if we continue betting or go to the next stage
                bool allPlayersBetsMatch = true;
                int amountBetByEachPlayer = InRoundPlayers.First().AmountBetInRound;
                foreach (PokerPlayer player in InRoundPlayers)
                {
                    if (amountBetByEachPlayer != player.AmountBetInRound)
                    {
                        allPlayersBetsMatch = false;
                    }
                }

                // if all players have placed a bet and one player cannot continue to bet
                // then move straight on to the showdown
                if (allPlayersPlacedBet == true && SkipToShowdown == true)
                {
                    DisplayLog.Add("Not all players are able to meet the minimum bet so moved straight to showdown");
                    Log.Add("Not all players are able to meet the minimum bet so moved straight to showdown");
                    Showdown();
                }
                // if all players have placed bets and they are equal and all players can continue 
                // then move to the next stage (normal flow of play)
                else if (allPlayersPlacedBet == true && allPlayersBetsMatch == true && SkipToShowdown == false)
                {
                    // move onto next phase of the game
                    switch (Stage)
                    {
                        case PokerStageOfGame.Deal:
                            Flop();
                            break;
                        case PokerStageOfGame.Flop:
                            Turn();
                            break;
                        case PokerStageOfGame.Turn:
                            River();
                            break;
                        case PokerStageOfGame.River:
                            Showdown();
                            break;
                        default:
                            throw new Exception("Stage could not be resolved");
                            break;
                    }
                }
                // if all players have not placed a bet or the players bets are not equal
                else
                {
                    // commented out as we will work on the UI interaction
                    // triggers next person to bet
                    //RoundOfBetting();
                }

               
            }



            
                        
        }

        
        public bool CheckIfPlayerBetIsValid(PokerPlayer player, int amountToAdd, out string errorMessage)
        {
            errorMessage = null;

            bool exists = CheckInRoundPlayerExists(player.Email);
            if (exists == false)
            {
                errorMessage = ($"Player with email {player.Email} does not exist in this game");
                return false;
            }

            if (player.StackOfChips < amountToAdd)
            {
                errorMessage = ("Player does not have enough chips");
                return false;
            }

            return true;
        }





        // made internal so not acceisble out of DLL
        internal void AddToPot(PokerPlayer player, int amountToAdd)
        {
            bool isValid = CheckIfPlayerBetIsValid(player, amountToAdd, out string errorMessage);

            if (isValid == true)
            {
                Pot = Pot + amountToAdd;
                player.StackOfChips = player.StackOfChips - amountToAdd;
                player.AmountBetInRound = player.AmountBetInRound + amountToAdd;
            }
            else
            {
                throw new Exception(errorMessage);
            }
            
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
                // resets all players that may have folded in the previous round
                // TODO: need a way to reset player folded value
                player.PrepareForNewRound();

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
                    if (player.PositionToDealer == 0)
                    {
                        // bump first player back up to last
                        player.PositionToDealer = ActivePlayers.Count - 1;
                    }
                    else
                    {
                        player.PositionToDealer--;                        
                    }
                }

                // new players joining table
                foreach (PokerPlayer player in InactivePlayers)
                {
                    player.PositionToDealer = ActivePlayers.Count;
                }

            }

            foreach (PokerPlayer player in ActivePlayers)
            {
                if (player.PositionToDealer == 0)
                {
                    Log.Add($"{player.Name} is the dealer");
                }
                else
                {
                    Log.Add($"{player.Name} is {player.PositionToDealer} from the dealer");
                }
                 
            }
            Log.Add($"{Environment.NewLine}");
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

            foreach (PokerPlayer player in _players)
            {
                if (playerToJoin.Email == player.Email)
                {
                    throw new Exception($"Player with {player.Email} already exists in this game");
                }
            }
                        
            _players.Add(playerToJoin);
            //DisplayLog.Add($"{playerToJoin.Name} joined the table{Environment.NewLine}");
            Log.Add($"{playerToJoin.Name} joined the table{Environment.NewLine}");
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
                //DisplayLog.Add($"{playerToLeave.Name} left the table{Environment.NewLine}");
                Log.Add($"{playerToLeave.Name} left the table{Environment.NewLine}");
            }
        }
        //TODO: move small blind and big blind into start round as that is the first thing to happen??
        private void TakeBlinds()
        {
            if (ActivePlayers.Count() > 2)
            {
                foreach (PokerPlayer player in ActivePlayers)
                {
                    if (player.PositionToDealer == 1)
                    {
                        player.StackOfChips = player.StackOfChips - SmallBlind;
                        Pot = Pot + SmallBlind;
                        player.AmountBetInRound = SmallBlind;
                        Log.Add($"{player.Name} has put in the small blind of {SmallBlind}");
                    }
                    if (player.PositionToDealer == 2)
                    {
                        player.StackOfChips = player.StackOfChips - BigBlind;
                        Pot = Pot + BigBlind;
                        player.AmountBetInRound = BigBlind;
                        Log.Add($"{player.Name} has put in the big blind of {BigBlind}");
                    }
                }
            }
            else
            {
                foreach (PokerPlayer player in ActivePlayers)
                {
                    if (player.PositionToDealer == 0)
                    {
                        player.StackOfChips = player.StackOfChips - SmallBlind;
                        Pot = Pot + SmallBlind;
                        player.AmountBetInRound = SmallBlind;
                        Log.Add($"{player.Name} has put in the small blind of {SmallBlind}");
                    }
                    if (player.PositionToDealer == 1)
                    {
                        player.StackOfChips = player.StackOfChips - BigBlind;
                        Pot = Pot + BigBlind;
                        player.AmountBetInRound = BigBlind;
                        Log.Add($"{player.Name} has put in the big blind of {BigBlind}");
                    }
                }
            }
            Log.Add($"{Environment.NewLine}");
            
        }

        public bool CheckInRoundPlayerExists(string email)
        {
            foreach (PokerPlayer player in InRoundPlayers)
            {
                if (player.Email == email)
                {
                    return true;
                }                
            }
            return false;
        }

        private void CheckPlayersCanMeetBigBlind()
        {
            foreach (PokerPlayer player in _players.ToList())
            {
                if (player.StackOfChips < BigBlind)
                {
                    DisplayLog.Add($"{player.Name} can't meet the big blind so has left the table");
                    Log.Add($"{player.Name} cannot meet the big blind");
                    Leave(player);
                }
            }
        }

        //TODO: confirm if need to be private

        public void Showdown()
        {
            DisplayLog.Clear();
            Stage = PokerStageOfGame.Showdown;
            PokerHand currentPlayerHand;
            List<PokerPlayer> winningPlayers = new List<PokerPlayer> { InRoundPlayers.First() };
            PokerHand winningPlayerHand = winningPlayers.First().GetHandValue(_communityCards);

            foreach (PokerPlayer player in InRoundPlayers)
            {
                // ignore first player
                if (player != InRoundPlayers.First())
                {
                    currentPlayerHand = player.GetHandValue(_communityCards);
                    // if current hand is better than the best hand so far
                    if ((int)currentPlayerHand.Hand > (int)winningPlayerHand.Hand)
                    {
                        winningPlayers.Clear();
                        winningPlayers.Add(player);
                        winningPlayerHand = currentPlayerHand;
                    }
                    // if the current hand is the same as the best hand so far
                    else if ((int)currentPlayerHand.Hand == (int)winningPlayerHand.Hand)
                    {
                        // compares primary card value
                        if (currentPlayerHand.Value != null &&
                            (int)currentPlayerHand.Value > (int)winningPlayerHand.Value)
                        {
                            winningPlayers.Clear();
                            winningPlayers.Add(player);
                            winningPlayerHand = currentPlayerHand;
                        }
                        // if primary card values are the same 
                        else if (currentPlayerHand.Value != null && 
                                (int)currentPlayerHand.Value == (int)winningPlayerHand.Value)
                        {
                            // compares secondary card value if primary is the same
                            if (currentPlayerHand.SecondValue != null &&
                                (int)currentPlayerHand.SecondValue > (int)winningPlayerHand.SecondValue)
                            {
                                winningPlayers.Clear();
                                winningPlayers.Add(player);
                                winningPlayerHand = currentPlayerHand;
                            }
                            // if secondary card value is the same or does not exist
                            else if (currentPlayerHand.SecondValue == null ||
                                (int)currentPlayerHand.SecondValue == (int)winningPlayerHand.SecondValue)
                            {
                                // compares high card if primary and secondary (if present) is the same
                                if ((int)currentPlayerHand.HighCard > (int)winningPlayerHand.HighCard)
                                {
                                    winningPlayers.Clear();
                                    winningPlayers.Add(player);
                                    winningPlayerHand = currentPlayerHand;
                                }
                                // if players have the exact same hand add them to winning player list
                                else if ((int)currentPlayerHand.HighCard == (int)winningPlayerHand.HighCard)
                                {
                                    winningPlayers.Add(player);
                                }
                            }
                        }
                    }
                }
            }

            // int will only return the whole number no remainder
            int shareOfPot = Pot / winningPlayers.Count();
            // this will return a remainder if the pot cannot be equally split
            int tipToDealer = Pot % winningPlayers.Count();

            // gives each of the winning players a share of the pot (or 1 winner the whole pot)
            foreach (PokerPlayer player in winningPlayers)
            {
                player.StackOfChips = player.StackOfChips + shareOfPot;
            }
            
            ShowdownResult showdownResult;
            if (tipToDealer == 0)
            {
                showdownResult = new ShowdownResult(winningPlayers, shareOfPot, winningPlayerHand);
                
            }
            else
            {
                showdownResult = new ShowdownResult(winningPlayers, shareOfPot, winningPlayerHand, tipToDealer);              

            }

            DisplayLog.Add(showdownResult.ToString());
            Log.Add(showdownResult.ToString());           

            isRoundInPlay = false;            
            Stage = PokerStageOfGame.Ready;

            // this will kick players to help determine a winner
            CheckPlayersCanMeetBigBlind();


        }
                
        //TODO: NEXT SESSION
        
        // build user betting
       




    }

}
