using PokerLibrary.CardClasses;
using PokerLibrary.PlayerClasses;
using PokerLibrary.PokerClasses;

internal class Program
{
    public static void ShowHoleCards(PokerPlayer player)
    {
        foreach (Card holeCard in player.HoleCards)
        {
            Console.WriteLine($"{holeCard.Value} {holeCard.Suit}");
        }
        Console.WriteLine();
    }



    public static void ShowPlayerDetails(PokerGame poker)
    {
        foreach (PokerPlayer player in poker.Players)
        {
            PokerHand playerHand = player.GetHandValue(poker.CommunityCards.ToList());
            
            Console.WriteLine($"Name: {player.Name}");
            Console.WriteLine($"Position: {player.PositionToDealer}");
            Console.WriteLine($"Stack: {player.Stack}");
            Console.WriteLine($"Hole Cards: {player.HoleCards.First().ToString()} & {player.HoleCards.Last().ToString()}");
            Console.Write($"Hand Value: {Enum.GetName(typeof(PokerHandValue), playerHand.Hand)}");
            if (playerHand.Value != null)
            {
                Console.Write($", Value: {Enum.GetName(typeof(CardValue), playerHand.Value)}");
            }
            if (playerHand.SecondValue != null)
            {
                Console.Write($", Second Value: {Enum.GetName(typeof(CardValue), playerHand.SecondValue)}");
            }
            Console.WriteLine($", High Card: {Enum.GetName(typeof(CardValue), playerHand.HighCard)}");

            Console.WriteLine();
        }        
    }


    public static void ShowCommunityCards(PokerGame poker)
    {
        switch (poker.CommunityCards.Count)
        {
            case 3:
                Console.WriteLine($"After the flop the cards are....");
                break;
            case 4:
                Console.WriteLine($"After the turn the cards are....");
                break;
            case 5:
                Console.WriteLine($"After the river the cards are....");
                break;
            default:
                Console.WriteLine($"");
                break;
        }
        Console.WriteLine();

        foreach (Card card in poker.CommunityCards)
        {
            Console.WriteLine(card);            
        }
        
        Console.WriteLine();
        Console.WriteLine($"The number of cards left is {poker.NumberOfCardsInDeck}");
        Console.WriteLine();
    }

    public static void Main(string[] args)
    {
        //Card aceOfSpades = new Card(CardSuit.Spades, CardValue.Ace);

        //Console.WriteLine(aceOfSpades.ToString());

        //Card twoOfClubs = new Card(CardSuit.Clubs, CardValue.Two);

        //Console.WriteLine(aceOfSpades.Equals(twoOfClubs));

        // example of setting a custom format at construction of deck
        //Deck pokerDeck = new Deck("PPPPPPPPPPPAAAATRHHHHHH\\",$"rtyhl{Deck.CardValuePlaceholder}kdfghgh{Deck.CardSuitPlaceholder}.jpg", false);
        //Deck pokerDeck = new Deck();

        //foreach (Card card in pokerDeck.Cards)
        //{
        //    Console.WriteLine(card.Image);
        //}
        //Console.WriteLine();
        //Console.WriteLine(pokerDeck.Cards.Count);

        //List<Card> hand = pokerDeck.Draw(2);

        //foreach (Card card in hand)
        //{
        //    Console.WriteLine(card.Image);
        //}            

        //Console.WriteLine(pokerDeck.Cards.Count);


        //Card aceOfSpades = new Card(CardSuit.Spades, CardValue.Ace);
        //pokerDeck.Cards.Add(aceOfSpades);
        //Console.WriteLine(pokerDeck.Cards.Count);
        //pokerDeck.Cards = new List<Card> { aceOfSpades };

        //// create players                
        //PokerPlayer playerOne = new PokerPlayer("Luke");     
        //PokerPlayer playerTwo = new PokerPlayer("Diane");
        //PokerPlayer playerThree = new PokerPlayer("Eric");
        //PokerPlayer playerFour = new PokerPlayer("Bill");

        //// create game and add players
        //PokerGame poker = new PokerGame();        
        //poker.Join(playerOne);
        //poker.Join(playerTwo);
        //poker.Join(playerThree);
        //poker.Join(playerFour);

        //// deal
        //poker.Deal();
        //foreach (PokerPlayer player in poker.Players)
        //{            
        //    foreach (Card card in player.HoleCards)
        //    {                
        //        Console.WriteLine($"{player.Name} has been dealt {card}");
        //    }
        //    Console.WriteLine();
        //}
        //Console.WriteLine($"The number of cards left after dealing is {poker.NumberOfCardsInDeck}");
        //Console.WriteLine();

        //poker.Flop();
        //ShowCommunityCards(poker);

        //poker.Turn();
        //ShowCommunityCards(poker);

        //poker.River();
        //ShowCommunityCards(poker);






        //// create players                
        //PokerPlayer playerOne = new PokerPlayer("Luke", 100);
        //PokerPlayer playerTwo = new PokerPlayer("Diane", 100);
        //PokerPlayer playerThree = new PokerPlayer("Eric", 30);
        //PokerPlayer playerFour = new PokerPlayer("Bill", 100);
        //PokerPlayer playerFive = new PokerPlayer("Steven", 100);
        //PokerPlayer playerSix = new PokerPlayer("Robert", 100);

        //// create game and add players
        //PokerGame poker = new PokerGame(10);
        //poker.Join(playerOne);
        //poker.Join(playerTwo);
        //poker.Join(playerThree);
        //poker.Join(playerFour);

        //// position should be -1
        //ShowPlayerDetails(poker);
        //poker.StartRound();
        //// position should be 0 1 2 3
        //// Eric should be big blind 30 - 20 = 10
        //ShowPlayerDetails(poker);
        //poker.EndRound();
        //poker.StartRound();
        //// position should be 1 2 3 0
        //// Eric removed as cannot meet big blind
        //ShowPlayerDetails(poker);



        //poker.EndRound();
        //poker.Join(playerFive);
        //poker.Join(playerSix);
        //poker.StartRound();
        //// position should be 2 3 0 1 4 5
        //// added 2 players
        //ShowPlayerDetails(poker);



        //poker.EndRound();
        //poker.Leave(playerOne);
        //poker.StartRound();
        //// position should be 3 1 2 4 0   
        //// 1 player left
        //ShowPlayerDetails(poker);











        //List<Card> cards = new List<Card>(); 

        //PokerPlayer playerOne = new PokerPlayer("Luke", 100);

        //// hole
        //Deck pokerDeck = new Deck();
        //playerOne.SetHoleCards(pokerDeck);
        //ShowHoleCards(playerOne);
        //PokerHand hole = playerOne.GetHandValue(cards);
        //Console.WriteLine("hole");
        //Console.WriteLine($"Hand: {hole.Hand}. Value: {hole.Value}. High Card: {hole.HighCard}");
        //Console.WriteLine();

        //// flop
        //cards.Add(new Card(CardSuit.Spades, CardValue.Two));
        //cards.Add(new Card(CardSuit.Spades, CardValue.Nine));
        //cards.Add(new Card(CardSuit.Spades, CardValue.King));
        //PokerHand flop = playerOne.GetHandValue(cards);
        //Console.WriteLine("flop");
        //Console.WriteLine($"Hand: {flop.Hand}. Value: {flop.Value}. High Card: {flop.HighCard}");
        //Console.WriteLine();

        //// turn
        //cards.Add(new Card(CardSuit.Diamonds, CardValue.Two));
        //PokerHand turn = playerOne.GetHandValue(cards);
        //Console.WriteLine("turn");
        //Console.WriteLine($"Hand: {turn.Hand}. Value: {turn.Value}. High Card: {turn.HighCard}");
        //Console.WriteLine();

        //// river
        //cards.Add(new Card(CardSuit.Hearts, CardValue.Two));
        //PokerHand river = playerOne.GetHandValue(cards);
        //Console.WriteLine("river");
        //Console.WriteLine($"Hand: {river.Hand}. Value: {river.Value}. High Card: {river.HighCard}");
        //Console.WriteLine();









        // create players                
        PokerPlayer playerOne = new PokerPlayer("Luke", 100);
        PokerPlayer playerTwo = new PokerPlayer("Diane", 100);
        PokerPlayer playerThree = new PokerPlayer("Eric", 30);
        PokerPlayer playerFour = new PokerPlayer("Bill", 100);        

        // create game and add players
        PokerGame poker = new PokerGame(10);
        poker.Join(playerOne);
        poker.Join(playerTwo);
        poker.Join(playerThree);
        poker.Join(playerFour);

        poker.StartRound();
        poker.Deal();
        poker.Flop();
        poker.Turn();
        poker.River();
        PokerPlayer winningPlayer = poker.Showdown();

        ShowCommunityCards(poker);
        ShowPlayerDetails(poker);
        Console.WriteLine($"The Winning Player is {winningPlayer.Name}");
        
    }
}