using PokerLibrary.CardClasses;
using PokerLibrary.PlayerClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PokerLibrary.PokerClasses
{
    public class ShowdownResult
    {
        public List<PokerPlayer> Winners { get; private set; }

        public int ShareOfPot { get; private set; }

        public int TipToDealer { get; private set; } = 0;

        public PokerHand WinningHand { get; set; }

        public ShowdownResult(List<PokerPlayer> winners, int shareOfPot, PokerHand winningHand)
        {
            Winners = winners;
            ShareOfPot = shareOfPot;
            WinningHand = winningHand;
        }

        public ShowdownResult(List<PokerPlayer> winners, int shareOfPot, PokerHand winningHand, int tipToDealer ) : this(winners, shareOfPot, winningHand)
        {
            TipToDealer = tipToDealer;
        }

        public override string ToString()
        {
            string message = "";

            message += "The winning players are ";            
            foreach (PokerPlayer player in Winners)
            {
                message += player.Name;
                if (Winners.Count > 1 && player.Name != Winners.Last().Name)
                {
                    message += ", ";
                }
                
            }
            message += $" with a {WinningHand.Hand}";
            if (WinningHand.SecondValue != null)
            {
                message += $"({WinningHand.Value} and {WinningHand.SecondValue})";
            }
            else if (WinningHand.Value != null)
            {
                message += $" of {WinningHand.Value}";
            }
            else
            {
                message += $"{WinningHand.HighCard}";
            }

            message += Environment.NewLine;
            message += $"The share of the pot is {ShareOfPot}";
            message += Environment.NewLine;
            if (TipToDealer > 0)
            {
                message += $"The house was tipped {TipToDealer}";
                message += Environment.NewLine;
            }


            return message;
        }
    }
}
