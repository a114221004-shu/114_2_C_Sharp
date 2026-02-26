namespace Review_Q1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        // UI controls for the rock-paper-scissors interface
        private System.Windows.Forms.PictureBox computerPictureBox;
        private System.Windows.Forms.PictureBox playerPictureBox;
        private System.Windows.Forms.Button stoneButton;
        private System.Windows.Forms.Button paperButton;
        private System.Windows.Forms.Button scissorButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.Label computerLabel;
        private System.Windows.Forms.Label playerLabel;

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
            computerPictureBox = new PictureBox();
            playerPictureBox = new PictureBox();
            stoneButton = new Button();
            paperButton = new Button();
            scissorButton = new Button();
            exitButton = new Button();
            resultLabel = new Label();
            computerLabel = new Label();
            playerLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)computerPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)playerPictureBox).BeginInit();
            SuspendLayout();
            // 
            // computerPictureBox
            // 
            computerPictureBox.BackColor = Color.FromArgb(240, 240, 240);
            computerPictureBox.Image = Properties.Resources.stone_computer;
            computerPictureBox.Location = new Point(107, 70);
            computerPictureBox.Name = "computerPictureBox";
            computerPictureBox.Size = new Size(300, 150);
            computerPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            computerPictureBox.TabIndex = 2;
            computerPictureBox.TabStop = false;
            computerPictureBox.Visible = false;
            // 
            // playerPictureBox
            // 
            playerPictureBox.BackColor = Color.FromArgb(240, 240, 240);
            playerPictureBox.Image = Properties.Resources.stone_player;
            playerPictureBox.Location = new Point(527, 70);
            playerPictureBox.Name = "playerPictureBox";
            playerPictureBox.Size = new Size(300, 150);
            playerPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            playerPictureBox.TabIndex = 3;
            playerPictureBox.TabStop = false;
            playerPictureBox.Visible = false;
            // 
            // stoneButton
            // 
            stoneButton.Font = new Font("微軟正黑體", 20F);
            stoneButton.Location = new Point(153, 362);
            stoneButton.Name = "stoneButton";
            stoneButton.Size = new Size(150, 70);
            stoneButton.TabIndex = 5;
            stoneButton.Text = "石頭";
            stoneButton.UseVisualStyleBackColor = true;
            // 
            // paperButton
            // 
            paperButton.Font = new Font("微軟正黑體", 20F);
            paperButton.Location = new Point(383, 362);
            paperButton.Name = "paperButton";
            paperButton.Size = new Size(150, 70);
            paperButton.TabIndex = 6;
            paperButton.Text = "布";
            paperButton.UseVisualStyleBackColor = true;
            // 
            // scissorButton
            // 
            scissorButton.Font = new Font("微軟正黑體", 20F);
            scissorButton.Location = new Point(613, 362);
            scissorButton.Name = "scissorButton";
            scissorButton.Size = new Size(150, 70);
            scissorButton.TabIndex = 7;
            scissorButton.Text = "剪刀";
            scissorButton.UseVisualStyleBackColor = true;
            // 
            // exitButton
            // 
            exitButton.Font = new Font("微軟正黑體", 20F);
            exitButton.Location = new Point(360, 456);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(200, 60);
            exitButton.TabIndex = 8;
            exitButton.Text = "結束遊戲";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // resultLabel
            // 
            resultLabel.BorderStyle = BorderStyle.FixedSingle;
            resultLabel.Font = new Font("微軟正黑體", 20F);
            resultLabel.Location = new Point(219, 251);
            resultLabel.Name = "resultLabel";
            resultLabel.Size = new Size(500, 72);
            resultLabel.TabIndex = 4;
            resultLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // computerLabel
            // 
            computerLabel.AutoSize = true;
            computerLabel.Font = new Font("微軟正黑體", 16F);
            computerLabel.Location = new Point(190, 27);
            computerLabel.Name = "computerLabel";
            computerLabel.Size = new Size(113, 40);
            computerLabel.TabIndex = 0;
            computerLabel.Text = "電腦出";
            computerLabel.Click += computerLabel_Click;
            // 
            // playerLabel
            // 
            playerLabel.AutoSize = true;
            playerLabel.Font = new Font("微軟正黑體", 16F);
            playerLabel.Location = new Point(613, 27);
            playerLabel.Name = "playerLabel";
            playerLabel.Size = new Size(113, 40);
            playerLabel.TabIndex = 1;
            playerLabel.Text = "玩家出";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(963, 604);
            Controls.Add(computerLabel);
            Controls.Add(playerLabel);
            Controls.Add(computerPictureBox);
            Controls.Add(playerPictureBox);
            Controls.Add(resultLabel);
            Controls.Add(stoneButton);
            Controls.Add(paperButton);
            Controls.Add(scissorButton);
            Controls.Add(exitButton);
            Name = "Form1";
            Text = "猜拳遊戲";
            ((System.ComponentModel.ISupportInitialize)computerPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)playerPictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}
