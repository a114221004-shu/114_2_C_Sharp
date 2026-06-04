namespace Tutorial_9_3_3
{
    partial class OpenAccountForm
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
            this.CreateAccountGroupBox = new System.Windows.Forms.GroupBox();
            this.CreateAccountButton = new System.Windows.Forms.Button();
            this.balanceTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.accountIDTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.balanceLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.CreateAccountGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // CreateAccountGroupBox
            // 
            this.CreateAccountGroupBox.Controls.Add(this.button1);
            this.CreateAccountGroupBox.Controls.Add(this.CreateAccountButton);
            this.CreateAccountGroupBox.Controls.Add(this.balanceTextBox);
            this.CreateAccountGroupBox.Controls.Add(this.nameTextBox);
            this.CreateAccountGroupBox.Controls.Add(this.accountIDTextBox);
            this.CreateAccountGroupBox.Controls.Add(this.label3);
            this.CreateAccountGroupBox.Controls.Add(this.label2);
            this.CreateAccountGroupBox.Controls.Add(this.label1);
            this.CreateAccountGroupBox.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.CreateAccountGroupBox.Location = new System.Drawing.Point(45, 22);
            this.CreateAccountGroupBox.Name = "CreateAccountGroupBox";
            this.CreateAccountGroupBox.Size = new System.Drawing.Size(803, 357);
            this.CreateAccountGroupBox.TabIndex = 6;
            this.CreateAccountGroupBox.TabStop = false;
            this.CreateAccountGroupBox.Text = "建立帳戶";
            // 
            // CreateAccountButton
            // 
            this.CreateAccountButton.Location = new System.Drawing.Point(301, 291);
            this.CreateAccountButton.Name = "CreateAccountButton";
            this.CreateAccountButton.Size = new System.Drawing.Size(196, 60);
            this.CreateAccountButton.TabIndex = 9;
            this.CreateAccountButton.Text = "建立帳戶";
            this.CreateAccountButton.UseVisualStyleBackColor = true;
            this.CreateAccountButton.Click += new System.EventHandler(this.CreateAccountButton_Click);
            // 
            // balanceTextBox
            // 
            this.balanceTextBox.Location = new System.Drawing.Point(225, 214);
            this.balanceTextBox.Name = "balanceTextBox";
            this.balanceTextBox.Size = new System.Drawing.Size(377, 51);
            this.balanceTextBox.TabIndex = 8;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(225, 133);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(377, 51);
            this.nameTextBox.TabIndex = 7;
            // 
            // accountIDTextBox
            // 
            this.accountIDTextBox.Location = new System.Drawing.Point(225, 52);
            this.accountIDTextBox.Name = "accountIDTextBox";
            this.accountIDTextBox.Size = new System.Drawing.Size(377, 51);
            this.accountIDTextBox.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(195, 36);
            this.label3.TabIndex = 5;
            this.label3.Text = "開戶金額：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(91, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 36);
            this.label2.TabIndex = 4;
            this.label2.Tag = "";
            this.label2.Text = "姓名：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 36);
            this.label1.TabIndex = 3;
            this.label1.Text = "帳號：";
            // 
            // balanceLabel
            // 
            this.balanceLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.balanceLabel.Location = new System.Drawing.Point(45, 394);
            this.balanceLabel.Name = "balanceLabel";
            this.balanceLabel.Size = new System.Drawing.Size(803, 473);
            this.balanceLabel.TabIndex = 7;
            this.balanceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(536, 291);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(196, 60);
            this.button1.TabIndex = 10;
            this.button1.Text = "離開";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // OpenAccountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 960);
            this.Controls.Add(this.balanceLabel);
            this.Controls.Add(this.CreateAccountGroupBox);
            this.Name = "OpenAccountForm";
            this.Text = "OpenAccountForm";
            this.CreateAccountGroupBox.ResumeLayout(false);
            this.CreateAccountGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox CreateAccountGroupBox;
        private System.Windows.Forms.Button CreateAccountButton;
        private System.Windows.Forms.TextBox balanceTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox accountIDTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label balanceLabel;
        private System.Windows.Forms.Button button1;
    }
}