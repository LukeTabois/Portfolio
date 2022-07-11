using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerLibrary.CardClasses
{
    public class Deck
    {        
        private List<Card> cards;

        public IReadOnlyCollection<Card> Cards
        {
            get 
            {
                return cards.AsReadOnly(); 
            }            
        }

        public Deck()
        {
            Reset();
        }

        //TODO: complete draw method
        public List<Card> Draw(int numberOfCards)
        {
            throw new NotImplementedException("Draw not written yet");
        }

        public void Shuffle()
        {
            cards.Shuffle();            
        }

        public void Reset()
        {
            // creates the list
            cards = new List<Card>();

            // loops throuhg suits
            for (int a = 0; a < Enum.GetNames(typeof(CardSuit)).Length; a++)
            {
                // loops through value 
                // starts at 1 because no zero value on enum
                // added 1 to lenght to account for non zero based index
                for (int b = 1; b < Enum.GetNames(typeof(CardValue)).Length + 1; b++)
                {
                    // adds 52 cards to list
                    Card cardToAdd = new Card((CardSuit)a, (CardValue)b);
                    cards.Add(cardToAdd);
                }
            }
            Shuffle();
        }
    }

}
