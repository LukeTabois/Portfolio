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
            this.btnStartHand = new System.Windows.Forms.Button();
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
            this.imgPot = new System.Windows.Forms.PictureBox();
            this.imgPlayerOneStack = new System.Windows.Forms.PictureBox();
            this.imgPlayerTwoStack = new System.Windows.Forms.PictureBox();
            this.imgPlayerThreeStack = new System.Windows.Forms.PictureBox();
            this.imgPlayerFourStack = new System.Windows.Forms.PictureBox();
            this.lblPlayerOneStackAmount = new System.Windows.Forms.Label();
            this.lblPlayerTwoStackAmount = new System.Windows.Forms.Label();
            this.lblPlayerThreeStackAmount = new System.Windows.Forms.Label();
            this.lblPlayerFourStackAmount = new System.Windows.Forms.Label();
            this.txtDisplayLog = new System.Windows.Forms.TextBox();
            this.lblDisplayLog = new System.Windows.Forms.Label();
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
            ((System.ComponentModel.ISupportInitialize)(this.imgPot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPlayerOneStack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPlayerTwoStack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPlayerThreeStack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPlayerFourStack)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStartHand
            // 
            this.btnStartHand.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnStartHand.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnStartHand.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnStartHand.ForeColor = System.Drawing.Color.White;
            this.btnStartHand.Location = new System.Drawing.Point(431, 365);
            this.btnStartHand.Name = "btnStartHand";
            this.btnStartHand.Size = new System.Drawing.Size(263, 46);
            this.btnStartHand.TabIndex = 0;
            this.btnStartHand.Text = "Start New Hand";
            this.btnStartHand.UseVisualStyleBackColor = false;
            this.btnStartHand.Click += new System.EventHandler(this.btnStartHand_Click);
            // 
            // lblErrorMessage
            // 
            this.lblErrorMessage.AutoSize = true;
            this.lblErrorMessage.BackColor = System.Drawing.Color.Transparent;
            this.lblErrorMessage.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblErrorMessage.ForeColor = System.Drawing.Color.Red;
            this.lblErrorMessage.Location = new System.Drawing.Point(12, 9);
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
            this.imgTest.Location = new System.Drawing.Point(1013, 472);
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
            this.txtLog.Location = new System.Drawing.Point(845, 12);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLog.Size = new System.Drawing.Size(268, 69);
            this.txtLog.TabIndex = 4;
            // 
            // imgHoleCardOne
            // 
            this.imgHoleCardOne.BackColor = System.Drawing.Color.Transparent;
            this.imgHoleCardOne.Location = new System.Drawing.Point(447, 516);
            this.imgHoleCardOne.Name = "imgHoleCardOne";
            this.imgHoleCardOne.Size = new System.Drawing.Size(100, 150);
            this.imgHoleCardOne.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgHoleCardOne.TabIndex = 5;
            this.imgHoleCardOne.TabStop = false;
            // 
            // imgHoleCardTwo
            // 
            this.imgHoleCardTwo.BackColor = System.Drawing.Color.Transparent;
            this.imgHoleCardTwo.Location = new System.Drawing.Point(553, 516);
            this.imgHoleCardTwo.Name = "imgHoleCardTwo";
            this.imgHoleCardTwo.Size = new System.Drawing.Size(100, 150);
            this.imgHoleCardTwo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgHoleCardTwo.TabIndex = 6;
            this.imgHoleCardTwo.TabStop = false;
            // 
            // btnCall
            // 
            this.btnCall.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnCall.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCall.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCall.ForeColor = System.Drawing.Color.White;
            this.btnCall.Location = new System.Drawing.Point(744, 520);
            this.btnCall.Name = "btnCall";
            this.btnCall.Size = new System.Drawing.Size(75, 29);
            this.btnCall.TabIndex = 7;
            this.btnCall.Text = "Call";
            this.btnCall.UseVisualStyleBackColor = false;
            this.btnCall.Click += new System.EventHandler(this.btnCall_Click);
            // 
            // btnRaise
            // 
            this.btnRaise.BackColor = System.Drawing.Color.LimeGreen;
            this.btnRaise.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRaise.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRaise.ForeColor = System.Drawing.Color.White;
            this.btnRaise.Location = new System.Drawing.Point(744, 555);
            this.btnRaise.Name = "btnRaise";
            this.btnRaise.Size = new System.Drawing.Size(75, 29);
            this.btnRaise.TabIndex = 8;
            this.btnRaise.Text = "Raise";
            this.btnRaise.UseVisualStyleBackColor = false;
            this.btnRaise.Click += new System.EventHandler(this.btnRaise_Click);
            // 
            // btnFold
            // 
            this.btnFold.BackColor = System.Drawing.Color.Red;
            this.btnFold.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFold.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnFold.ForeColor = System.Drawing.Color.White;
            this.btnFold.Location = new System.Drawing.Point(744, 591);
            this.btnFold.Name = "btnFold";
            this.btnFold.Size = new System.Drawing.Size(75, 29);
            this.btnFold.TabIndex = 9;
            this.btnFold.Text = "Fold";
            this.btnFold.UseVisualStyleBackColor = false;
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
            this.numRaiseAmount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.numRaiseAmount.Location = new System.Drawing.Point(825, 555);
            this.numRaiseAmount.Name = "numRaiseAmount";
            this.numRaiseAmount.Size = new System.Drawing.Size(75, 29);
            this.numRaiseAmount.TabIndex = 15;
            // 
            // lblPlayerOneName
            // 
            this.lblPlayerOneName.BackColor = System.Drawing.Color.Transparent;
            this.lblPlayerOneName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPlayerOneName.ForeColor = System.Drawing.Color.White;
            this.lblPlayerOneName.Location = new System.Drawing.Point(922, 344);
            this.lblPlayerOneName.Name = "lblPlayerOneName";
            this.lblPlayerOneName.Size = new System.Drawing.Size(155, 21);
            this.lblPlayerOneName.TabIndex = 19;
            this.lblPlayerOneName.Text = "lblPlayerOneName";
            this.lblPlayerOneName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblPlayerTwoName
            // 
            this.lblPlayerTwoName.BackColor = System.Drawing.Color.Transparent;
            this.lblPlayerTwoName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPlayerTwoName.ForeColor = System.Drawing.Color.White;
            this.lblPlayerTwoName.Location = new System.Drawing.Point(471, 471);
            this.lblPlayerTwoName.Name = "lblPlayerTwoName";
            this.lblPlayerTwoName.Size = new System.Drawing.Size(155, 21);
            this.lblPlayerTwoName.TabIndex = 20;
            this.lblPlayerTwoName.Text = "lblPlayerTwoName";
            this.lblPlayerTwoName.TextAlign = System.Drawing.ContentAlignment.TopCenter;            
            // 
            // lblPlayerThreeName
            // 
            this.lblPlayerThreeName.BackColor = System.Drawing.Color.Transparent;
            this.lblPlayerThreeName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPlayerThreeName.ForeColor = System.Drawing.Color.White;
            this.lblPlayerThreeName.Location = new System.Drawing.Point(27, 345);
            this.lblPlayerThreeName.Name = "lblPlayerThreeName";
            this.lblPlayerThreeName.Size = new System.Drawing.Size(167, 21);
            this.lblPlayerThreeName.TabIndex = 21;
            this.lblPlayerThreeName.Text = "lblPlayerThreeName";
            this.lblPlayerThreeName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblPlayerFourName
            // 
            this.lblPlayerFourName.BackColor = System.Drawing.Color.Transparent;
            this.lblPlayerFourName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPlayerFourName.ForeColor = System.Drawing.Color.White;
            this.lblPlayerFourName.Location = new System.Drawing.Point(472, 124);
            this.lblPlayerFourName.Name = "lblPlayerFourName";
            this.lblPlayerFourName.Size = new System.Drawing.Size(158, 21);
            this.lblPlayerFourName.TabIndex = 22;
            this.lblPlayerFourName.Text = "lblPlayerFourName";
            this.lblPlayerFourName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblPot
            // 
            this.lblPot.AutoSize = true;
            this.lblPot.BackColor = System.Drawing.Color.Transparent;
            this.lblPot.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPot.Location = new System.Drawing.Point(684, 230);
            this.lblPot.Name = "lblPot";
            this.lblPot.Size = new System.Drawing.Size(56, 21);
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
            this.imgPlayerOneDealer.Location = new System.Drawing.Point(813, 299);
            this.imgPlayerOneDealer.MaximumSize = new System.Drawing.Size(50, 50);
            this.imgPlayerOneDealer.Name = "imgPlayerOneDealer";
            this.imgPlayerOneDealer.Size = new System.Drawing.Size(50, 50);
            this.imgPlayerOneDealer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgPlayerOneDealer.TabIndex = 30;
            this.imgPlayerOneDealer.TabStop = false;
            // 
            // imgPlayerTwoDealer
            // 
            this.imgPlayerTwoDealer.BackColor = System.Drawing.Color.Transparent;
            this.imgPlayerTwoDealer.Image = ((System.Drawing.Image)(resources.GetObject("imgPlayerTwoDealer.Image")));
            this.imgPlayerTwoDealer.Location = new System.Drawing.Point(525, 417);
            this.imgPlayerTwoDealer.MaximumSize = new System.Drawing.Size(50, 50);
            this.imgPlayerTwoDealer.Name = "imgPlayerTwoDealer";
            this.imgPlayerTwoDealer.Size = new System.Drawing.Size(50, 50);
            this.imgPlayerTwoDealer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgPlayerTwoDealer.TabIndex = 31;
            this.imgPlayerTwoDealer.TabStop = false;
            // 
            // imgPlayerThreeDealer
            // 
            this.imgPlayerThreeDealer.BackColor = System.Drawing.Color.Transparent;
            this.imgPlayerThreeDealer.Image = ((System.Drawing.Image)(resources.GetObject("imgPlayerThreeDealer.Image")));
            this.imgPlayerThreeDealer.Location = new System.Drawing.Point(259, 299);
            this.imgPlayerThreeDealer.MaximumSize = new System.Drawing.Size(50, 50);
            this.imgPlayerThreeDealer.Name = "imgPlayerThreeDealer";
            this.imgPlayerThreeDealer.Size = new System.Drawing.Size(50, 50);
            this.imgPlayerThreeDealer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgPlayerThreeDealer.TabIndex = 32;
            this.imgPlayerThreeDealer.TabStop = false;
            // 
            // imgPlayerFourDealer
            // 
            this.imgPlayerFourDealer.BackColor = System.Drawing.Color.Transparent;
            this.imgPlayerFourDealer.Image = ((System.Drawing.Image)(resources.GetObject("imgPlayerFourDealer.Image")));
            this.imgPlayerFourDealer.Location = new System.Drawing.Point(525, 167);
            this.imgPlayerFourDealer.MaximumSize = new System.Drawing.Size(50, 50);
            this.imgPlayerFourDealer.Name = "imgPlayerFourDealer";
            this.imgPlayerFourDealer.Size = new System.Drawing.Size(50, 50);
            this.imgPlayerFourDealer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgPlayerFourDealer.TabIndex = 33;
            this.imgPlayerFourDealer.TabStop = false;
            // 
            // imgPot
            // 
            this.imgPot.BackColor = System.Drawing.Color.Transparent;
            this.imgPot.Location = new System.Drawing.Point(681, 194);
            this.imgPot.Name = "imgPot";
            this.imgPot.Size = new System.Drawing.Size(50, 60);
            this.imgPot.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgPot.TabIndex = 34;
            this.imgPot.TabStop = false;
            // 
            // imgPlayerOneStack
            // 
            this.imgPlayerOneStack.BackColor = System.Drawing.Color.Transparent;
            this.imgPlayerOneStack.Location = new System.Drawing.Point(1063, 281);
            this.imgPlayerOneStack.Name = "imgPlayerOneStack";
            this.imgPlayerOneStack.Size = new System.Drawing.Size(50, 60);
            this.imgPlayerOneStack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgPlayerOneStack.TabIndex = 35;
            this.imgPlayerOneStack.TabStop = false;
            // 
            // imgPlayerTwoStack
            // 
            this.imgPlayerTwoStack.BackColor = System.Drawing.Color.Transparent;
            this.imgPlayerTwoStack.Location = new System.Drawing.Point(673, 524);
            this.imgPlayerTwoStack.Name = "imgPlayerTwoStack";
            this.imgPlayerTwoStack.Size = new System.Drawing.Size(50, 60);
            this.imgPlayerTwoStack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgPlayerTwoStack.TabIndex = 36;
            this.imgPlayerTwoStack.TabStop = false;
            // 
            // imgPlayerThreeStack
            // 
            this.imgPlayerThreeStack.BackColor = System.Drawing.Color.Transparent;
            this.imgPlayerThreeStack.Location = new System.Drawing.Point(171, 281);
            this.imgPlayerThreeStack.Name = "imgPlayerThreeStack";
            this.imgPlayerThreeStack.Size = new System.Drawing.Size(50, 60);
            this.imgPlayerThreeStack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgPlayerThreeStack.TabIndex = 37;
            this.imgPlayerThreeStack.TabStop = false;
            // 
            // imgPlayerFourStack
            // 
            this.imgPlayerFourStack.BackColor = System.Drawing.Color.Transparent;
            this.imgPlayerFourStack.Location = new System.Drawing.Point(613, 60);
            this.imgPlayerFourStack.Name = "imgPlayerFourStack";
            this.imgPlayerFourStack.Size = new System.Drawing.Size(50, 60);
            this.imgPlayerFourStack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgPlayerFourStack.TabIndex = 38;
            this.imgPlayerFourStack.TabStop = false;
            // 
            // lblPlayerOneStackAmount
            // 
            this.lblPlayerOneStackAmount.AutoSize = true;
            this.lblPlayerOneStackAmount.BackColor = System.Drawing.Color.Transparent;
            this.lblPlayerOneStackAmount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPlayerOneStackAmount.ForeColor = System.Drawing.Color.Orange;
            this.lblPlayerOneStackAmount.Location = new System.Drawing.Point(1073, 317);
            this.lblPlayerOneStackAmount.Name = "lblPlayerOneStackAmount";
            this.lblPlayerOneStackAmount.Size = new System.Drawing.Size(212, 21);
            this.lblPlayerOneStackAmount.TabIndex = 39;
            this.lblPlayerOneStackAmount.Text = "lblPlayerOneStackAmount";
            // 
            // lblPlayerTwoStackAmount
            // 
            this.lblPlayerTwoStackAmount.AutoSize = true;
            this.lblPlayerTwoStackAmount.BackColor = System.Drawing.Color.Transparent;
            this.lblPlayerTwoStackAmount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPlayerTwoStackAmount.ForeColor = System.Drawing.Color.Orange;
            this.lblPlayerTwoStackAmount.Location = new System.Drawing.Point(687, 560);
            this.lblPlayerTwoStackAmount.Name = "lblPlayerTwoStackAmount";
            this.lblPlayerTwoStackAmount.Size = new System.Drawing.Size(212, 21);
            this.lblPlayerTwoStackAmount.TabIndex = 40;
            this.lblPlayerTwoStackAmount.Text = "lblPlayerTwoStackAmount";
            // 
            // lblPlayerThreeStackAmount
            // 
            this.lblPlayerThreeStackAmount.AutoSize = true;
            this.lblPlayerThreeStackAmount.BackColor = System.Drawing.Color.Transparent;
            this.lblPlayerThreeStackAmount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPlayerThreeStackAmount.ForeColor = System.Drawing.Color.Orange;
            this.lblPlayerThreeStackAmount.Location = new System.Drawing.Point(183, 317);
            this.lblPlayerThreeStackAmount.Name = "lblPlayerThreeStackAmount";
            this.lblPlayerThreeStackAmount.Size = new System.Drawing.Size(224, 21);
            this.lblPlayerThreeStackAmount.TabIndex = 41;
            this.lblPlayerThreeStackAmount.Text = "lblPlayerThreeStackAmount";
            // 
            // lblPlayerFourStackAmount
            // 
            this.lblPlayerFourStackAmount.AutoSize = true;
            this.lblPlayerFourStackAmount.BackColor = System.Drawing.Color.Transparent;
            this.lblPlayerFourStackAmount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPlayerFourStackAmount.ForeColor = System.Drawing.Color.Orange;
            this.lblPlayerFourStackAmount.Location = new System.Drawing.Point(624, 96);
            this.lblPlayerFourStackAmount.Name = "lblPlayerFourStackAmount";
            this.lblPlayerFourStackAmount.Size = new System.Drawing.Size(215, 21);
            this.lblPlayerFourStackAmount.TabIndex = 42;
            this.lblPlayerFourStackAmount.Text = "lblPlayerFourStackAmount";
            // 
            // txtDisplayLog
            // 
            this.txtDisplayLog.BackColor = System.Drawing.Color.Black;
            this.txtDisplayLog.ForeColor = System.Drawing.Color.White;
            this.txtDisplayLog.Location = new System.Drawing.Point(845, 99);
            this.txtDisplayLog.Multiline = true;
            this.txtDisplayLog.Name = "txtDisplayLog";
            this.txtDisplayLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDisplayLog.Size = new System.Drawing.Size(268, 54);
            this.txtDisplayLog.TabIndex = 43;
            this.txtDisplayLog.Visible = false;
            // 
            // lblDisplayLog
            // 
            this.lblDisplayLog.AutoSize = true;
            this.lblDisplayLog.BackColor = System.Drawing.Color.Transparent;
            this.lblDisplayLog.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDisplayLog.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblDisplayLog.Location = new System.Drawing.Point(12, 516);
            this.lblDisplayLog.MaximumSize = new System.Drawing.Size(410, 100);
            this.lblDisplayLog.Name = "lblDisplayLog";
            this.lblDisplayLog.Size = new System.Drawing.Size(132, 25);
            this.lblDisplayLog.TabIndex = 44;
            this.lblDisplayLog.Text = "lblDisplayLog";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1125, 634);
            this.Controls.Add(this.lblDisplayLog);
            this.Controls.Add(this.txtDisplayLog);
            this.Controls.Add(this.lblPlayerFourStackAmount);
            this.Controls.Add(this.lblPlayerThreeStackAmount);
            this.Controls.Add(this.lblPlayerTwoStackAmount);
            this.Controls.Add(this.lblPlayerOneStackAmount);
            this.Controls.Add(this.imgPlayerFourStack);
            this.Controls.Add(this.imgPlayerThreeStack);
            this.Controls.Add(this.imgPlayerTwoStack);
            this.Controls.Add(this.imgPlayerOneStack);
            this.Controls.Add(this.imgPot);
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
            this.Controls.Add(this.btnStartHand);
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
            ((System.ComponentModel.ISupportInitialize)(this.imgPot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPlayerOneStack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPlayerTwoStack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPlayerThreeStack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPlayerFourStack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnStartHand;
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
        private PictureBox imgPot;
        private PictureBox imgPlayerOneStack;
        private PictureBox imgPlayerTwoStack;
        private PictureBox imgPlayerThreeStack;
        private PictureBox imgPlayerFourStack;
        private Label lblPlayerOneStackAmount;
        private Label lblPlayerTwoStackAmount;
        private Label lblPlayerThreeStackAmount;
        private Label lblPlayerFourStackAmount;
        private TextBox txtDisplayLog;
        private Label lblDisplayLog;
    }
}