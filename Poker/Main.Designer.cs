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
            this.btnTest = new System.Windows.Forms.Button();
            this.lblTest = new System.Windows.Forms.Label();
            this.lblCardCount = new System.Windows.Forms.Label();
            this.imgTest = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgTest)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(12, 426);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(75, 23);
            this.btnTest.TabIndex = 0;
            this.btnTest.Text = "Test";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // lblTest
            // 
            this.lblTest.AutoSize = true;
            this.lblTest.Location = new System.Drawing.Point(93, 430);
            this.lblTest.Name = "lblTest";
            this.lblTest.Size = new System.Drawing.Size(38, 15);
            this.lblTest.TabIndex = 1;
            this.lblTest.Text = "label1";
            // 
            // lblCardCount
            // 
            this.lblCardCount.AutoSize = true;
            this.lblCardCount.Location = new System.Drawing.Point(822, 430);
            this.lblCardCount.Name = "lblCardCount";
            this.lblCardCount.Size = new System.Drawing.Size(38, 15);
            this.lblCardCount.TabIndex = 2;
            this.lblCardCount.Text = "label1";
            // 
            // imgTest
            // 
            this.imgTest.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imgTest.Image = ((System.Drawing.Image)(resources.GetObject("imgTest.Image")));
            this.imgTest.InitialImage = null;
            this.imgTest.Location = new System.Drawing.Point(297, 12);
            this.imgTest.Name = "imgTest";
            this.imgTest.Size = new System.Drawing.Size(250, 350);
            this.imgTest.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgTest.TabIndex = 3;
            this.imgTest.TabStop = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(872, 461);
            this.Controls.Add(this.imgTest);
            this.Controls.Add(this.lblCardCount);
            this.Controls.Add(this.lblTest);
            this.Controls.Add(this.btnTest);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(888, 500);
            this.MinimumSize = new System.Drawing.Size(888, 500);
            this.Name = "Main";
            this.Text = "Poker";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgTest)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnTest;
        private Label lblTest;
        private Label lblCardCount;
        private PictureBox imgTest;
    }
}