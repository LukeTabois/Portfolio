using Microsoft.VisualBasic.Logging;
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

        public bool IsNewGame { get; set; }

        public Random DelayMaker { get; set; }


        public PokerPlayer HumanPlayer
        {
            get
            {
                return Poker.Players.Single(p => p.IsHuman == true);
            }
        }

        // player that is left of the screen
        private PokerPlayer leftPlayer;

        public PokerPlayer LeftPlayer
        {
            get 
            {
                if (leftPlayer != null && !Poker.ActivePlayers.Any(p => p.Email == leftPlayer.Email))
                {
                    leftPlayer = null;
                }
                return leftPlayer; 
            }
            set { leftPlayer = value; }
        }


        // player that is top of the screen
        private PokerPlayer topPlayer;

        public PokerPlayer TopPlayer
        {
            get
            {
                if (topPlayer != null && !Poker.ActivePlayers.Any(p => p.Email == topPlayer.Email))
                {
                    topPlayer = null;
                }
                return topPlayer;
            }
            set { topPlayer = value; }
        }

        // player that is right of the screen
        private PokerPlayer rightPlayer;

        public PokerPlayer RightPlayer
        {
            get
            {
                if (rightPlayer != null && !Poker.ActivePlayers.Any(p => p.Email == rightPlayer.Email))
                {
                    rightPlayer = null;
                }
                return rightPlayer;
            }
            set { rightPlayer = value; }
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
            // add it's your turn message to display log
            if (Poker.PositionOfPlayerToBet >= 0 && PlayerCurrentlyBetting.IsHuman == true && !PlayerCurrentlyBetting.HasFolded)
            {
                Poker.DisplayLog.Add("It's your turn");
            }

            // display message
            lblDisplayLog.Text = "";
            foreach (string entry in Poker.DisplayLog)
            {
                lblDisplayLog.Text = $"{lblDisplayLog.Text}{entry}{System.Environment.NewLine}";
                txtDisplayLog.Text = $"{txtDisplayLog.Text}{entry}{System.Environment.NewLine}";
            }
                        
            txtDisplayLog.Text = $"{txtDisplayLog.Text}{System.Environment.NewLine}";

            if (Poker.PositionOfPlayerToBet >= 0 && !PlayerCurrentlyBetting.HasFolded)
            {
                Poker.DisplayLog.Clear();
            }
            

            // scrolls to the bottom of the visable log
            txtDisplayLog.SelectionStart = txtDisplayLog.TextLength;
            txtDisplayLog.ScrollToCaret();

            // system log
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
                       

        private void DisplayPot()
        {
            lblPot.Text = Poker.Pot.ToString();
            imgPot.Image = Image.FromFile(DisplayStackImage(Poker.Pot));
        }
        
        private string DisplayStackImage(int stackAmount)
        {            

            if (stackAmount > 200)
            {
                return $"../../../images/chips/BluePokerChips9.png";
            }
            else if (stackAmount > 175 && stackAmount <= 200)
            {
                return $"../../../images/chips/BluePokerChips8.png";
            }
            else if (stackAmount > 150 && stackAmount <= 175)
            {
                return $"../../../images/chips/BluePokerChips7.png";
            }
            else if (stackAmount > 125 && stackAmount <= 150)
            {
                return $"../../../images/chips/BluePokerChips6.png";
            }
            else if (stackAmount > 100 && stackAmount <= 125)
            {
                return $"../../../images/chips/BluePokerChips5.png";
            }
            else if (stackAmount > 75 && stackAmount <= 100)
            {
                return $"../../../images/chips/BluePokerChips4.png";
            }
            else if (stackAmount > 50 && stackAmount <= 75)
            {
                return $"../../../images/chips/BluePokerChips3.png";
            }
            else if (stackAmount > 25 && stackAmount <= 50)
            {
                return $"../../../images/chips/BluePokerChips2.png";
            }
            else
            {
                return $"../../../images/chips/BluePokerChips1.png";
            }
        }


        private void InitialiseDisplayPlayerDetails()
        {
                               
            
            // get player for slot 1              if                 ?                     true      :           false
            int positionToDealerForTableSlotOne = (HumanPlayer.PositionToDealer == 0) ? 3 : HumanPlayer.PositionToDealer - 1;
            RightPlayer = Poker.ActivePlayers.SingleOrDefault(p => p.PositionToDealer == positionToDealerForTableSlotOne);
                        
            // get player for slot 3
            int positionToDealerForTableSlotThree = (HumanPlayer.PositionToDealer == 3) ? 0 : HumanPlayer.PositionToDealer + 1;
            LeftPlayer = Poker.ActivePlayers.SingleOrDefault(p => p.PositionToDealer == positionToDealerForTableSlotThree);
            
            // get player for slot 4
            int positionToDealerForTableSlotFour = (HumanPlayer.PositionToDealer <= 1) ? HumanPlayer.PositionToDealer + 2 : HumanPlayer.PositionToDealer - 2;
            TopPlayer = Poker.ActivePlayers.SingleOrDefault(p => p.PositionToDealer == positionToDealerForTableSlotFour);
            
        }


        private void UpdateDisplayPlayerDetails()
        {
            imgPlayerOneHighlight.Visible = false;
            imgPlayerThreeHighlight.Visible = false;
            imgPlayerFourHighlight.Visible = false;



            // put human into position 2
            if (string.IsNullOrWhiteSpace(lblPlayerTwoName.Text))
            {
                lblPlayerTwoName.Text = $"{HumanPlayer.Name}";
            }
            // dealer
            if (HumanPlayer.PositionToDealer == 0)
            {
                imgPlayerTwoDealer.Visible = true;

                imgPlayerOneDealer.Visible = false;
                imgPlayerThreeDealer.Visible = false;
                imgPlayerFourDealer.Visible = false;
            }
            // stack amount
            lblPlayerTwoStackAmount.Text = HumanPlayer.StackOfChips.ToString();
            imgPlayerTwoStack.Image = Image.FromFile(DisplayStackImage(HumanPlayer.StackOfChips));
            
            // player one details
            if (RightPlayer != null)
            {
                // label
                if (RightPlayer.Name != lblPlayerOneName.Text)
                {
                    lblPlayerOneName.Text = $"{RightPlayer.Name}";
                }
                // picture
                if (RightPlayer.HasFolded)
                {
                    imgPlayerOne.Image = Image.FromFile($"../../../images/players/{RightPlayer.Name}Folded.png");
                }
                else
                {
                    imgPlayerOne.Image = Image.FromFile($"../../../images/players/{RightPlayer.Name}.png");
                }
                // highlight
                if (RightPlayer.Name == PlayerCurrentlyBetting.Name && !RightPlayer.HasFolded)
                {
                    imgPlayerOneHighlight.Visible = true;
                }
                // dealer
                if (RightPlayer.PositionToDealer == 0)
                {
                    imgPlayerOneDealer.Visible = true;

                    imgPlayerTwoDealer.Visible = false;
                    imgPlayerThreeDealer.Visible = false;
                    imgPlayerFourDealer.Visible = false;
                }
                // stack amount
                lblPlayerOneStackAmount.Text = RightPlayer.StackOfChips.ToString();
                imgPlayerOneStack.Image = Image.FromFile(DisplayStackImage(RightPlayer.StackOfChips));
            }
            else
            {
                lblPlayerOneName.Text = $"";
                imgPlayerOne.Image = null;
                lblPlayerOneStackAmount.Text = "";
                imgPlayerOneStack.Image = null;
            }
            
            // player three details
            if (LeftPlayer != null)
            {
                // label
                if (LeftPlayer.Name != lblPlayerThreeName.Text)
                {
                    lblPlayerThreeName.Text = $"{LeftPlayer.Name}";
                }
                // picture
                if (LeftPlayer.HasFolded)
                {
                    imgPlayerThree.Image = Image.FromFile($"../../../images/players/{LeftPlayer.Name}Folded.png");
                }
                else
                {
                    imgPlayerThree.Image = Image.FromFile($"../../../images/players/{LeftPlayer.Name}.png");
                }
                // highlight
                if (LeftPlayer.Name == PlayerCurrentlyBetting.Name && !LeftPlayer.HasFolded)
                {
                    imgPlayerThreeHighlight.Visible = true;
                }
                // dealer
                if (LeftPlayer.PositionToDealer == 0)
                {
                    imgPlayerThreeDealer.Visible = true;

                    imgPlayerOneDealer.Visible = false;
                    imgPlayerTwoDealer.Visible = false;
                    imgPlayerFourDealer.Visible = false;
                }
                // stack amount
                lblPlayerThreeStackAmount.Text = LeftPlayer.StackOfChips.ToString();
                imgPlayerThreeStack.Image = Image.FromFile(DisplayStackImage(LeftPlayer.StackOfChips));
            }
            else
            {
                lblPlayerThreeName.Text = $"";
                imgPlayerThree.Image = null;
                lblPlayerThreeStackAmount.Text = "";
                imgPlayerThreeStack.Image = null;
            }

            // player four details
            if (TopPlayer != null)
            {
                // label
                if (TopPlayer.Name != lblPlayerFourName.Text)
                {
                    lblPlayerFourName.Text = $"{TopPlayer.Name}";
                }
                // picture
                if (TopPlayer.HasFolded)
                {
                    imgPlayerFour.Image = Image.FromFile($"../../../images/players/{TopPlayer.Name}Folded.png");
                }
                else
                {
                    imgPlayerFour.Image = Image.FromFile($"../../../images/players/{TopPlayer.Name}.png");
                }
                // highlight
                if (TopPlayer.Name == PlayerCurrentlyBetting.Name && !TopPlayer.HasFolded)
                {
                    imgPlayerFourHighlight.Visible = true;
                }
                // dealer
                if (TopPlayer.PositionToDealer == 0)
                {
                    imgPlayerFourDealer.Visible = true;

                    imgPlayerOneDealer.Visible = false;
                    imgPlayerTwoDealer.Visible = false;
                    imgPlayerThreeDealer.Visible = false;

                }
                // stack amount
                lblPlayerFourStackAmount.Text = TopPlayer.StackOfChips.ToString();
                imgPlayerFourStack.Image = Image.FromFile(DisplayStackImage(TopPlayer.StackOfChips));
            }
            else
            {
                lblPlayerFourName.Text = $"";
                imgPlayerFour.Image = null;
                lblPlayerFourStackAmount.Text = "";
                imgPlayerFourStack.Image = null;
            }

        }              
                
        //TODO: * What should we do if we (human player) runs out of chips, game over??        
        private async void UpdateUIAndAutoContinue()
        {
            
            DisplayCommunityCards();
            DisplayNewLogEntries();
            DisplayPot();
            UpdateDisplayPlayerDetails();

            int delay = 1000;
            if (!PlayerCurrentlyBetting.HasFolded)
            {
                //delay = DelayMaker.Next(4000, 10000);
            }
            await Task.Delay(delay);

            // continues to showdown if only the player is left
            if (Poker.InRoundPlayers.Count == 1)
            {
                Poker.ContinueGame();
                DisplayCommunityCards();
                DisplayNewLogEntries();
                DisplayPot();
                UpdateDisplayPlayerDetails();
            }

            // will continue playing until the human players turn
            if ((IsItHumanPlayersTurn == false || HumanPlayer.HasFolded == true) && Poker.isRoundInPlay == true)
            {
                Poker.ContinueGame();
                UpdateUIAndAutoContinue();
            }

            

            if (Poker.Stage == PokerStageOfGame.Ready)
            {
                if (Poker.ActivePlayers.Count == 1)
                {                    
                    btnStartHand.Visible = false;
                    //TODO: * update messages to who has won
                    if (MessageBox.Show("Someone Won, Would you like you another game?", "Game Over", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        //TODO: * add code to reset/start new game
                    }
                    else
                    {
                        this.Close();
                    }
                }
                else
                {
                    btnStartHand.Visible = true;
                }
                
            }
        }


        public Main()
        {

            InitializeComponent();

            IsNewGame = true;
            DelayMaker = new Random();
            // allow transparent overlay
            imgPlayerOne.Controls.Add(imgPlayerOneHighlight);
            imgPlayerOneHighlight.Location = new Point(0, 0);
            imgPlayerThree.Controls.Add(imgPlayerThreeHighlight);
            imgPlayerThreeHighlight.Location = new Point(0, 0);
            imgPlayerFour.Controls.Add(imgPlayerFourHighlight);
            imgPlayerFourHighlight.Location = new Point(0, 0);

            imgPlayerOneStack.Controls.Add(lblPlayerOneStackAmount);
            lblPlayerOneStackAmount.Location = new Point(0, 0);

            imgPlayerTwoStack.Controls.Add(lblPlayerTwoStackAmount);
            lblPlayerTwoStackAmount.Location = new Point(0, 0);

            imgPlayerThreeStack.Controls.Add(lblPlayerThreeStackAmount);
            lblPlayerThreeStackAmount.Location = new Point(0, 0);

            imgPlayerFourStack.Controls.Add(lblPlayerFourStackAmount);
            lblPlayerFourStackAmount.Location = new Point(0, 0);

            imgPot.Controls.Add(lblPot);
            lblPot.Location = new Point(0, 0);
        }

        

        private void Main_Load(object sender, EventArgs e)
        {
            try
            {
                // resets the UI ready for a new game
                lblPot.Text = "";
                lblDisplayLog.Text = "";
                lblErrorMessage.Text = "";                
                lblPlayerOneName.Text = "";
                lblPlayerTwoName.Text = "";
                lblPlayerThreeName.Text = "";
                lblPlayerFourName.Text = "";
                lblPlayerOneStackAmount.Text = "";
                lblPlayerTwoStackAmount.Text = "";
                lblPlayerThreeStackAmount.Text = "";
                lblPlayerFourStackAmount.Text = "";
                lblPlayerOneStackAmount.BringToFront();
                lblPlayerTwoStackAmount.BringToFront();
                lblPlayerThreeStackAmount.BringToFront();
                lblPlayerFourStackAmount.BringToFront();
                lblPot.BringToFront();
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
                btnStartHand.Visible = true;
                btnStartHand.BringToFront();
                btnCall.Visible = false;
                btnRaise.Visible = false;
                numRaiseAmount.Visible = false;
                btnFold.Visible = false;

                // create players
                //TODO: allow user to enter own name
                //TODO: allow user to choose avatar
                //TODO: allow user to configure AI players
                PokerPlayer playerOne = new PokerPlayer("Dianeemailaddress", "Diane", 0, false);
                PokerPlayer playerTwo = new PokerPlayer("Lukeemailaddress", "Luke", 100, true);
                PokerPlayer playerThree = new PokerPlayer("Ericemailaddress", "Eric", 15, false);
                PokerPlayer playerFour = new PokerPlayer("Billemailaddress", "Bill", 0, false);

                // create game and add players
                //TODO: allow user to set small blind
                Poker = new PokerGame(5);

                Poker.Join(playerTwo);
                Poker.Join(playerFour);
                Poker.Join(playerThree);
                Poker.Join(playerOne);


                DisplayNewLogEntries();

            }
            catch (Exception ex)
            {
                lblErrorMessage.Text = ex.Message;
            }
            
        }

        private void btnStartHand_Click(object sender, EventArgs e)
        {
            try
            {
                btnCall.Visible = true;
                btnRaise.Visible = true;
                numRaiseAmount.Visible = true;
                btnFold.Visible = true;

                //TODO: * show all hole cards at showdown                                                
                btnStartHand.Visible = false;

                // clears community cards ready for next game
                lblPot.Text = "0";
                imgCommunityCardOne.Image = null;
                imgCommunityCardTwo.Image = null;
                imgCommunityCardThree.Image = null;
                imgCommunityCardFour.Image = null;
                imgCommunityCardFive.Image = null;

                // reset, set position to dealer, deal, take blind 
                Poker.StartHand();
                if (IsNewGame == true)
                {
                    InitialiseDisplayPlayerDetails();
                    IsNewGame = false;
                }
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

        private void btnFold_Click(object sender, EventArgs e)
        {
            try
            {
                if (IsItHumanPlayersTurn && Poker.isRoundInPlay == true)
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
                if (IsItHumanPlayersTurn && Poker.isRoundInPlay == true)
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
                if (IsItHumanPlayersTurn && Poker.isRoundInPlay == true)
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

        

        
    }
}