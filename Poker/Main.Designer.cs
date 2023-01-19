namespace Poker
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.btnStartGame = new System.Windows.Forms.Button();
            this.lblErrorMessage = new System.Windows.Forms.Label();
            this.imgTest = new System.Windows.Forms.PictureBox();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.imgHoleCardOne = new System.Windows.Forms.PictureBox();
            this.imgHoleCardTwo = new System.Windows.Forms.PictureBox();
            this.btnCall = new System.Windows.Forms.Button();
            this.btnRaise = new System.Windows.Forms.Button();
            this.btnFold = new System.Windows.Forms.Button();
            this.imgCommunityCardOne = new System.Windows.Forms.PictureBox();
            this.imgCommunityCardTwo = new System.Windows.Forms.PictureBox();
            this.imgCommunityCardThree = new System.Windows.Forms.PictureBox();
            this.imgCommunityCardFour = new System.Windows.Forms.PictureBox();
            this.imgCommunityCardFive = new System.Windows.Forms.PictureBox();
            this.numRaiseAmount = new System.Windows.Forms.NumericUpDown();
            this.lblStageOfGame = new System.Windows.Forms.Label();
            this.lblCurrentPlayerTurn = new System.Windows.Forms.Label();
            this.btnContinuePlay = new System.Windows.Forms.Button();
            this.lblPlayerOneName = new System.Windows.Forms.Label();
            this.lblPlayerTwoName = new System.Windows.Forms.Label();
            this.lblPlayerThreeName = new System.Windows.Forms.Label();
            this.lblPlayerFourName = new System.Windows.Forms.Label();
            this.lblPot = new System.Windows.Forms.Label();
            this.imgPlayerFour = new System.Windows.Forms.PictureBox();
            this.imgPlayerOne = new System.Windows.Forms.PictureBox();
            this.imgPlayerThree = new System.Windows.Forms.PictureBox();
            this.imgPlayerFourHighlight = new System.Windows.Forms.PictureBox();
            this.imgPlayerOneHighlight = new System.Windows.Forms.PictureBox();
            this.imgPlayerThreeHighlight = new System.Windows.Forms.PictureBox();
            this.imgPlayerOneDealer = new System.Windows.Forms.PictureBox();
            this.imgPlayerTwoDealer = new System.Windows.Forms.PictureBox();
            this.imgPlayerThreeDealer = new System.Windows.Forms.PictureBox();
            this.imgPlayerFourDealer = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgTest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgHoleCardOne)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgHoleCardTwo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCommunityCardOne)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCommunityCardTwo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCommunityCardThree)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCommunityCardFour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCommunityCardFive)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRaiseAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPlayerFour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPlayerOne)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPlayerThree)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPlayerFourHighlight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPlayerOneHighlight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPlayerThreeHighlight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPlayerOneDealer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPlayerTwoDealer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPlayerThreeDealer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPlayerFourDealer)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStartGame
            // 
            this.btnStartGame.Location = new System.Drawing.Point(12, 12);
            this.btnStartGame.Name = "btnStartGame";
            this.btnStartGame.Size = new System.Drawing.Size(75, 23);
            this.btnStartGame.TabIndex = 0;
            this.btnStartGame.Text = "Start Game";
            this.btnStartGame.UseVisualStyleBackColor = true;
            this.btnStartGame.Click += new System.EventHandler(this.btnStartGame_Click);
            // 
            // lblErrorMessage
            // 
            this.lblErrorMessage.AutoSize = true;
            this.lblErrorMessage.BackColor = System.Drawing.Color.Transparent;
            this.lblErrorMessage.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblErrorMessage.ForeColor = System.Drawing.Color.Red;
            this.lblErrorMessage.Location = new System.Drawing.Point(93, 12);
            this.lblErrorMessage.Name = "lblErrorMessage";
            this.lblErrorMessage.Size = new System.Drawing.Size(58, 20);
            this.lblErrorMessage.TabIndex = 2;
            this.lblErrorMessage.Text = "lblError";
            // 
            // imgTest
            // 
            this.imgTest.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imgTest.Image = ((System.Drawing.Image)(resources.GetObject("imgTest.Image")));
            this.imgTest.InitialImage = null;
            this.imgTest.Location = new System.Drawing.Point(1022, 12);
            this.imgTest.Name = "imgTest";
            this.imgTest.Size = new System.Drawing.Size(100, 150);
            this.imgTest.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgTest.TabIndex = 3;
            this.imgTest.TabStop = false;
            // 
            // txtLog
            // 
            this.txtLog.BackColor = System.Drawing.Color.Black;
            this.txtLog.ForeColor = System.Drawing.Color.White;
            this.txtLog.Location = new System.Drawing.Point(0, 516);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLog.Size = new System.Drawing.Size(403, 117);
            this.txtLog.TabIndex = 4;
            // 
            // imgHoleCardOne
            // 
            this.imgHoleCardOne.BackColor = System.Drawing.Color.Transparent;
            this.imgHoleCardOne.Location = new System.Drawing.Point(409, 516);
            this.imgHoleCardOne.Name = "imgHoleCardOne";
            this.imgHoleCardOne.Size = new System.Drawing.Size(100, 150);
            this.imgHoleCardOne.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgHoleCardOne.TabIndex = 5;
            this.imgHoleCardOne.TabStop = false;
            // 
            // imgHoleCardTwo
            // 
            this.imgHoleCardTwo.BackColor = System.Drawing.Color.Transparent;
            this.imgHoleCardTwo.Location = new System.Drawing.Point(515, 516);
            this.imgHoleCardTwo.Name = "imgHoleCardTwo";
            this.imgHoleCardTwo.Size = new System.Drawing.Size(100, 150);
            this.imgHoleCardTwo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgHoleCardTwo.TabIndex = 6;
            this.imgHoleCardTwo.TabStop = false;
            // 
            // btnCall
            // 
            this.btnCall.Location = new System.Drawing.Point(644, 535);
            this.btnCall.Name = "btnCall";
            this.btnCall.Size = new System.Drawing.Size(75, 23);
            this.btnCall.TabIndex = 7;
            this.btnCall.Text = "Call";
            this.btnCall.UseVisualStyleBackColor = true;
            this.btnCall.Click += new System.EventHandler(this.btnCall_Click);
            // 
            // btnRaise
            // 
            this.btnRaise.Location = new System.Drawing.Point(644, 564);
            this.btnRaise.Name = "btnRaise";
            this.btnRaise.Size = new System.Drawing.Size(75, 23);
            this.btnRaise.TabIndex = 8;
            this.btnRaise.Text = "Raise";
            this.btnRaise.UseVisualStyleBackColor = true;
            this.btnRaise.Click += new System.EventHandler(this.btnRaise_Click);
            // 
            // btnFold
            // 
            this.btnFold.Location = new System.Drawing.Point(644, 593);
            this.btnFold.Name = "btnFold";
            this.btnFold.Size = new System.Drawing.Size(75, 23);
            this.btnFold.TabIndex = 9;
            this.btnFold.Text = "Fold";
            this.btnFold.UseVisualStyleBackColor = true;
            this.btnFold.Click += new System.EventHandler(this.btnFold_Click);
            // 
            // imgCommunityCardOne
            // 
            this.imgCommunityCardOne.BackColor = System.Drawing.Color.Transparent;
            this.imgCommunityCardOne.Location = new System.Drawing.Point(340, 260);
            this.imgCommunityCardOne.Name = "imgCommunityCardOne";
            this.imgCommunityCardOne.Size = new System.Drawing.Size(81, 99);
            this.imgCommunityCardOne.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgCommunityCardOne.TabIndex = 10;
            this.imgCommunityCardOne.TabStop = false;
            // 
            // imgCommunityCardTwo
            // 
            this.imgCommunityCardTwo.BackColor = System.Drawing.Color.Transparent;
            this.imgCommunityCardTwo.Location = new System.Drawing.Point(431, 260);
            this.imgCommunityCardTwo.Name = "imgCommunityCardTwo";
            this.imgCommunityCardTwo.Size = new System.Drawing.Size(81, 99);
            this.imgCommunityCardTwo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgCommunityCardTwo.TabIndex = 11;
            this.imgCommunityCardTwo.TabStop = false;
            // 
            // imgCommunityCardThree
            // 
            this.imgCommunityCardThree.BackColor = System.Drawing.Color.Transparent;
            this.imgCommunityCardThree.Location = new System.Drawing.Point(523, 260);
            this.imgCommunityCardThree.Name = "imgCommunityCardThree";
            this.imgCommunityCardThree.Size = new System.Drawing.Size(81, 99);
            this.imgCommunityCardThree.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgCommunityCardThree.TabIndex = 12;
            this.imgCommunityCardThree.TabStop = false;
            // 
            // imgCommunityCardFour
            // 
            this.imgCommunityCardFour.BackColor = System.Drawing.Color.Transparent;
            this.imgCommunityCardFour.Location = new System.Drawing.Point(613, 260);
            this.imgCommunityCardFour.Name = "imgCommunityCardFour";
            this.imgCommunityCardFour.Size = new System.Drawing.Size(81, 99);
            this.imgCommunityCardFour.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgCommunityCardFour.TabIndex = 13;
            this.imgCommunityCardFour.TabStop = false;
            // 
            // imgCommunityCardFive
            // 
            this.imgCommunityCardFive.BackColor = System.Drawing.Color.Transparent;
            this.imgCommunityCardFive.Location = new System.Drawing.Point(700, 260);
            this.imgCommunityCardFive.Name = "imgCommunityCardFive";
            this.imgCommunityCardFive.Size = new System.Drawing.Size(81, 99);
            this.imgCommunityCardFive.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgCommunityCardFive.TabIndex = 14;
            this.imgCommunityCardFive.TabStop = false;
            // 
            // numRaiseAmount
            // 
            this.numRaiseAmount.Location = new System.Drawing.Point(725, 564);
            this.numRaiseAmount.Name = "numRaiseAmount";
            this.numRaiseAmount.Size = new System.Drawing.Size(51, 23);
            this.numRaiseAmount.TabIndex = 15;
            // 
            // lblStageOfGame
            // 
            this.lblStageOfGame.AutoSize = true;
            this.lblStageOfGame.BackColor = System.Drawing.Color.Transparent;
            this.lblStageOfGame.ForeColor = System.Drawing.Color.White;
            this.lblStageOfGame.Location = new System.Drawing.Point(0, 446);
            this.lblStageOfGame.Name = "lblStageOfGame";
            this.lblStageOfGame.Size = new System.Drawing.Size(93, 15);
            this.lblStageOfGame.TabIndex = 16;
            this.lblStageOfGame.Text = "lblStageOfGame";
            // 
            // lblCurrentPlayerTurn
            // 
            this.lblCurrentPlayerTurn.AutoSize = true;
            this.lblCurrentPlayerTurn.BackColor = System.Drawing.Color.Transparent;
            this.lblCurrentPlayerTurn.ForeColor = System.Drawing.Color.White;
            this.lblCurrentPlayerTurn.Location = new System.Drawing.Point(0, 482);
            this.lblCurrentPlayerTurn.Name = "lblCurrentPlayerTurn";
            this.lblCurrentPlayerTurn.Size = new System.Drawing.Size(116, 15);
            this.lblCurrentPlayerTurn.TabIndex = 17;
            this.lblCurrentPlayerTurn.Text = "lblCurrentPlayerTurn";
            // 
            // btnContinuePlay
            // 
            this.btnContinuePlay.Location = new System.Drawing.Point(12, 41);
            this.btnContinuePlay.Name = "btnContinuePlay";
            this.btnContinuePlay.Size = new System.Drawing.Size(75, 23);
            this.btnContinuePlay.TabIndex = 18;
            this.btnContinuePlay.Text = "Continue Play";
            this.btnContinuePlay.UseVisualStyleBackColor = true;
            this.btnContinuePlay.Click += new System.EventHandler(this.btnContinuePlay_Click);
            // 
            // lblPlayerOneName
            // 
            this.lblPlayerOneName.AutoSize = true;
            this.lblPlayerOneName.Location = new System.Drawing.Point(947, 363);
            this.lblPlayerOneName.Name = "lblPlayerOneName";
            this.lblPlayerOneName.Size = new System.Drawing.Size(106, 15);
            this.lblPlayerOneName.TabIndex = 19;
            this.lblPlayerOneName.Text = "lblPlayerOneName";
            // 
            // lblPlayerTwoName
            // 
            this.lblPlayerTwoName.AutoSize = true;
            this.lblPlayerTwoName.Location = new System.Drawing.Point(497, 472);
            this.lblPlayerTwoName.Name = "lblPlayerTwoName";
            this.lblPlayerTwoName.Size = new System.Drawing.Size(105, 15);
            this.lblPlayerTwoName.TabIndex = 20;
            this.lblPlayerTwoName.Text = "lblPlayerTwoName";
            // 
            // lblPlayerThreeName
            // 
            this.lblPlayerThreeName.AutoSize = true;
            this.lblPlayerThreeName.Location = new System.Drawing.Point(52, 364);
            this.lblPlayerThreeName.Name = "lblPlayerThreeName";
            this.lblPlayerThreeName.Size = new System.Drawing.Size(113, 15);
            this.lblPlayerThreeName.TabIndex = 21;
            this.lblPlayerThreeName.Text = "lblPlayerThreeName";
            // 
            // lblPlayerFourName
            // 
            this.lblPlayerFourName.AutoSize = true;
            this.lblPlayerFourName.Location = new System.Drawing.Point(497, 143);
            this.lblPlayerFourName.Name = "lblPlayerFourName";
            this.lblPlayerFourName.Size = new System.Drawing.Size(108, 15);
            this.lblPlayerFourName.TabIndex = 22;
            this.lblPlayerFourName.Text = "lblPlayerFourName";
            // 
            // lblPot
            // 
            this.lblPot.AutoSize = true;
            this.lblPot.Location = new System.Drawing.Point(537, 223);
            this.lblPot.Name = "lblPot";
            this.lblPot.Size = new System.Drawing.Size(38, 15);
            this.lblPot.TabIndex = 23;
            this.lblPot.Text = "lblPot";
            // 
            // imgPlayerFour
            // 
            this.imgPlayerFour.BackColor = System.Drawing.Color.Transparent;
            this.imgPlayerFour.Location = new System.Drawing.Point(497, 12);
            this.imgPlayerFour.MaximumSize = new System.Drawing.Size(108, 108);
            this.imgPlayerFour.Name = "imgPlayerFour";
            this.imgPlayerFour.Size = new System.Drawing.Size(108, 108);
            this.imgPlayerFour.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgPlayerFour.TabIndex = 24;
            this.imgPlayerFour.TabStop = false;
            // 
            // imgPlayerOne
            // 
            this.imgPlayerOne.BackColor = System.Drawing.Color.Transparent;
            this.imgPlayerOne.Location = new System.Drawing.Point(946, 233);
            this.imgPlayerOne.MaximumSize = new System.Drawing.Size(108, 108);
            this.imgPlayerOne.Name = "imgPlayerOne";
            this.imgPlayerOne.Size = new System.Drawing.Size(108, 108);
            this.imgPlayerOne.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgPlayerOne.TabIndex = 25;
            this.imgPlayerOne.TabStop = false;
            // 
            // imgPlayerThree
            // 
            this.imgPlayerThree.BackColor = System.Drawing.Color.Transparent;
            this.imgPlayerThree.Location = new System.Drawing.Point(57, 233);
            this.imgPlayerThree.MaximumSize = new System.Drawing.Size(108, 108);
            this.imgPlayerThree.Name = "imgPlayerThree";
            this.imgPlayerThree.Size = new System.Drawing.Size(108, 108);
            this.imgPlayerThree.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgPlayerThree.TabIndex = 26;
            this.imgPlayerThree.TabStop = false;
            // 
            // imgPlayerFourHighlight
            // 
            this.imgPlayerFourHighlight.BackColor = System.Drawing.Color.Transparent;
            this.imgPlayerFourHighlight.Image = ((System.Drawing.Image)(resources.GetObject("imgPlayerFourHighlight.Image")));
            this.imgPlayerFourHighlight.Location = new System.Drawing.Point(497, 12);
            this.imgPlayerFourHighlight.MaximumSize = new System.Drawing.Size(108, 108);
            this.imgPlayerFourHighlight.Name = "imgPlayerFourHighlight";
            this.imgPlayerFourHighlight.Size = new System.Drawing.Size(108, 108);
            this.imgPlayerFourHighlight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgPlayerFourHighlight.TabIndex = 27;
            this.imgPlayerFourHighlight.TabStop = false;
            // 
            // imgPlayerOneHighlight
            // 
            this.imgPlayerOneHighlight.BackColor = System.Drawing.Color.Transparent;
            this.imgPlayerOneHighlight.Image = ((System.Drawing.Image)(resources.GetObject("imgPlayerOneHighlight.Image")));
            this.imgPlayerOneHighlight.Location = new System.Drawing.Point(946, 233);
            this.imgPlayerOneHighlight.MaximumSize = new System.Drawing.Size(108, 108);
            this.imgPlayerOneHighlight.Name = "imgPlayerOneHighlight";
            this.imgPlayerOneHighlight.Size = new System.Drawing.Size(108, 108);
            this.imgPlayerOneHighlight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgPlayerOneHighlight.TabIndex = 28;
            this.imgPlayerOneHighlight.TabStop = false;
            // 
            // imgPlayerThreeHighlight
            // 
            this.imgPlayerThreeHighlight.BackColor = System.Drawing.Color.Transparent;
            this.imgPlayerThreeHighlight.Image = ((System.Drawing.Image)(resources.GetObject("imgPlayerThreeHighlight.Image")));
            this.imgPlayerThreeHighlight.Location = new System.Drawing.Point(57, 233);
            this.imgPlayerThreeHighlight.MaximumSize = new System.Drawing.Size(108, 108);
            this.imgPlayerThreeHighlight.Name = "imgPlayerThreeHighlight";
            this.imgPlayerThreeHighlight.Size = new System.Drawing.Size(108, 108);
            this.imgPlayerThreeHighlight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgPlayerThreeHighlight.TabIndex = 29;
            this.imgPlayerThreeHighlight.TabStop = false;
            // 
            // imgPlayerOneDealer
            // 
            this.imgPlayerOneDealer.BackColor = System.Drawing.Color.Transparent;
            this.imgPlayerOneDealer.Image = ((System.Drawing.Image)(resources.GetObject("imgPlayerOneDealer.Image")));
            this.imgPlayerOneDealer.Location = new System.Drawing.Point(1022, 299);
            this.imgPlayerOneDealer.MaximumSize = new System.Drawing.Size(60, 60);
            this.imgPlayerOneDealer.Name = "imgPlayerOneDealer";
            this.imgPlayerOneDealer.Size = new System.Drawing.Size(60, 60);
            this.imgPlayerOneDealer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgPlayerOneDealer.TabIndex = 30;
            this.imgPlayerOneDealer.TabStop = false;
            // 
            // imgPlayerTwoDealer
            // 
            this.imgPlayerTwoDealer.BackColor = System.Drawing.Color.Transparent;
            this.imgPlayerTwoDealer.Image = ((System.Drawing.Image)(resources.GetObject("imgPlayerTwoDealer.Image")));
            this.imgPlayerTwoDealer.Location = new System.Drawing.Point(608, 450);
            this.imgPlayerTwoDealer.MaximumSize = new System.Drawing.Size(60, 60);
            this.imgPlayerTwoDealer.Name = "imgPlayerTwoDealer";
            this.imgPlayerTwoDealer.Size = new System.Drawing.Size(60, 60);
            this.imgPlayerTwoDealer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgPlayerTwoDealer.TabIndex = 31;
            this.imgPlayerTwoDealer.TabStop = false;
            // 
            // imgPlayerThreeDealer
            // 
            this.imgPlayerThreeDealer.BackColor = System.Drawing.Color.Transparent;
            this.imgPlayerThreeDealer.Image = ((System.Drawing.Image)(resources.GetObject("imgPlayerThreeDealer.Image")));
            this.imgPlayerThreeDealer.Location = new System.Drawing.Point(132, 299);
            this.imgPlayerThreeDealer.MaximumSize = new System.Drawing.Size(60, 60);
            this.imgPlayerThreeDealer.Name = "imgPlayerThreeDealer";
            this.imgPlayerThreeDealer.Size = new System.Drawing.Size(60, 60);
            this.imgPlayerThreeDealer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgPlayerThreeDealer.TabIndex = 32;
            this.imgPlayerThreeDealer.TabStop = false;
            // 
            // imgPlayerFourDealer
            // 
            this.imgPlayerFourDealer.BackColor = System.Drawing.Color.Transparent;
            this.imgPlayerFourDealer.Image = ((System.Drawing.Image)(resources.GetObject("imgPlayerFourDealer.Image")));
            this.imgPlayerFourDealer.Location = new System.Drawing.Point(570, 77);
            this.imgPlayerFourDealer.MaximumSize = new System.Drawing.Size(60, 60);
            this.imgPlayerFourDealer.Name = "imgPlayerFourDealer";
            this.imgPlayerFourDealer.Size = new System.Drawing.Size(60, 60);
            this.imgPlayerFourDealer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgPlayerFourDealer.TabIndex = 33;
            this.imgPlayerFourDealer.TabStop = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1125, 634);
            this.Controls.Add(this.imgPlayerFourDealer);
            this.Controls.Add(this.imgPlayerThreeDealer);
            this.Controls.Add(this.imgPlayerTwoDealer);
            this.Controls.Add(this.imgPlayerOneDealer);
            this.Controls.Add(this.imgPlayerThreeHighlight);
            this.Controls.Add(this.imgPlayerOneHighlight);
            this.Controls.Add(this.imgPlayerFourHighlight);
            this.Controls.Add(this.imgPlayerThree);
            this.Controls.Add(this.imgPlayerOne);
            this.Controls.Add(this.imgPlayerFour);
            this.Controls.Add(this.lblPot);
            this.Controls.Add(this.lblPlayerFourName);
            this.Controls.Add(this.lblPlayerThreeName);
            this.Controls.Add(this.lblPlayerTwoName);
            this.Controls.Add(this.lblPlayerOneName);
            this.Controls.Add(this.btnContinuePlay);
            this.Controls.Add(this.lblCurrentPlayerTurn);
            this.Controls.Add(this.lblStageOfGame);
            this.Controls.Add(this.numRaiseAmount);
            this.Controls.Add(this.imgCommunityCardFive);
            this.Controls.Add(this.imgCommunityCardFour);
            this.Controls.Add(this.imgCommunityCardThree);
            this.Controls.Add(this.imgCommunityCardTwo);
            this.Controls.Add(this.imgCommunityCardOne);
            this.Controls.Add(this.btnFold);
            this.Controls.Add(this.btnRaise);
            this.Controls.Add(this.btnCall);
            this.Controls.Add(this.imgHoleCardTwo);
            this.Controls.Add(this.imgHoleCardOne);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.imgTest);
            this.Controls.Add(this.lblErrorMessage);
            this.Controls.Add(this.btnStartGame);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1141, 673);
            this.MinimumSize = new System.Drawing.Size(888, 500);
            this.Name = "Main";
            this.Text = "Poker";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgTest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgHoleCardOne)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgHoleCardTwo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCommunityCardOne)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCommunityCardTwo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCommunityCardThree)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCommunityCardFour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCommunityCardFive)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRaiseAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPlayerFour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPlayerOne)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPlayerThree)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPlayerFourHighlight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPlayerOneHighlight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPlayerThreeHighlight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPlayerOneDealer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPlayerTwoDealer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPlayerThreeDealer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPlayerFourDealer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnStartGame;
        private Label lblErrorMessage;
        private PictureBox imgTest;
        private TextBox txtLog;
        private PictureBox imgHoleCardOne;
        private PictureBox imgHoleCardTwo;
        private Button btnCall;
        private Button btnRaise;
        private Button btnFold;
        private PictureBox imgCommunityCardOne;
        private PictureBox imgCommunityCardTwo;
        private PictureBox imgCommunityCardThree;
        private PictureBox imgCommunityCardFour;
        private PictureBox imgCommunityCardFive;
        private NumericUpDown numRaiseAmount;
        private Label lblStageOfGame;
        private Label lblCurrentPlayerTurn;
        private Button btnContinuePlay;
        private Label lblPlayerOneName;
        private Label lblPlayerTwoName;
        private Label lblPlayerThreeName;
        private Label lblPlayerFourName;
        private Label lblPot;
        private PictureBox imgPlayerFour;
        private PictureBox imgPlayerOne;
        private PictureBox imgPlayerThree;
        private PictureBox imgPlayerFourHighlight;
        private PictureBox imgPlayerOneHighlight;
        private PictureBox imgPlayerThreeHighlight;
        private PictureBox imgPlayerOneDealer;
        private PictureBox imgPlayerTwoDealer;
        private PictureBox imgPlayerThreeDealer;
        private PictureBox imgPlayerFourDealer;
    }
}