using PokerLibrary.CardClasses;

namespace Poker
{
    public partial class Main : Form
    {
        public Deck PokerDeck { get; set; }

        public Main()
        {

            InitializeComponent();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            List<Card> hand = PokerDeck.Draw(1);
            lblTest.Text = hand.First().ToString();
            lblCardCount.Text = PokerDeck.Cards.Count.ToString();
            //imgTest.ImageLocation = $@"C:\training\DevOps\TwoBoys\Poker\Images\PlayingCards\{hand.First().Image}";
            imgTest.Image = Image.FromFile($"../../../images/playingcards/{hand.First().Image}");
        }

        private void Main_Load(object sender, EventArgs e)
        {
            PokerDeck = new Deck();
            lblCardCount.Text = PokerDeck.Cards.Count.ToString();
            lblTest.Text = "";
            //imgTest.Image = Image.FromFile();
            
        }
    }
}