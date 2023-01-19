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

        public PokerPlayer PlayerCurrentlyBetting 
        { 
            get
            {
                return Poker.ActivePlayers.Single(p => p.PositionToDealer == Poker.PositionOfPlayerToBet);
            }
        }

        public bool IsItHumanPlayersTurn
        {
            get
            {
                if (HumanPlayer.Name == PlayerCurrentlyBetting.Name)
                {
                    return true;
                }

                return false;
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

            // scrolls to the bottom of the visable log
            txtLog.SelectionStart = txtLog.TextLength;
            txtLog.ScrollToCaret();
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

        private void DisplayStageOfGame()
        {
            // this works when stage is one word
            lblStageOfGame.Text = Poker.Stage.ToString();
        }

        private void DisplayPlayerCurrentlyBetting()
        {
            lblCurrentPlayerTurn.Text = PlayerCurrentlyBetting.Name;
        }

        private void DisplayPlayerNames()
        {
            foreach (PokerPlayer player in Poker.ActivePlayers)
            {
                switch (player.PositionToDealer)
                {
                    case 0:
                        if (string.IsNullOrWhiteSpace(lblPlayerOneName.Text))
                        {
                            lblPlayerOneName.Text = player.Name;
                        }                        
                        break;
                    case 1:
                        if (string.IsNullOrWhiteSpace(lblPlayerTwoName.Text))
                        {
                            lblPlayerTwoName.Text = player.Name;
                        }                        
                        break;
                    case 2:
                        if (string.IsNullOrWhiteSpace(lblPlayerThreeName.Text))
                        {
                            lblPlayerThreeName.Text = player.Name;
                        }                        
                        break;
                    case 3:
                        if (string.IsNullOrWhiteSpace(lblPlayerFourName.Text))
                        {
                            lblPlayerFourName.Text = player.Name;
                        }                        
                        break;
                    default:
                        throw new Exception("More players than expected");
                        break;
                }
            }
        }

        private void DisplayStackAndPotAmounts()
        {
            lblPot.Text = Poker.Pot.ToString();
        }

        private void DisplayPlayerImages()
        {
            // show/hide image
        }

        private void DisplayPlayerTurn()
        {
            // show/hide image
        }

        private void DisplayCurrentDealer()
        {
            // show/hide image
        }

        private async void UpdateUIAndAutoContinue()
        {            
            DisplayCommunityCards();
            DisplayNewLogEntries();
            DisplayStageOfGame();
            DisplayPlayerCurrentlyBetting();
            DisplayPlayerNames();
            DisplayStackAndPotAmounts();
            DisplayPlayerImages();
            DisplayPlayerTurn();
            DisplayCurrentDealer();
            await Task.Delay(3000);
            //Thread.Sleep(3000);

            // will continue playing until the human players turn
            if ((IsItHumanPlayersTurn == false || HumanPlayer.HasFolded == true) && Poker.isRoundInPlay == true)
            {
                Poker.ContinueGame();
                UpdateUIAndAutoContinue();
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
                // resets the UI ready for a new game
                lblPot.Text = "0";
                lblErrorMessage.Text = "";
                lblStageOfGame.Text = "";
                lblCurrentPlayerTurn.Text = "";
                lblPlayerOneName.Text = "";
                lblPlayerTwoName.Text = "";
                lblPlayerThreeName.Text = "";
                lblPlayerFourName.Text = "";
                imgPlayerOneHighlight.BringToFront();
                imgPlayerThreeHighlight.BringToFront();
                imgPlayerFourHighlight.BringToFront();
                imgPlayerOneHighlight.Visible = false;
                imgPlayerThreeHighlight.Visible = false;
                imgPlayerFourHighlight.Visible = false;
                imgPlayerOneDealer.BringToFront();
                imgPlayerTwoDealer.BringToFront();
                imgPlayerThreeDealer.BringToFront();
                imgPlayerFourDealer.BringToFront();
                imgPlayerOneDealer.Visible = false;
                imgPlayerTwoDealer.Visible = false;
                imgPlayerThreeDealer.Visible = false;
                imgPlayerFourDealer.Visible = false;


                // create players
                //TODO: allow user to enter own name
                //TODO: allow user to choose avatar
                //TODO: allow user to configure AI players
                PokerPlayer playerOne = new PokerPlayer("Dianeemailaddress", "Diane", 100, false);
                PokerPlayer playerTwo = new PokerPlayer("Lukeemailaddress", "Luke", 100, true);
                PokerPlayer playerThree = new PokerPlayer("Ericemailaddress", "Eric", 100, false);
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
                // clears community cards ready for next game
                lblPot.Text = "0";
                imgCommunityCardOne.Image = null;
                imgCommunityCardTwo.Image = null;
                imgCommunityCardThree.Image = null;
                imgCommunityCardFour.Image = null;
                imgCommunityCardFive.Image = null;

                // reset, set position to dealer, deal, take blind 
                Poker.StartGame();
                DisplayNewLogEntries();

                // show my hole cards                
                imgHoleCardOne.Image = Image.FromFile($"../../../images/playingcards/{HumanPlayer.HoleCards.First().Image}");
                imgHoleCardTwo.Image = Image.FromFile($"../../../images/playingcards/{HumanPlayer.HoleCards.Last().Image}");

                // betting starts
                Poker.ContinueGame();
                UpdateUIAndAutoContinue();


                
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
                if (IsItHumanPlayersTurn)
                {
                    HumanPlayer.Fold(Poker);
                    UpdateUIAndAutoContinue();
                }
                else
                {
                    MessageBox.Show("Not currently your turn", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                lblErrorMessage.Text = ex.Message;
            }
        }

        private void btnRaise_Click(object sender, EventArgs e)
        {
            try
            {
                if (IsItHumanPlayersTurn)
                {
                    HumanPlayer.Raise(Poker, Convert.ToInt32(numRaiseAmount.Value));
                    UpdateUIAndAutoContinue();
                }
                else
                {
                    MessageBox.Show("Not currently your turn", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                lblErrorMessage.Text = ex.Message;
            }
        }

        private void btnCall_Click(object sender, EventArgs e)
        {
            try
            {
                if (IsItHumanPlayersTurn)
                {
                    HumanPlayer.Call(Poker);
                    UpdateUIAndAutoContinue();
                }
                else
                {
                    MessageBox.Show("Not currently your turn", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);                        
                }
            }
            catch (Exception ex)
            {
                lblErrorMessage.Text = ex.Message;
            }
        }

        private void btnContinuePlay_Click(object sender, EventArgs e)
        {
            try
            {
                Poker.ContinueGame();
                UpdateUIAndAutoContinue();
            }
            catch (Exception ex)
            {
                lblErrorMessage.Text = ex.Message;
            }
            
        }

        
    }
}