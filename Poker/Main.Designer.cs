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
            ((System.ComponentModel.ISupportInitialize)(this.imgTest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgHoleCardOne)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgHoleCardTwo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCommunityCardOne)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCommunityCardTwo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCommunityCardThree)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCommunityCardFour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCommunityCardFive)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRaiseAmount)).BeginInit();
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
            this.imgTest.Location = new System.Drawing.Point(760, 12);
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
            this.txtLog.Location = new System.Drawing.Point(12, 332);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLog.Size = new System.Drawing.Size(403, 117);
            this.txtLog.TabIndex = 4;
            // 
            // imgHoleCardOne
            // 
            this.imgHoleCardOne.BackColor = System.Drawing.Color.Transparent;
            this.imgHoleCardOne.Location = new System.Drawing.Point(421, 332);
            this.imgHoleCardOne.Name = "imgHoleCardOne";
            this.imgHoleCardOne.Size = new System.Drawing.Size(100, 150);
            this.imgHoleCardOne.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgHoleCardOne.TabIndex = 5;
            this.imgHoleCardOne.TabStop = false;
            // 
            // imgHoleCardTwo
            // 
            this.imgHoleCardTwo.BackColor = System.Drawing.Color.Transparent;
            this.imgHoleCardTwo.Location = new System.Drawing.Point(527, 332);
            this.imgHoleCardTwo.Name = "imgHoleCardTwo";
            this.imgHoleCardTwo.Size = new System.Drawing.Size(100, 150);
            this.imgHoleCardTwo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgHoleCardTwo.TabIndex = 6;
            this.imgHoleCardTwo.TabStop = false;
            // 
            // btnCall
            // 
            this.btnCall.Location = new System.Drawing.Point(656, 351);
            this.btnCall.Name = "btnCall";
            this.btnCall.Size = new System.Drawing.Size(75, 23);
            this.btnCall.TabIndex = 7;
            this.btnCall.Text = "Call";
            this.btnCall.UseVisualStyleBackColor = true;
            this.btnCall.Click += new System.EventHandler(this.btnCall_Click);
            // 
            // btnRaise
            // 
            this.btnRaise.Location = new System.Drawing.Point(656, 380);
            this.btnRaise.Name = "btnRaise";
            this.btnRaise.Size = new System.Drawing.Size(75, 23);
            this.btnRaise.TabIndex = 8;
            this.btnRaise.Text = "Raise";
            this.btnRaise.UseVisualStyleBackColor = true;
            this.btnRaise.Click += new System.EventHandler(this.btnRaise_Click);
            // 
            // btnFold
            // 
            this.btnFold.Location = new System.Drawing.Point(656, 409);
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
            this.imgCommunityCardOne.Location = new System.Drawing.Point(213, 126);
            this.imgCommunityCardOne.Name = "imgCommunityCardOne";
            this.imgCommunityCardOne.Size = new System.Drawing.Size(81, 99);
            this.imgCommunityCardOne.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgCommunityCardOne.TabIndex = 10;
            this.imgCommunityCardOne.TabStop = false;
            // 
            // imgCommunityCardTwo
            // 
            this.imgCommunityCardTwo.BackColor = System.Drawing.Color.Transparent;
            this.imgCommunityCardTwo.Location = new System.Drawing.Point(304, 126);
            this.imgCommunityCardTwo.Name = "imgCommunityCardTwo";
            this.imgCommunityCardTwo.Size = new System.Drawing.Size(81, 99);
            this.imgCommunityCardTwo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgCommunityCardTwo.TabIndex = 11;
            this.imgCommunityCardTwo.TabStop = false;
            // 
            // imgCommunityCardThree
            // 
            this.imgCommunityCardThree.BackColor = System.Drawing.Color.Transparent;
            this.imgCommunityCardThree.Location = new System.Drawing.Point(396, 126);
            this.imgCommunityCardThree.Name = "imgCommunityCardThree";
            this.imgCommunityCardThree.Size = new System.Drawing.Size(81, 99);
            this.imgCommunityCardThree.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgCommunityCardThree.TabIndex = 12;
            this.imgCommunityCardThree.TabStop = false;
            // 
            // imgCommunityCardFour
            // 
            this.imgCommunityCardFour.BackColor = System.Drawing.Color.Transparent;
            this.imgCommunityCardFour.Location = new System.Drawing.Point(486, 126);
            this.imgCommunityCardFour.Name = "imgCommunityCardFour";
            this.imgCommunityCardFour.Size = new System.Drawing.Size(81, 99);
            this.imgCommunityCardFour.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgCommunityCardFour.TabIndex = 13;
            this.imgCommunityCardFour.TabStop = false;
            // 
            // imgCommunityCardFive
            // 
            this.imgCommunityCardFive.BackColor = System.Drawing.Color.Transparent;
            this.imgCommunityCardFive.Location = new System.Drawing.Point(573, 126);
            this.imgCommunityCardFive.Name = "imgCommunityCardFive";
            this.imgCommunityCardFive.Size = new System.Drawing.Size(81, 99);
            this.imgCommunityCardFive.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgCommunityCardFive.TabIndex = 14;
            this.imgCommunityCardFive.TabStop = false;
            // 
            // numRaiseAmount
            // 
            this.numRaiseAmount.Location = new System.Drawing.Point(737, 380);
            this.numRaiseAmount.Name = "numRaiseAmount";
            this.numRaiseAmount.Size = new System.Drawing.Size(51, 23);
            this.numRaiseAmount.TabIndex = 15;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(872, 461);
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
            this.MaximumSize = new System.Drawing.Size(888, 500);
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
    }
}