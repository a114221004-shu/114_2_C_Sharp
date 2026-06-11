namespace WindowsFormsApp2
{
    partial class 修改員工資料
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

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblDept;
        private System.Windows.Forms.TextBox txtDept;
        private System.Windows.Forms.Label lblJob;
        private System.Windows.Forms.TextBox txtJob;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox msgBox;

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.labelTitle = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.btnQuery = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblDept = new System.Windows.Forms.Label();
            this.txtDept = new System.Windows.Forms.TextBox();
            this.lblJob = new System.Windows.Forms.Label();
            this.txtJob = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.msgBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("新細明體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelTitle.Location = new System.Drawing.Point(20, 12);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(200, 32);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "修改員工資料";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(40, 80);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(72, 16);
            this.lblId.TabIndex = 1;
            this.lblId.Text = "員工編號：";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(150, 76);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(360, 27);
            this.txtId.TabIndex = 2;
            // 
            // btnQuery
            // 
            this.btnQuery.Location = new System.Drawing.Point(240, 110);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(100, 36);
            this.btnQuery.TabIndex = 3;
            this.btnQuery.Text = "查詢";
            this.btnQuery.UseVisualStyleBackColor = true;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(40, 160);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(40, 16);
            this.lblName.TabIndex = 4;
            this.lblName.Text = "姓名：";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(150, 156);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(360, 27);
            this.txtName.TabIndex = 5;
            // 
            // lblDept
            // 
            this.lblDept.AutoSize = true;
            this.lblDept.Location = new System.Drawing.Point(40, 200);
            this.lblDept.Name = "lblDept";
            this.lblDept.Size = new System.Drawing.Size(40, 16);
            this.lblDept.TabIndex = 6;
            this.lblDept.Text = "部門：";
            // 
            // txtDept
            // 
            this.txtDept.Location = new System.Drawing.Point(150, 196);
            this.txtDept.Name = "txtDept";
            this.txtDept.Size = new System.Drawing.Size(360, 27);
            this.txtDept.TabIndex = 7;
            // 
            // lblJob
            // 
            this.lblJob.AutoSize = true;
            this.lblJob.Location = new System.Drawing.Point(40, 240);
            this.lblJob.Name = "lblJob";
            this.lblJob.Size = new System.Drawing.Size(40, 16);
            this.lblJob.TabIndex = 8;
            this.lblJob.Text = "職稱：";
            // 
            // txtJob
            // 
            this.txtJob.Location = new System.Drawing.Point(150, 236);
            this.txtJob.Name = "txtJob";
            this.txtJob.Size = new System.Drawing.Size(360, 27);
            this.txtJob.TabIndex = 9;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(200, 280);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 36);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "儲存";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(320, 280);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 36);
            this.btnClose.TabIndex = 11;
            this.btnClose.Text = "離開";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // msgBox
            // 
            this.msgBox.Location = new System.Drawing.Point(30, 330);
            this.msgBox.Multiline = true;
            this.msgBox.Name = "msgBox";
            this.msgBox.ReadOnly = true;
            this.msgBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.msgBox.Size = new System.Drawing.Size(520, 120);
            this.msgBox.TabIndex = 12;
            // 
            // 修改員工資料
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 470);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.btnQuery);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblDept);
            this.Controls.Add(this.txtDept);
            this.Controls.Add(this.lblJob);
            this.Controls.Add(this.txtJob);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.msgBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "修改員工資料";
            this.Text = "修改員工資料";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
    }
}