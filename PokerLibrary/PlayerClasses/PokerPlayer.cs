using PokerLibrary.CardClasses;
using PokerLibrary.PokerClasses;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace PokerLibrary.PlayerClasses
{
    public class PokerPlayer
    {
        // unique ID (for now)
        public string Email { get; set; }

        public string Name { get; set; }

        //TODO: stack will probably have to be private
        public int StackOfChips { get; set; }

        public int AmountBetInRound { get; set; }

        public bool BetPlacedInRound { get; set; } = false;

        //TODO: do we need to lock this down more ???
        public int PositionToDealer { get; set; }

        public bool IsHuman { get; set; }

        public bool HasFolded { get; private set; } = false;

        private List<Card> _holeCards;

        public IReadOnlyCollection<Card> HoleCards
        {
            get
            {
                return _holeCards.AsReadOnly();
            }
        }

        public PokerPlayer(string email, string name, int stack, bool isHuman)
        {
            Email = email;
            Name = name;
            _holeCards = new List<Card>();
            // set default to -1 rather than 0 as the dealer will be 0
            PositionToDealer = -1;
            StackOfChips = stack;
            IsHuman = isHuman;
        }

        public Deck SetHoleCards(Deck deck)
        {                 
            _holeCards.AddRange(deck.Draw(2));
            return deck;
        }
        
        public void ClearHoleCards()
        {
            _holeCards.Clear();
        }

        public PokerHand GetHandValue(List<Card> communityCards)
        {
            // gets all cards to evaluate            
            List<Card> cards = new List<Card>();
            cards.AddRange(communityCards);
            cards.AddRange(_holeCards);
            CardValue highCard = CardValue.Two;

            // get highest value of hole card ready for result
            foreach (Card card in _holeCards)
            {                
                if (card.Value > highCard)
                {
                    highCard = card.Value;
                }
            }

            // check no more than 7 cards (2 hole cards + 5 comm cards)
            if (cards.Count > 7)
            {                
                throw new ArgumentOutOfRangeException(nameof(cards), "Cannot get hand value for more than seven cards");
            }

            // put cards in order of value
            cards = cards.OrderByDescending(c => c.Value).ToList();
                       

            // check for royal flush down to high card (biggest value to smallest)
                                    
            bool isFlush = false;

            // initilising counter for suits           
            List<Card> flushCards = new List<Card>();
            // for each suit
            foreach (CardSuit suit in Enum.GetValues(typeof(CardSuit)))
            {
                // clears list for different suits
                flushCards.Clear();
                // for each card in poker hand
                foreach (Card card in cards)
                {
                    // check is the suit matches
                    if (suit == card.Suit)
                    {
                        // if suit matches add to list
                        flushCards.Add(card);

                    }
                }
                if (flushCards.Count >= 5)
                {
                    isFlush = true;                    
                    break;
                }
            }


            CardValue? fourOfAKind = null;
            CardValue? threeOfAKind = null;
            CardValue? pair = null;
            CardValue? secondPair = null;

            int ofAKindCounter = 0;
            // loops through types of card value ie king, queen, etc
            foreach (CardValue value in Enum.GetValues(typeof(CardValue)))
            {
                // set counter to 0 for each card value
                ofAKindCounter = 0;
                
                // for each card in hole cards plus community cards 
                foreach (Card card in cards)
                {
                    // check if the value matches
                    if (value == card.Value)
                    {
                        ofAKindCounter++;
                    }
                }

                // check if i have 4 of a kind 
                if (ofAKindCounter == 4)
                {
                    fourOfAKind = value;
                }
                // next check if i have 3 of a kind
                else if (ofAKindCounter == 3)
                {
                    threeOfAKind = value;
                }
                // next check if i have 2 of a kind
                else if (ofAKindCounter == 2)
                {                   

                    // if no pair has been found so far
                    if (pair == null)
                    {
                        // set pair
                        pair = value;
                    }
                    // if another pair has been found
                    else
                    {
                        // if this pair is of a greater value than the first pair
                        if (value > pair)
                        {
                            secondPair = pair;
                            pair = value;
                        }
                        else
                        {                            
                            // set second pair
                            secondPair = value;
                        }
                       
                    }
                   
                   
                }
            }


            bool isStraight = false;
            CardValue highestCardValueInStraight = cards.First().Value;
            // sets to the highest value in the list
            int previousCardValue = (int)cards.First().Value;
            // will count is cards are in descending order
            int straightCounter = 0;
            // loops through each card in cards list
            foreach (Card card in cards)
            {
                // checks if current card is the next lowest in the order
                if ((int)card.Value == previousCardValue - 1)
                {
                    straightCounter++;
                    
                }
                // handles if cards are not the same value
                else if((int)card.Value != previousCardValue)
                {
                    straightCounter = 0;
                    highestCardValueInStraight = card.Value;
                }

                previousCardValue = (int)card.Value;                
            }
            // if 5 or more cards are in direct descending order
            if (straightCounter >= 5)
            {
                isStraight = true;                
            }


            // do each check indivdually and worry about optimizing

            // royal flush (check for a flush, straight, check straight starts with ace)
            if (isFlush == true && isStraight == true && highestCardValueInStraight == CardValue.Ace)
            {               

                return new PokerHand(PokerHandValue.RoyalFlush, highCard);
            }
            // straight flush
            if (isFlush == true && isStraight == true)
            {
                return new PokerHand(PokerHandValue.StraightFlush, highCard, highestCardValueInStraight);
            }
            // four of a kind*
            if (fourOfAKind != null)
            {
                return new PokerHand(PokerHandValue.FourOfAKind, highCard, fourOfAKind.Value);
            }
            // full house*
            if (threeOfAKind != null && pair != null)
            {
                return new PokerHand(PokerHandValue.FullHouse, highCard, threeOfAKind.Value, pair.Value);
            }
            // flush
            if (isFlush == true)
            {
                return new PokerHand(PokerHandValue.Flush, highCard);
            }
            // straight
            if (isStraight == true)
            {
                return new PokerHand(PokerHandValue.Straight, highCard, highestCardValueInStraight);
            }
            // three of kind*
            if (threeOfAKind != null)
            {
                return new PokerHand(PokerHandValue.ThreeOfAKind, highCard, threeOfAKind.Value);
            }
            // two pair*
            if (pair != null && secondPair != null)
            {
                return new PokerHand(PokerHandValue.TwoPair, highCard, pair.Value, secondPair.Value);
            }
            // pair*
            if (pair != null)
            {
                return new PokerHand(PokerHandValue.Pair, highCard, pair.Value);
            }
            // high card

            return new PokerHand(PokerHandValue.HighCard, highCard);

        }

        public void PrepareForNewRound()
        {
            HasFolded = false;
            AmountBetInRound = 0;
            BetPlacedInRound = false;
        }
                
                
        public void Call(PokerGame pokerGame)
        {
            BetPlacedInRound = true;

            int amountRequiredToMeetBet = pokerGame.MinimumBet - AmountBetInRound;

            if (pokerGame.CheckIfPlayerBetIsValid(this, amountRequiredToMeetBet, out string errorMessage))
            {
                if (StackOfChips < amountRequiredToMeetBet)
                {
                    pokerGame.AddToPot(this, StackOfChips);
                    pokerGame.DisplayLog.Add($"{this.Name} has gone all in, {StackOfChips} was added to the pot");
                    pokerGame.Log.Add($"{this.Name} has gone all in, {StackOfChips} was added to the pot");
                    pokerGame.Log.Add($"The value of the pot is now {pokerGame.Pot}{Environment.NewLine}");
                }
                else if (amountRequiredToMeetBet == 0)
                {
                    pokerGame.DisplayLog.Add($"{this.Name} has checked");
                    pokerGame.Log.Add($"{this.Name} has checked");
                    pokerGame.Log.Add($"The value of the pot is still {pokerGame.Pot}{Environment.NewLine}");
                }
                else
                {
                    pokerGame.AddToPot(this, amountRequiredToMeetBet);
                    pokerGame.DisplayLog.Add($"{this.Name} has called, {amountRequiredToMeetBet} was added to the pot");
                    pokerGame.Log.Add($"{this.Name} has called, {amountRequiredToMeetBet} was added to the pot");
                    pokerGame.Log.Add($"The value of the pot is now {pokerGame.Pot}{Environment.NewLine}");
                }

                if (IsHuman)
                {
                    pokerGame.ContinueGame();
                }

                
            }
            else
            {
                //TODO: * manage to fire this exception
                 throw new Exception(errorMessage);
            }
            
            
        }

        public void Fold(PokerGame pokerGame)
        {
            BetPlacedInRound = true;

            // check exist has to be called here as it does not use add to pot
            bool exists = pokerGame.CheckInRoundPlayerExists(Email);
            if (exists == false)
            {
                throw new Exception($"Player with email {Email} does not exist in this game");
            }
            HasFolded = true;
            pokerGame.DisplayLog.Add($"{this.Name} has folded and is out of play{Environment.NewLine}");
            pokerGame.Log.Add($"{this.Name} has folded and is out of play{Environment.NewLine}");            

            if (IsHuman)
            {
                pokerGame.ContinueGame();
            }
        }

        public void Raise(PokerGame pokerGame, int amountToRaiseBy)
        {
            BetPlacedInRound = true;

            int amountRequiredToMeetBet = (pokerGame.MinimumBet + amountToRaiseBy) - AmountBetInRound;                                  

            // is the amount to raise higher than the big blind
            if (amountToRaiseBy < pokerGame.BigBlind)
            {
                throw new Exception("Raise ammount must at least meet big blind");
            }

            // check the amount to raise is not bigger than the biggest stack of players still in play
            if (amountToRaiseBy > pokerGame.LowestStackInPlay)
            {
                throw new Exception("Not all players can meet proposed raise amount");
            }

            if (pokerGame.CheckIfPlayerBetIsValid(this, amountRequiredToMeetBet, out string errorMessage))
            {
                pokerGame.MinimumBet = pokerGame.MinimumBet + amountToRaiseBy;
                pokerGame.AddToPot(this, amountRequiredToMeetBet);
                pokerGame.DisplayLog.Add($"{this.Name} has raised by {amountToRaiseBy}, {amountRequiredToMeetBet} was added to the pot");
                pokerGame.Log.Add($"{this.Name} has raised by {amountToRaiseBy}, {amountRequiredToMeetBet} was added to the pot");
                pokerGame.Log.Add($"The value of the pot is now {pokerGame.Pot}{Environment.NewLine}");

                if (IsHuman)
                {
                    pokerGame.ContinueGame();
                }

                
            }
            else
            {
                throw new Exception(errorMessage);
            }


        }

        // TODO: this is where the logic for AI happens
        public void ChooseBettingOption(PokerGame pokerGame)
        {
            Random random = new Random();
            int choice = random.Next(10);

            // raise 20% chance
            if (choice <= 1)
            {
                
                // this is for handling multiple raises
                int amountRequiredToMeetExistingBet = pokerGame.MinimumBet - AmountBetInRound;

                // calculate amount to raise by using big blind plus random number up to 10
                int amountToRaiseBy = (random.Next(10) + pokerGame.BigBlind);

                // sets amount to raise by to the lowest stack in play
                // when initial raise value is higher and the lowest value is greater than the big blind
                if (amountToRaiseBy > pokerGame.LowestStackInPlay && pokerGame.LowestStackInPlay > pokerGame.BigBlind)
                {
                    amountToRaiseBy = pokerGame.LowestStackInPlay;
                }
                
                // total chips that would have to added to the pot to raise successfully
                int totalAmount = amountRequiredToMeetExistingBet + amountToRaiseBy;

                // check player can meet existing amount plus raise
                // check all player can meet a raise
                if (totalAmount > StackOfChips || pokerGame.LowestStackInPlay < pokerGame.BigBlind)
                {
                    // if not call
                    Call(pokerGame);
                }
                else
                {
                    // if they can raise
                    Raise(pokerGame, amountToRaiseBy);
                }

            }
            // call 70% chance
            else if (choice >= 2 && choice <= 8)
            {
                Call(pokerGame);
            }
            // fold 10% chance
            else
            {
                Fold(pokerGame);
            }
        }

    }
}
