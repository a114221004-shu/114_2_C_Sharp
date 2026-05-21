namespace Account_Simulator
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.depositGroupBox = new System.Windows.Forms.GroupBox();
            this.depositButton = new System.Windows.Forms.Button();
            this.depositTextBox = new System.Windows.Forms.TextBox();
            this.depositAmountDescriptionLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.withdrawButton = new System.Windows.Forms.Button();
            this.withdrawTextBox = new System.Windows.Forms.TextBox();
            this.withdrawAmountDescriptionLabel = new System.Windows.Forms.Label();
            this.balanceDescriptionLabel = new System.Windows.Forms.Label();
            this.balanceLabel = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.CreateAccountGroupBox = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.accountIDTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.balanceTextBox = new System.Windows.Forms.TextBox();
            this.CreateAccountButton = new System.Windows.Forms.Button();
            this.depositGroupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.CreateAccountGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // depositGroupBox
            // 
            this.depositGroupBox.Controls.Add(this.depositButton);
            this.depositGroupBox.Controls.Add(this.depositTextBox);
            this.depositGroupBox.Controls.Add(this.depositAmountDescriptionLabel);
            this.depositGroupBox.Location = new System.Drawing.Point(56, 428);
            this.depositGroupBox.Name = "depositGroupBox";
            this.depositGroupBox.Size = new System.Drawing.Size(356, 266);
            this.depositGroupBox.TabIndex = 0;
            this.depositGroupBox.TabStop = false;
            this.depositGroupBox.Text = "存款";
            // 
            // depositButton
            // 
            this.depositButton.Location = new System.Drawing.Point(75, 167);
            this.depositButton.Name = "depositButton";
            this.depositButton.Size = new System.Drawing.Size(162, 66);
            this.depositButton.TabIndex = 2;
            this.depositButton.Text = "存款";
            this.depositButton.UseVisualStyleBackColor = true;
            this.depositButton.Click += new System.EventHandler(this.depositButton_Click);
            // 
            // depositTextBox
            // 
            this.depositTextBox.Location = new System.Drawing.Point(139, 75);
            this.depositTextBox.Name = "depositTextBox";
            this.depositTextBox.Size = new System.Drawing.Size(198, 55);
            this.depositTextBox.TabIndex = 1;
            this.depositTextBox.TextChanged += new System.EventHandler(this.depositTextBox_TextChanged);
            // 
            // depositAmountDescriptionLabel
            // 
            this.depositAmountDescriptionLabel.AutoSize = true;
            this.depositAmountDescriptionLabel.Location = new System.Drawing.Point(20, 81);
            this.depositAmountDescriptionLabel.Name = "depositAmountDescriptionLabel";
            this.depositAmountDescriptionLabel.Size = new System.Drawing.Size(128, 45);
            this.depositAmountDescriptionLabel.TabIndex = 0;
            this.depositAmountDescriptionLabel.Text = "金額：";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.withdrawButton);
            this.groupBox1.Controls.Add(this.withdrawTextBox);
            this.groupBox1.Controls.Add(this.withdrawAmountDescriptionLabel);
            this.groupBox1.Location = new System.Drawing.Point(510, 428);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(349, 266);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "提款";
            // 
            // withdrawButton
            // 
            this.withdrawButton.Location = new System.Drawing.Point(84, 167);
            this.withdrawButton.Name = "withdrawButton";
            this.withdrawButton.Size = new System.Drawing.Size(162, 66);
            this.withdrawButton.TabIndex = 2;
            this.withdrawButton.Text = "提款";
            this.withdrawButton.UseVisualStyleBackColor = true;
            this.withdrawButton.Click += new System.EventHandler(this.withdrawButton_Click);
            // 
            // withdrawTextBox
            // 
            this.withdrawTextBox.Location = new System.Drawing.Point(138, 75);
            this.withdrawTextBox.Name = "withdrawTextBox";
            this.withdrawTextBox.Size = new System.Drawing.Size(180, 55);
            this.withdrawTextBox.TabIndex = 1;
            // 
            // withdrawAmountDescriptionLabel
            // 
            this.withdrawAmountDescriptionLabel.AutoSize = true;
            this.withdrawAmountDescriptionLabel.Location = new System.Drawing.Point(20, 81);
            this.withdrawAmountDescriptionLabel.Name = "withdrawAmountDescriptionLabel";
            this.withdrawAmountDescriptionLabel.Size = new System.Drawing.Size(128, 45);
            this.withdrawAmountDescriptionLabel.TabIndex = 0;
            this.withdrawAmountDescriptionLabel.Text = "金額：";
            // 
            // balanceDescriptionLabel
            // 
            this.balanceDescriptionLabel.AutoSize = true;
            this.balanceDescriptionLabel.Location = new System.Drawing.Point(216, 738);
            this.balanceDescriptionLabel.Name = "balanceDescriptionLabel";
            this.balanceDescriptionLabel.Size = new System.Drawing.Size(128, 45);
            this.balanceDescriptionLabel.TabIndex = 2;
            this.balanceDescriptionLabel.Text = "餘額：";
            // 
            // balanceLabel
            // 
            this.balanceLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.balanceLabel.Location = new System.Drawing.Point(333, 738);
            this.balanceLabel.Name = "balanceLabel";
            this.balanceLabel.Size = new System.Drawing.Size(297, 45);
            this.balanceLabel.TabIndex = 3;
            this.balanceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(414, 821);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(100, 60);
            this.exitButton.TabIndex = 4;
            this.exitButton.Text = "離開";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // CreateAccountGroupBox
            // 
            this.CreateAccountGroupBox.Controls.Add(this.CreateAccountButton);
            this.CreateAccountGroupBox.Controls.Add(this.balanceTextBox);
            this.CreateAccountGroupBox.Controls.Add(this.nameTextBox);
            this.CreateAccountGroupBox.Controls.Add(this.accountIDTextBox);
            this.CreateAccountGroupBox.Controls.Add(this.label3);
            this.CreateAccountGroupBox.Controls.Add(this.label2);
            this.CreateAccountGroupBox.Controls.Add(this.label1);
            this.CreateAccountGroupBox.Location = new System.Drawing.Point(56, 11);
            this.CreateAccountGroupBox.Name = "CreateAccountGroupBox";
            this.CreateAccountGroupBox.Size = new System.Drawing.Size(803, 357);
            this.CreateAccountGroupBox.TabIndex = 5;
            this.CreateAccountGroupBox.TabStop = false;
            this.CreateAccountGroupBox.Text = "建立帳戶";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 45);
            this.label1.TabIndex = 3;
            this.label1.Text = "帳號：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(91, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 45);
            this.label2.TabIndex = 4;
            this.label2.Tag = "";
            this.label2.Text = "姓名：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(200, 45);
            this.label3.TabIndex = 5;
            this.label3.Text = "開戶金額：";
            // 
            // accountIDTextBox
            // 
            this.accountIDTextBox.Location = new System.Drawing.Point(225, 52);
            this.accountIDTextBox.Name = "accountIDTextBox";
            this.accountIDTextBox.Size = new System.Drawing.Size(377, 55);
            this.accountIDTextBox.TabIndex = 6;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(225, 133);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(377, 55);
            this.nameTextBox.TabIndex = 7;
            // 
            // balanceTextBox
            // 
            this.balanceTextBox.Location = new System.Drawing.Point(225, 214);
            this.balanceTextBox.Name = "balanceTextBox";
            this.balanceTextBox.Size = new System.Drawing.Size(377, 55);
            this.balanceTextBox.TabIndex = 8;
            // 
            // CreateAccountButton
            // 
            this.CreateAccountButton.Location = new System.Drawing.Point(301, 291);
            this.CreateAccountButton.Name = "CreateAccountButton";
            this.CreateAccountButton.Size = new System.Drawing.Size(196, 60);
            this.CreateAccountButton.TabIndex = 9;
            this.CreateAccountButton.Text = "建立帳戶";
            this.CreateAccountButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(21F, 45F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 916);
            this.Controls.Add(this.CreateAccountGroupBox);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.balanceLabel);
            this.Controls.Add(this.balanceDescriptionLabel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.depositGroupBox);
            this.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Name = "Form1";
            this.Text = "帳戶模擬器";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.depositGroupBox.ResumeLayout(false);
            this.depositGroupBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.CreateAccountGroupBox.ResumeLayout(false);
            this.CreateAccountGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox depositGroupBox;
        private System.Windows.Forms.Button depositButton;
        private System.Windows.Forms.TextBox depositTextBox;
        private System.Windows.Forms.Label depositAmountDescriptionLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button withdrawButton;
        private System.Windows.Forms.TextBox withdrawTextBox;
        private System.Windows.Forms.Label withdrawAmountDescriptionLabel;
        private System.Windows.Forms.Label balanceDescriptionLabel;
        private System.Windows.Forms.Label balanceLabel;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.GroupBox CreateAccountGroupBox;
        private System.Windows.Forms.TextBox balanceTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox accountIDTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CreateAccountButton;
    }
}

