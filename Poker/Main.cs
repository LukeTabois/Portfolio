using PokerLibrary.CardClasses;
using PokerLibrary.PlayerClasses;
using PokerLibrary.PokerClasses;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace Poker
{
    public partial class Main : Form
    {
        //imgTest.Image = Image.FromFile($"../../../images/playingcards/{hand.First().Image}");

        public PokerGame Poker { get; set; }

        private void DisplayNewLogEntries()
        {
            foreach (string entry in Poker.Log)
            {
                txtLog.Text = $"{txtLog.Text}{entry}";
            }
            txtLog.Text = $"{txtLog.Text}{System.Environment.NewLine}";
            Poker.Log.Clear();
        }

        public Main()
        {

            InitializeComponent();
        }

        

        private void Main_Load(object sender, EventArgs e)
        {
            try
            {
                lblErrorMessage.Text = "";

                // create players
                //TODO: allow user to enter own name
                //TODO: allow user to choose avatar
                //TODO: allow user to configure AI players
                PokerPlayer playerOne = new PokerPlayer("Lukeemailaddress", "Luke", 100, false);
                PokerPlayer playerTwo = new PokerPlayer("Dianeemailaddress", "Diane", 100, true);
                PokerPlayer playerThree = new PokerPlayer("Ericemailaddress", "Eric", 30, false);
                PokerPlayer playerFour = new PokerPlayer("Billemailaddress", "Bill", 100, false);

                // create game and add players
                //TODO: allow user to set small blind
                Poker = new PokerGame(5);
                Poker.Join(playerOne);
                Poker.Join(playerTwo);
                Poker.Join(playerThree);
                Poker.Join(playerFour);

                DisplayNewLogEntries();
            }
            catch (Exception ex)
            {
                lblErrorMessage.Text = ex.Message;
            }
            
        }

        private void btnStartGame_Click(object sender, EventArgs e)
        {
            try
            {
                // reset, set position to dealer, deal, take blind 
                Poker.StartGame();
                DisplayNewLogEntries();

                // show my hole cards
                PokerPlayer player = Poker.Players.Single(p => p.IsHuman == true);
                imgHoleCardOne.Image = Image.FromFile($"../../../images/playingcards/{player.HoleCards.First().Image}");
                imgHoleCardTwo.Image = Image.FromFile($"../../../images/playingcards/{player.HoleCards.Last().Image}");
            }
            catch (Exception ex)
            {
                lblErrorMessage.Text = ex.Message;                
            }
        }
    }
}