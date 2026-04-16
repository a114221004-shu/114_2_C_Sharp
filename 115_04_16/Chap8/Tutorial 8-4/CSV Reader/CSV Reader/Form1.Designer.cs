namespace CSV_Reader
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
            this.averagesListBox = new System.Windows.Forms.ListBox();
            this.getScoresButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // averagesListBox
            // 
            // 設定列表框的字型為繁體中文常用字型，字號 18
            this.averagesListBox.Font = new System.Drawing.Font("Microsoft JhengHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.averagesListBox.FormattingEnabled = true;
            // 調整位置與大小以配合較大的字型，並保留適當的邊界
            this.averagesListBox.Location = new System.Drawing.Point(12, 12);
            this.averagesListBox.Name = "averagesListBox";
            this.averagesListBox.Size = new System.Drawing.Size(400, 160);
            this.averagesListBox.TabIndex = 0;
            // 
            // getScoresButton
            // 
            // 按鈕文字改為繁體中文「取得成績」，字型同為 18
            this.getScoresButton.Font = new System.Drawing.Font("Microsoft JhengHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            // 將按鈕放置於列表框之下並靠左一些，增加按鈕大小以便顯示中文文字
            this.getScoresButton.Location = new System.Drawing.Point(70, 185);
            this.getScoresButton.Name = "getScoresButton";
            this.getScoresButton.Size = new System.Drawing.Size(120, 40);
            this.getScoresButton.TabIndex = 1;
            this.getScoresButton.Text = "取得成績";
            this.getScoresButton.UseVisualStyleBackColor = true;
            this.getScoresButton.Click += new System.EventHandler(this.getScoresButton_Click);
            // 
            // exitButton
            // 
            // 按鈕文字改為繁體中文「離開」，字型同為 18
            this.exitButton.Font = new System.Drawing.Font("Microsoft JhengHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            // 將離開按鈕放在取得成績按鈕的右側，保持間距一致
            this.exitButton.Location = new System.Drawing.Point(220, 185);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(120, 40);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "離開";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            // 調整表單大小以容納放大後的控制項與字型
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 240);
            // 將控制項加入表單，順序保持原本的 TabIndex 設定
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.getScoresButton);
            this.Controls.Add(this.averagesListBox);
            this.Name = "Form1";
            // 表單標題改為繁體中文
            this.Text = "CSV 讀取器";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox averagesListBox;
        private System.Windows.Forms.Button getScoresButton;
        private System.Windows.Forms.Button exitButton;
    }
}

