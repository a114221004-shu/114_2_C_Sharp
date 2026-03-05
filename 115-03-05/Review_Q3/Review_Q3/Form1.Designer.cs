namespace Review_Q3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        // UI controls
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Button btnLoadWinning;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ListBox lstWinningNumbers;
        private System.Windows.Forms.GroupBox grpResults;
        private System.Windows.Forms.Label lblResultHeader;
        private System.Windows.Forms.Label lblMatchCount;
        private System.Windows.Forms.Label lblMatchDetails;

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
            lblTitle = new Label();
            btnGenerate = new Button();
            btnLoadWinning = new Button();
            btnExit = new Button();
            lstWinningNumbers = new ListBox();
            grpResults = new GroupBox();
            lblResultHeader = new Label();
            lblMatchCount = new Label();
            lblMatchDetails = new Label();
            lblGenerated1 = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            grpResults.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(20, 18);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(272, 46);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "樂透號碼產生器";
            // 
            // btnGenerate
            // 
            btnGenerate.Location = new Point(80, 210);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(200, 60);
            btnGenerate.TabIndex = 2;
            btnGenerate.Text = "產生號碼";
            // 
            // btnLoadWinning
            // 
            btnLoadWinning.Location = new Point(360, 210);
            btnLoadWinning.Name = "btnLoadWinning";
            btnLoadWinning.Size = new Size(200, 60);
            btnLoadWinning.TabIndex = 3;
            btnLoadWinning.Text = "開獎號碼";
            // 
            // btnExit
            // 
            btnExit.Location = new Point(640, 210);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(200, 60);
            btnExit.TabIndex = 4;
            btnExit.Text = "離開";
            // 
            // lstWinningNumbers
            // 
            lstWinningNumbers.Font = new Font("Microsoft JhengHei UI", 16F);
            lstWinningNumbers.ItemHeight = 41;
            lstWinningNumbers.Location = new Point(20, 290);
            lstWinningNumbers.Name = "lstWinningNumbers";
            lstWinningNumbers.Size = new Size(560, 250);
            lstWinningNumbers.TabIndex = 5;
            // 
            // grpResults
            // 
            grpResults.Controls.Add(lblResultHeader);
            grpResults.Controls.Add(lblMatchCount);
            grpResults.Controls.Add(lblMatchDetails);
            grpResults.Location = new Point(600, 290);
            grpResults.Name = "grpResults";
            grpResults.Size = new Size(300, 260);
            grpResults.TabIndex = 6;
            grpResults.TabStop = false;
            // 
            // lblResultHeader
            // 
            lblResultHeader.AutoSize = true;
            lblResultHeader.Location = new Point(20, 30);
            lblResultHeader.Name = "lblResultHeader";
            lblResultHeader.Size = new Size(0, 46);
            lblResultHeader.TabIndex = 0;
            // 
            // lblMatchCount
            // 
            lblMatchCount.AutoSize = true;
            lblMatchCount.Location = new Point(20, 70);
            lblMatchCount.Name = "lblMatchCount";
            lblMatchCount.Size = new Size(0, 46);
            lblMatchCount.TabIndex = 1;
            // 
            // lblMatchDetails
            // 
            lblMatchDetails.AutoSize = true;
            lblMatchDetails.Location = new Point(20, 110);
            lblMatchDetails.Name = "lblMatchDetails";
            lblMatchDetails.Size = new Size(0, 46);
            lblMatchDetails.TabIndex = 2;
            // 
            // lblGenerated1
            // 
            lblGenerated1.BorderStyle = BorderStyle.FixedSingle;
            lblGenerated1.Location = new Point(80, 84);
            lblGenerated1.Name = "lblGenerated1";
            lblGenerated1.Size = new Size(110, 110);
            lblGenerated1.TabIndex = 7;
            lblGenerated1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Location = new Point(730, 84);
            label1.Name = "label1";
            label1.Size = new Size(110, 110);
            label1.TabIndex = 8;
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.Location = new Point(568, 84);
            label2.Name = "label2";
            label2.Size = new Size(110, 110);
            label2.TabIndex = 9;
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.BorderStyle = BorderStyle.FixedSingle;
            label3.Location = new Point(405, 84);
            label3.Name = "label3";
            label3.Size = new Size(110, 110);
            label3.TabIndex = 10;
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.BorderStyle = BorderStyle.FixedSingle;
            label4.Location = new Point(244, 84);
            label4.Name = "label4";
            label4.Size = new Size(110, 110);
            label4.TabIndex = 11;
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            ClientSize = new Size(920, 620);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblGenerated1);
            Controls.Add(lblTitle);
            Controls.Add(btnGenerate);
            Controls.Add(btnLoadWinning);
            Controls.Add(btnExit);
            Controls.Add(lstWinningNumbers);
            Controls.Add(grpResults);
            Font = new Font("Microsoft JhengHei UI", 18F);
            Name = "Form1";
            Text = "樂透號碼產生器";
            grpResults.ResumeLayout(false);
            grpResults.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblGenerated1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}
