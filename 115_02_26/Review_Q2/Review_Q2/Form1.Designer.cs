namespace Review_Q2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        // UI controls
        private System.Windows.Forms.GroupBox groupBoxOil;
        private System.Windows.Forms.CheckBox cbChangeOil;
        private System.Windows.Forms.CheckBox cbLubeJob;

        private System.Windows.Forms.GroupBox groupBoxWash;
        private System.Windows.Forms.CheckBox cbRadiatorFlush;
        private System.Windows.Forms.CheckBox cbTransmissionFlush;

        private System.Windows.Forms.GroupBox groupBoxOther;
        private System.Windows.Forms.CheckBox cbInspection;
        private System.Windows.Forms.CheckBox cbReplaceMuffler;
        private System.Windows.Forms.CheckBox cbTireRotation;

        private System.Windows.Forms.GroupBox groupBoxPartsLabor;
        private System.Windows.Forms.Label lblParts;
        private System.Windows.Forms.TextBox txtParts;
        private System.Windows.Forms.Label lblHours;
        private System.Windows.Forms.TextBox txtHours;

        private System.Windows.Forms.GroupBox groupBoxSummary;
        private System.Windows.Forms.Label lblServiceLabor; // descriptor
        private System.Windows.Forms.Label lblServiceLaborValue; // value label (replaces textbox)
        private System.Windows.Forms.Label lblPartsSummary; // descriptor
        private System.Windows.Forms.Label lblPartsSummaryValue; // value label (replaces textbox)
        private System.Windows.Forms.Label lblTax; // descriptor
        private System.Windows.Forms.Label lblTaxValue; // value label (replaces textbox)
        private System.Windows.Forms.Label lblTotal; // descriptor
        private System.Windows.Forms.Label lblTotalValue; // value label (replaces textbox)

        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;

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
            groupBoxOil = new GroupBox();
            cbChangeOil = new CheckBox();
            cbLubeJob = new CheckBox();
            groupBoxWash = new GroupBox();
            cbRadiatorFlush = new CheckBox();
            cbTransmissionFlush = new CheckBox();
            groupBoxOther = new GroupBox();
            cbInspection = new CheckBox();
            cbReplaceMuffler = new CheckBox();
            cbTireRotation = new CheckBox();
            groupBoxPartsLabor = new GroupBox();
            lblParts = new Label();
            txtParts = new TextBox();
            lblHours = new Label();
            txtHours = new TextBox();
            groupBoxSummary = new GroupBox();
            lblServiceLabor = new Label();
            lblServiceLaborValue = new Label();
            lblPartsSummary = new Label();
            lblPartsSummaryValue = new Label();
            lblTax = new Label();
            lblTaxValue = new Label();
            lblTotal = new Label();
            lblTotalValue = new Label();
            btnCalculate = new Button();
            btnClear = new Button();
            btnExit = new Button();
            groupBoxOil.SuspendLayout();
            groupBoxWash.SuspendLayout();
            groupBoxOther.SuspendLayout();
            groupBoxPartsLabor.SuspendLayout();
            groupBoxSummary.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxOil
            // 
            groupBoxOil.Controls.Add(cbChangeOil);
            groupBoxOil.Controls.Add(cbLubeJob);
            groupBoxOil.Location = new Point(12, 12);
            groupBoxOil.Name = "groupBoxOil";
            groupBoxOil.Size = new Size(240, 90);
            groupBoxOil.TabIndex = 0;
            groupBoxOil.TabStop = false;
            groupBoxOil.Text = "機油和潤滑";
            // 
            // cbChangeOil
            // 
            cbChangeOil.AutoSize = true;
            cbChangeOil.Location = new Point(12, 24);
            cbChangeOil.Name = "cbChangeOil";
            cbChangeOil.Size = new Size(190, 27);
            cbChangeOil.TabIndex = 0;
            cbChangeOil.Text = "更換機油 (NT$780)";
            // 
            // cbLubeJob
            // 
            cbLubeJob.AutoSize = true;
            cbLubeJob.Location = new Point(12, 52);
            cbLubeJob.Name = "cbLubeJob";
            cbLubeJob.Size = new Size(190, 27);
            cbLubeJob.TabIndex = 1;
            cbLubeJob.Text = "潤滑保養 (NT$540)";
            // 
            // groupBoxWash
            // 
            groupBoxWash.Controls.Add(cbRadiatorFlush);
            groupBoxWash.Controls.Add(cbTransmissionFlush);
            groupBoxWash.Location = new Point(268, 12);
            groupBoxWash.Name = "groupBoxWash";
            groupBoxWash.Size = new Size(240, 90);
            groupBoxWash.TabIndex = 1;
            groupBoxWash.TabStop = false;
            groupBoxWash.Text = "清洗服務";
            // 
            // cbRadiatorFlush
            // 
            cbRadiatorFlush.AutoSize = true;
            cbRadiatorFlush.Location = new Point(12, 24);
            cbRadiatorFlush.Name = "cbRadiatorFlush";
            cbRadiatorFlush.Size = new Size(190, 27);
            cbRadiatorFlush.TabIndex = 0;
            cbRadiatorFlush.Text = "水箱清洗 (NT$900)";
            // 
            // cbTransmissionFlush
            // 
            cbTransmissionFlush.AutoSize = true;
            cbTransmissionFlush.Location = new Point(12, 52);
            cbTransmissionFlush.Name = "cbTransmissionFlush";
            cbTransmissionFlush.Size = new Size(222, 27);
            cbTransmissionFlush.TabIndex = 1;
            cbTransmissionFlush.Text = "變速箱清洗 (NT$2,400)";
            // 
            // groupBoxOther
            // 
            groupBoxOther.Controls.Add(cbInspection);
            groupBoxOther.Controls.Add(cbReplaceMuffler);
            groupBoxOther.Controls.Add(cbTireRotation);
            groupBoxOther.Location = new Point(12, 110);
            groupBoxOther.Name = "groupBoxOther";
            groupBoxOther.Size = new Size(240, 110);
            groupBoxOther.TabIndex = 2;
            groupBoxOther.TabStop = false;
            groupBoxOther.Text = "其他服務";
            // 
            // cbInspection
            // 
            cbInspection.AutoSize = true;
            cbInspection.Location = new Point(12, 24);
            cbInspection.Name = "cbInspection";
            cbInspection.Size = new Size(154, 27);
            cbInspection.TabIndex = 0;
            cbInspection.Text = "檢驗 (NT$450)";
            // 
            // cbReplaceMuffler
            // 
            cbReplaceMuffler.AutoSize = true;
            cbReplaceMuffler.Location = new Point(12, 52);
            cbReplaceMuffler.Name = "cbReplaceMuffler";
            cbReplaceMuffler.Size = new Size(222, 27);
            cbReplaceMuffler.TabIndex = 1;
            cbReplaceMuffler.Text = "更換消音器 (NT$3,000)";
            // 
            // cbTireRotation
            // 
            cbTireRotation.AutoSize = true;
            cbTireRotation.Location = new Point(12, 80);
            cbTireRotation.Name = "cbTireRotation";
            cbTireRotation.Size = new Size(190, 27);
            cbTireRotation.TabIndex = 2;
            cbTireRotation.Text = "輪胎定位 (NT$600)";
            // 
            // groupBoxPartsLabor
            // 
            groupBoxPartsLabor.Controls.Add(lblParts);
            groupBoxPartsLabor.Controls.Add(txtParts);
            groupBoxPartsLabor.Controls.Add(lblHours);
            groupBoxPartsLabor.Controls.Add(txtHours);
            groupBoxPartsLabor.Location = new Point(268, 110);
            groupBoxPartsLabor.Name = "groupBoxPartsLabor";
            groupBoxPartsLabor.Size = new Size(240, 110);
            groupBoxPartsLabor.TabIndex = 3;
            groupBoxPartsLabor.TabStop = false;
            groupBoxPartsLabor.Text = "零件和工時";
            // 
            // lblParts
            // 
            lblParts.AutoSize = true;
            lblParts.Location = new Point(12, 28);
            lblParts.Name = "lblParts";
            lblParts.Size = new Size(93, 23);
            lblParts.TabIndex = 0;
            lblParts.Text = "零件(NT$)";
            // 
            // txtParts
            // 
            txtParts.Location = new Point(100, 24);
            txtParts.Name = "txtParts";
            txtParts.Size = new Size(120, 30);
            txtParts.TabIndex = 1;
            // 
            // lblHours
            // 
            lblHours.AutoSize = true;
            lblHours.Location = new Point(12, 64);
            lblHours.Name = "lblHours";
            lblHours.Size = new Size(117, 23);
            lblHours.TabIndex = 2;
            lblHours.Text = "工時數 (小時)";
            // 
            // txtHours
            // 
            txtHours.Location = new Point(100, 60);
            txtHours.Name = "txtHours";
            txtHours.Size = new Size(120, 30);
            txtHours.TabIndex = 3;
            // 
            // groupBoxSummary
            // 
            groupBoxSummary.Controls.Add(lblServiceLabor);
            groupBoxSummary.Controls.Add(lblServiceLaborValue);
            groupBoxSummary.Controls.Add(lblPartsSummary);
            groupBoxSummary.Controls.Add(lblPartsSummaryValue);
            groupBoxSummary.Controls.Add(lblTax);
            groupBoxSummary.Controls.Add(lblTaxValue);
            groupBoxSummary.Controls.Add(lblTotal);
            groupBoxSummary.Controls.Add(lblTotalValue);
            groupBoxSummary.Location = new Point(12, 232);
            groupBoxSummary.Name = "groupBoxSummary";
            groupBoxSummary.Size = new Size(496, 130);
            groupBoxSummary.TabIndex = 4;
            groupBoxSummary.TabStop = false;
            groupBoxSummary.Text = "費用摘要";
            // 
            // lblServiceLabor
            // 
            lblServiceLabor.AutoSize = true;
            lblServiceLabor.Location = new Point(12, 28);
            lblServiceLabor.Name = "lblServiceLabor";
            lblServiceLabor.Size = new Size(100, 23);
            lblServiceLabor.TabIndex = 0;
            lblServiceLabor.Text = "服務與工資";
            // 
            // lblServiceLaborValue
            // 
            lblServiceLaborValue.BorderStyle = BorderStyle.Fixed3D;
            lblServiceLaborValue.Location = new Point(130, 24);
            lblServiceLaborValue.Name = "lblServiceLaborValue";
            lblServiceLaborValue.Size = new Size(120, 23);
            lblServiceLaborValue.TabIndex = 1;
            // 
            // lblPartsSummary
            // 
            lblPartsSummary.AutoSize = true;
            lblPartsSummary.Location = new Point(12, 58);
            lblPartsSummary.Name = "lblPartsSummary";
            lblPartsSummary.Size = new Size(46, 23);
            lblPartsSummary.TabIndex = 2;
            lblPartsSummary.Text = "零件";
            // 
            // lblPartsSummaryValue
            // 
            lblPartsSummaryValue.BorderStyle = BorderStyle.Fixed3D;
            lblPartsSummaryValue.Location = new Point(130, 54);
            lblPartsSummaryValue.Name = "lblPartsSummaryValue";
            lblPartsSummaryValue.Size = new Size(120, 23);
            lblPartsSummaryValue.TabIndex = 3;
            // 
            // lblTax
            // 
            lblTax.AutoSize = true;
            lblTax.Location = new Point(12, 88);
            lblTax.Name = "lblTax";
            lblTax.Size = new Size(99, 23);
            lblTax.TabIndex = 4;
            lblTax.Text = "稅金 (零件)";
            // 
            // lblTaxValue
            // 
            lblTaxValue.BorderStyle = BorderStyle.Fixed3D;
            lblTaxValue.Location = new Point(130, 84);
            lblTaxValue.Name = "lblTaxValue";
            lblTaxValue.Size = new Size(120, 23);
            lblTaxValue.TabIndex = 5;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(280, 58);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(64, 23);
            lblTotal.TabIndex = 6;
            lblTotal.Text = "總費用";
            // 
            // lblTotalValue
            // 
            lblTotalValue.BorderStyle = BorderStyle.Fixed3D;
            lblTotalValue.Location = new Point(340, 54);
            lblTotalValue.Name = "lblTotalValue";
            lblTotalValue.Size = new Size(140, 23);
            lblTotalValue.TabIndex = 7;
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(90, 370);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(100, 30);
            btnCalculate.TabIndex = 5;
            btnCalculate.Text = "計算總額";
            // 
            // btnClear
            // 
            btnClear.Location = new Point(210, 370);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(100, 30);
            btnClear.TabIndex = 6;
            btnClear.Text = "清除";
            // 
            // btnExit
            // 
            btnExit.Location = new Point(330, 370);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(100, 30);
            btnExit.TabIndex = 7;
            btnExit.Text = "離開";
            // 
            // Form1
            // 
            ClientSize = new Size(520, 420);
            Controls.Add(groupBoxOil);
            Controls.Add(groupBoxWash);
            Controls.Add(groupBoxOther);
            Controls.Add(groupBoxPartsLabor);
            Controls.Add(groupBoxSummary);
            Controls.Add(btnCalculate);
            Controls.Add(btnClear);
            Controls.Add(btnExit);
            Name = "Form1";
            Text = "汽車維修服務";
            groupBoxOil.ResumeLayout(false);
            groupBoxOil.PerformLayout();
            groupBoxWash.ResumeLayout(false);
            groupBoxWash.PerformLayout();
            groupBoxOther.ResumeLayout(false);
            groupBoxOther.PerformLayout();
            groupBoxPartsLabor.ResumeLayout(false);
            groupBoxPartsLabor.PerformLayout();
            groupBoxSummary.ResumeLayout(false);
            groupBoxSummary.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
    }
}
