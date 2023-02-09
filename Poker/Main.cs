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

        public Random DelayMaker { get; set; }


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

        private void DisplayPlayerDetails()
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

            // get player for slot 1              if                 ?                     true      :           false
            int positionToDealerForTableSlotOne = (HumanPlayer.PositionToDealer == 0) ? 3 : HumanPlayer.PositionToDealer - 1;
            PokerPlayer playerOne = Poker.ActivePlayers.SingleOrDefault(p => p.PositionToDealer == positionToDealerForTableSlotOne);
            if (playerOne != null)
            {
                // label
                if (playerOne.Name != lblPlayerOneName.Text)
                {
                    lblPlayerOneName.Text = $"{playerOne.Name}";
                }
                // picture
                if (playerOne.HasFolded)
                {
                    imgPlayerOne.Image = Image.FromFile($"../../../images/players/{playerOne.Name}Folded.png");
                }
                else
                {
                    imgPlayerOne.Image = Image.FromFile($"../../../images/players/{playerOne.Name}.png");
                }
                // highlight
                if (playerOne.Name == PlayerCurrentlyBetting.Name && !playerOne.HasFolded)
                {
                    imgPlayerOneHighlight.Visible = true;
                }
                // dealer
                if (playerOne.PositionToDealer == 0)
                {
                    imgPlayerOneDealer.Visible = true;

                    imgPlayerTwoDealer.Visible = false;
                    imgPlayerThreeDealer.Visible = false;
                    imgPlayerFourDealer.Visible = false;
                }
                // stack amount
                lblPlayerOneStackAmount.Text = playerOne.StackOfChips.ToString();
                imgPlayerOneStack.Image = Image.FromFile(DisplayStackImage(playerOne.StackOfChips));
            }
            else
            {
                lblPlayerOneName.Text = $"";
                imgPlayerOne.Image = null;
                lblPlayerOneStackAmount.Text = "";
                imgPlayerOneStack.Image = null;
            }            

            // get player for slot 3
            int positionToDealerForTableSlotThree = (HumanPlayer.PositionToDealer == 3) ? 0 : HumanPlayer.PositionToDealer + 1;
            PokerPlayer playerThree = Poker.ActivePlayers.SingleOrDefault(p => p.PositionToDealer == positionToDealerForTableSlotThree);
            if (playerThree != null)
            {
                // label
                if (playerThree.Name != lblPlayerThreeName.Text)
                {
                    lblPlayerThreeName.Text = $"{playerThree.Name}";
                }
                // picture
                if (playerThree.HasFolded)
                {
                    imgPlayerThree.Image = Image.FromFile($"../../../images/players/{playerThree.Name}Folded.png");
                }
                else
                {
                    imgPlayerThree.Image = Image.FromFile($"../../../images/players/{playerThree.Name}.png");
                }
                // highlight
                if (playerThree.Name == PlayerCurrentlyBetting.Name && !playerThree.HasFolded)
                {
                    imgPlayerThreeHighlight.Visible = true;
                }
                // dealer
                if (playerThree.PositionToDealer == 0)
                {
                    imgPlayerThreeDealer.Visible = true;

                    imgPlayerOneDealer.Visible = false;
                    imgPlayerTwoDealer.Visible = false;
                    imgPlayerFourDealer.Visible = false;
                }
                // stack amount
                lblPlayerThreeStackAmount.Text = playerThree.StackOfChips.ToString();
                imgPlayerThreeStack.Image = Image.FromFile(DisplayStackImage(playerThree.StackOfChips));
            }
            else
            {
                lblPlayerThreeName.Text = $"";
                imgPlayerThree.Image = null;
                lblPlayerThreeStackAmount.Text = "";
                imgPlayerThreeStack.Image = null;
            }

            // get player for slot 4
            int positionToDealerForTableSlotFour = (HumanPlayer.PositionToDealer <= 1) ? HumanPlayer.PositionToDealer + 2 : HumanPlayer.PositionToDealer - 2;
            PokerPlayer playerFour = Poker.ActivePlayers.SingleOrDefault(p => p.PositionToDealer == positionToDealerForTableSlotFour);
            if (playerFour != null)
            {
                // label
                if (playerFour.Name != lblPlayerFourName.Text)
                {
                    lblPlayerFourName.Text = $"{playerFour.Name}";
                }
                // picture
                if (playerFour.HasFolded)
                {
                    imgPlayerFour.Image = Image.FromFile($"../../../images/players/{playerFour.Name}Folded.png");
                }
                else
                {
                    imgPlayerFour.Image = Image.FromFile($"../../../images/players/{playerFour.Name}.png");
                }
                // highlight
                if (playerFour.Name == PlayerCurrentlyBetting.Name && !playerFour.HasFolded)
                {
                    imgPlayerFourHighlight.Visible = true;
                }
                // dealer
                if (playerFour.PositionToDealer == 0)
                {
                    imgPlayerFourDealer.Visible = true;

                    imgPlayerOneDealer.Visible = false;
                    imgPlayerTwoDealer.Visible = false;
                    imgPlayerThreeDealer.Visible = false;

                }
                // stack amount
                lblPlayerFourStackAmount.Text = playerFour.StackOfChips.ToString();
                imgPlayerFourStack.Image = Image.FromFile(DisplayStackImage(playerFour.StackOfChips));
            }
            else
            {
                lblPlayerFourName.Text = $"";
                imgPlayerFour.Image = null;
                lblPlayerFourStackAmount.Text = "";
                imgPlayerFourStack.Image = null;
            }
            
        }
                
        //TODO: * stop players jumping round as people leave
        //TODO: * What should we do if we (human player) runs out of chips, game over??
        //TODO: * Declare winner when there is only one active player in the game
        private async void UpdateUIAndAutoContinue()
        {            
            DisplayCommunityCards();
            DisplayNewLogEntries();                        
            DisplayPot();
            DisplayPlayerDetails();    
            
            int delay = 1000;
            if (!PlayerCurrentlyBetting.HasFolded)
            {                
                //delay = DelayMaker.Next(4000, 10000);
            }
            await Task.Delay(delay);

            // will continue playing until the human players turn
            if ((IsItHumanPlayersTurn == false || HumanPlayer.HasFolded == true) && Poker.isRoundInPlay == true)
            {
                Poker.ContinueGame();
                UpdateUIAndAutoContinue();
            }

            if (Poker.Stage == PokerStageOfGame.Ready)
            {
                btnStartGame.Visible = true;
            }
        }


        public Main()
        {

            InitializeComponent();

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
                btnStartGame.Visible = true;
                btnStartGame.BringToFront();
                btnCall.Visible = false;
                btnRaise.Visible = false;
                numRaiseAmount.Visible = false;
                btnFold.Visible = false;

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

        private void btnStartGame_Click(object sender, EventArgs e)
        {
            try
            {
                btnCall.Visible = true;
                btnRaise.Visible = true;
                numRaiseAmount.Visible = true;
                btnFold.Visible = true;

                //TODO: * show all hole cards at showdown                                                
                btnStartGame.Visible = false;

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

        private void lblPlayerTwoName_Click(object sender, EventArgs e)
        {

        }
    }
}