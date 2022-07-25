using PokerLibrary;
using PokerLibrary.CardClasses;
using PokerLibrary.PlayerClasses;


internal class Program
{

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

        // create players                
        PokerPlayer playerOne = new PokerPlayer("Luke");     
        PokerPlayer playerTwo = new PokerPlayer("Diane");
        PokerPlayer playerThree = new PokerPlayer("Eric");
        PokerPlayer playerFour = new PokerPlayer("Bill");

        // create game and add players
        PokerGame poker = new PokerGame();
        // TODO: commented out as Player is readonly need to create own "add player" method
        //poker.Players.Add(playerOne);
        //poker.Players.Add(playerTwo);
        //poker.Players.Add(playerThree);
        //poker.Players.Add(playerFour);

        // deal
        poker.Deal();
        foreach (PokerPlayer player in poker.Players)
        {            
            foreach (Card card in player.HoleCards)
            {                
                Console.WriteLine($"{player.Name} has been dealt {card}");
            }
            Console.WriteLine();
        }
        Console.WriteLine($"The number of cards left after dealing is {poker.NumberOfCardsInDeck}");
        Console.WriteLine();

        poker.Flop();
        ShowCommunityCards(poker);

        poker.Turn();
        ShowCommunityCards(poker);

        poker.River();
        ShowCommunityCards(poker);











    }
}