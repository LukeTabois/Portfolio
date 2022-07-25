using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerLibrary.CardClasses
{
    /// <summary>
    /// Represents a standard deck of 52 playing cards
    /// </summary>
    public class Deck
    {
        // initialise placeholders (DRY)
        // note: const = constant, THESE ARE STATIC, cannot ever be changed
        public const string CardValuePlaceholder = "<CARDVALUE>";
        public const string CardSuitPlaceholder = "<CARDSUIT>";

        // note: readonly can only be set in the constructor but can be different between objects        
        private readonly string _imagePath = "";
        private readonly string _imageFileNameFormat = $"{CardValuePlaceholder}_of_{CardSuitPlaceholder}.png";
        private readonly bool _isValueNumericForFormat = true;
        

        private List<Card> cards;

        /// <summary>
        /// Cards in the deck (read only)
        /// </summary>
        public IReadOnlyCollection<Card> Cards
        {
            get 
            {
                return cards.AsReadOnly(); 
            }            
        }

        /// <summary>
        /// Creates a standard deck of 52 playing cards using default location for images
        /// Note: the deck is shuffled
        /// </summary>
        public Deck()
        {            
            Reset();
        }

        /// <summary>
        /// Creates a standard deck of 52 playing cards using custom image location
        /// Note: the deck is shuffled
        /// </summary>
        /// <param name="imagePath">Determines the value for the file path</param>
        /// <param name="imageFileNameFormat">The format of card image file names to use, MUST CONTAIN <CARDVALUE> and <CARDSUIT></param>
        /// <param name="isValueNumericForFormat">Determines if the value for the file format should be text or number</param>
        public Deck(string imagePath, string imageFileNameFormat, bool isValueNumericForFormat)
        {
            if (!imageFileNameFormat.Contains(CardValuePlaceholder) || !imageFileNameFormat.Contains(CardSuitPlaceholder))
            {
                throw new FormatException($"image file name format does not contain both placeholders {CardValuePlaceholder} {CardSuitPlaceholder}");
            }
            _imagePath = imagePath; 
            _imageFileNameFormat = imageFileNameFormat;
            _isValueNumericForFormat = isValueNumericForFormat;
            Reset();
        }

        /// <summary>
        /// Draws a number of cards from the deck 
        /// </summary>
        /// <param name="numberOfCards">The number of cards to draw</param>
        /// <returns>The list of cards that were drawn</returns>
        /// <exception cref="ArgumentOutOfRangeException">Number of cards drawn must be more than 0 and less than the size of the deck</exception>
        public List<Card> Draw(int numberOfCards)
        {
            // throw error if drawing too many cards
            if (numberOfCards > cards.Count)
            {
                throw new ArgumentOutOfRangeException("Number of cards cannot exceed size of deck");
            }

            // check number of cards is bigger than zero
            if (numberOfCards <= 0)
            {
                throw new ArgumentOutOfRangeException("Number of cards cannot be less than the size of the deck");
            }
            
            

            List<Card> drawnCards = new List<Card>();

            // repeat based on amount of cards being drawn
            for (int i = 0; i < numberOfCards; i++)
            {
                // get the top card
                Card drawnCard = cards.First();

                // remove that taken card from the list
                cards.Remove(drawnCard);

                // add that taken card to another list
                drawnCards.Add(drawnCard);                
            }

            return drawnCards;
        }

        /// <summary>
        /// Shuffles this deck of cards
        /// </summary>
        public void Shuffle()
        {            
            cards = Extensions.Shuffle(cards);
        }

        /// <summary>
        /// Sets the deck back to a standard deck of 52 cards
        /// Note: the deck is shuffled
        /// </summary>
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
                    // get suit and value
                    CardSuit suit = (CardSuit)a;
                    CardValue value = (CardValue)b;
                    
                    // generate image file name from format and placeholders
                    string imageFileName;
                    if (_isValueNumericForFormat == true)
                    {
                        int cardNumericValue = (int)value;

                        if (cardNumericValue > 1 && cardNumericValue < 11)
                        {
                            imageFileName = $@"{_imagePath}{_imageFileNameFormat.Replace(CardValuePlaceholder, cardNumericValue.ToString())
                            .Replace(CardSuitPlaceholder, suit.ToString().ToLower())}";
                        }
                        else
                        {
                            imageFileName = $@"{_imagePath}{_imageFileNameFormat.Replace(CardValuePlaceholder, value.ToString().ToLower())
                            .Replace(CardSuitPlaceholder, suit.ToString().ToLower())}";
                        }
                    }
                    else
                    {
                        imageFileName = $@"{_imagePath}{_imageFileNameFormat.Replace(CardValuePlaceholder, value.ToString().ToLower())
                            .Replace(CardSuitPlaceholder, suit.ToString().ToLower())}";
                    }                                       

                    // adds 52 cards to list
                    Card cardToAdd = new Card(suit, value, imageFileName);
                    cards.Add(cardToAdd);
                }
            }
            Shuffle();
        }
    }

}
