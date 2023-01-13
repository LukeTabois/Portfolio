using PokerLibrary.CardClasses;
using PokerLibrary.PlayerClasses;
using PokerLibrary.PokerClasses;
using System.Numerics;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace Poker
{
    public partial class Main : Form
    {
        //imgTest.Image = Image.FromFile($"../../../images/playingcards/{hand.First().Image}");

        public PokerGame Poker { get; set; }

        public PokerPlayer HumanPlayer
        {
            get
            {
                return Poker.Players.Single(p => p.IsHuman == true);
            }
        }

        private void DisplayNewLogEntries()
        {
            foreach (string entry in Poker.Log)
            {
                txtLog.Text = $"{txtLog.Text}{entry}{System.Environment.NewLine}";
            }
            txtLog.Text = $"{txtLog.Text}{System.Environment.NewLine}";
            Poker.Log.Clear();
        }

        private void DisplayCommunityCards()
        {
            // shows the community cards (0 based so 0 is the 1st card)
            switch (Poker.CommunityCards.Count)
            {
                case 3:
                    if (imgCommunityCardOne.Image == null)
                    {
                        imgCommunityCardOne.Image = Image.FromFile($"../../../images/playingcards/{Poker.CommunityCards.ElementAt(0).Image}");
                        imgCommunityCardTwo.Image = Image.FromFile($"../../../images/playingcards/{Poker.CommunityCards.ElementAt(1).Image}");
                        imgCommunityCardThree.Image = Image.FromFile($"../../../images/playingcards/{Poker.CommunityCards.ElementAt(2).Image}");
                    }                    
                    break;
                case 4:
                    if (imgCommunityCardFour.Image == null)
                    {
                        imgCommunityCardFour.Image = Image.FromFile($"../../../images/playingcards/{Poker.CommunityCards.ElementAt(3).Image}");
                    }                    
                    break;
                case 5:
                    if (imgCommunityCardFive.Image == null)
                    {
                        imgCommunityCardFive.Image = Image.FromFile($"../../../images/playingcards/{Poker.CommunityCards.ElementAt(4).Image}");
                    }                    
                    break;
                default:
                    break;
            }
                       
            
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
                imgHoleCardOne.Image = Image.FromFile($"../../../images/playingcards/{HumanPlayer.HoleCards.First().Image}");
                imgHoleCardTwo.Image = Image.FromFile($"../../../images/playingcards/{HumanPlayer.HoleCards.Last().Image}");

                // betting starts
                Poker.RoundOfBetting();
                DisplayNewLogEntries();

                
            }
            catch (Exception ex)
            {
                lblErrorMessage.Text = ex.Message;                
            }
        }


        //TODO: we need to check if it is the current players turn
        private void btnFold_Click(object sender, EventArgs e)
        {
            try
            {
                HumanPlayer.Fold(Poker);
                DisplayNewLogEntries();
                DisplayCommunityCards();
            }
            catch (Exception ex)
            {
                lblErrorMessage.Text = ex.Message;
            }
        }

        
    }
}