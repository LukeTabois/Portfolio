using PokerLibrary.CardClasses;
using PokerLibrary.PlayerClasses;
using PokerLibrary.PokerClasses;

internal class Program
{

    public static void ShowLogEntries(PokerGame poker)
    {
        foreach (string logEntry in poker.Log)
        {
            Console.WriteLine(logEntry);
            Thread.Sleep(500);
        }
        Console.WriteLine();
        //ShowPlayerDetails(poker);
        //Console.WriteLine();
        poker.Log.Clear();
    }

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
            Console.WriteLine($"Has Folded: {player.HasFolded}");
            Console.WriteLine($"Stack: {player.StackOfChips}");
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
        // create players                
        PokerPlayer playerOne = new PokerPlayer("Lukeemailaddress", "Luke", 100, false);
        PokerPlayer playerTwo = new PokerPlayer("Dianeemailaddress", "Diane", 100, true);
        PokerPlayer playerThree = new PokerPlayer("Ericemailaddress", "Eric", 30, false);
        PokerPlayer playerFour = new PokerPlayer("Billemailaddress", "Bill", 100, false);

        // create game and add players
        PokerGame poker = new PokerGame(5);
        poker.Join(playerOne);
        poker.Join(playerTwo);
        poker.Join(playerThree);
        poker.Join(playerFour);

        bool playAgain = true;

        while (playAgain)
        {
            // run game until human players turn
            poker.StartGame();
            ShowLogEntries(poker);
            ShowHoleCards(playerTwo);

            while (poker.isRoundInPlay)
            {               

                // player to take turn
                bool isValidUserInput = false;
                while (isValidUserInput == false)
                {
                    Console.WriteLine("Please select a betting option Call/Check (c), Raise (r) or Fold (f)");
                    Console.WriteLine($"Your current hand value is {playerTwo.GetHandValue(poker.CommunityCards.ToList()).ToString()}");
                    string userInput = Console.ReadLine();

                    try
                    {
                        switch (userInput)
                        {
                            // call
                            case "c":
                                playerTwo.Call(poker);
                                isValidUserInput = true;
                                break;
                            // raise
                            case "r":
                                Console.WriteLine($"Please enter an amount you wish to raise by (you have {playerTwo.StackOfChips})");
                                string amountToRaiseByInput = Console.ReadLine();
                                bool isValidInt = int.TryParse(amountToRaiseByInput, out int amountToRaiseBy);
                                if (isValidInt)
                                {
                                    playerTwo.Raise(poker, amountToRaiseBy);
                                    isValidUserInput = true;
                                }
                                else
                                {
                                    Console.WriteLine("the amount to raise by is not valid");
                                }
                                break;
                            // fold
                            case "f":
                                playerTwo.Fold(poker);
                                isValidUserInput = true;
                                break;
                            default:
                                break;
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    Console.WriteLine();
                }

                ShowLogEntries(poker);
            }





            
                        

           
            // invite player to play another game
            Console.WriteLine("Do you want to play another game??");
            string answer = Console.ReadLine();

            if (answer != "y")
            {
                playAgain = false;
            }
            else
            {
                Console.Clear();
            }
        }       
        

    }
}