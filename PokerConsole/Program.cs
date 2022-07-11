using PokerLibrary.CardClasses;

internal class Program
{
    public static void Main(string[] args)
    {
        //Card aceOfSpades = new Card(CardSuit.Spades, CardValue.Ace);

        //Console.WriteLine(aceOfSpades.ToString());

        //Card twoOfClubs = new Card(CardSuit.Clubs, CardValue.Two);

        //Console.WriteLine(aceOfSpades.Equals(twoOfClubs));

        Deck pokerDeck = new Deck();

        //foreach (Card card in pokerDeck.Cards)
        //{
        //    Console.WriteLine(card.ToString());
        //}
        //Console.WriteLine();
        Console.WriteLine(pokerDeck.Cards.Count);

        List<Card> hand = pokerDeck.Draw(2);

        foreach (Card card in hand)
        {
            Console.WriteLine(card.ToString());
        }            

        Console.WriteLine(pokerDeck.Cards.Count);


        //Card aceOfSpades = new Card(CardSuit.Spades, CardValue.Ace);
        //pokerDeck.Cards.Add(aceOfSpades);
        //Console.WriteLine(pokerDeck.Cards.Count);
        //pokerDeck.Cards = new List<Card> { aceOfSpades };
    }
}