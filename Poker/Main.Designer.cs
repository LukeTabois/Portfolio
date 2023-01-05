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
            ((System.ComponentModel.ISupportInitialize)(this.imgTest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgHoleCardOne)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgHoleCardTwo)).BeginInit();
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
            this.imgTest.Location = new System.Drawing.Point(378, 102);
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
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(872, 461);
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
    }
}