using System;
using System.Globalization;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Review_Q2
{
    public partial class Form1 : Form
    {
        private const decimal LABOR_RATE_PER_HOUR = 600m;
        private const decimal PARTS_TAX_RATE = 0.06m;

        public Form1()
        {
            InitializeComponent();

            // Wire up events
            btnCalculate.Click += calculateButton_Click;
            btnClear.Click += clearButton_Click;
            btnExit.Click += exitButton_Click;
        }

        // Service charge methods
        private decimal OilLubeCharges()
        {
            decimal total = 0m;
            if (chkChangeOil.Checked) total += 780m;
            if (chkLubeService.Checked) total += 540m;
            return total;
        }

        private decimal FlushCharges()
        {
            decimal total = 0m;
            if (chkRadiatorFlush.Checked) total += 900m;
            if (chkTransmissionFlush.Checked) total += 2400m;
            return total;
        }

        private decimal MiscCharges()
        {
            decimal total = 0m;
            if (chkInspection.Checked) total += 450m;
            if (chkReplaceMuffler.Checked) total += 3000m;
            if (chkTireRotation.Checked) total += 600m;
            return total;
        }

        // Other charges: parts and labor
        private decimal OtherCharges(out decimal partsCost, out decimal laborCost)
        {
            partsCost = ParseDecimalSafe(txtParts.Text, 0m);
            if (partsCost < 0m)
            {
                MessageBox.Show("零件費用不可為負數，已改為 0。", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                partsCost = 0m;
            }

            decimal hours = ParseDecimalSafe(txtLaborHours.Text, 0m);
            if (hours < 0m)
            {
                MessageBox.Show("工時數不可為負數，已改為 0。", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                hours = 0m;
            }

            laborCost = hours * LABOR_RATE_PER_HOUR;

            return partsCost + laborCost; // not used directly but consistent
        }

        private decimal TaxCharges(decimal partsCost)
        {
            if (partsCost <= 0m) return 0m;
            return Math.Round(partsCost * PARTS_TAX_RATE, 2);
        }

        private decimal TotalCharges(decimal serviceAndLabor, decimal partsCost, decimal tax)
        {
            return serviceAndLabor + partsCost + tax;
        }

        // Event handlers
        private void calculateButton_Click(object? sender, EventArgs e)
        {
            // Calculate service charges
            decimal oilLube = OilLubeCharges();
            decimal flushes = FlushCharges();
            decimal misc = MiscCharges();

            decimal serviceCharges = oilLube + flushes + misc;

            // parts and labor
            decimal partsCost, laborCost;
            OtherCharges(out partsCost, out laborCost);

            decimal serviceAndLabor = serviceCharges + laborCost;
            decimal tax = TaxCharges(partsCost);
            decimal total = TotalCharges(serviceAndLabor, partsCost, tax);

            // Format as currency (NT$)
            var ci = CultureInfo.CreateSpecificCulture("zh-TW");

            lblServiceLaborValue.Text = serviceAndLabor.ToString("C0", ci);
            lblPartsCostValue.Text = partsCost.ToString("C0", ci);
            lblPartsTaxValue.Text = tax.ToString("C0", ci);
            lblTotalCostValue.Text = total.ToString("C0", ci);
        }

        private void clearButton_Click(object? sender, EventArgs e)
        {
            ClearOilLube();
            ClearFlushes();
            ClearMisc();
            ClearOther();
            ClearFees();
        }

        private void exitButton_Click(object? sender, EventArgs e)
        {
            var result = MessageBox.Show("在離開前是否要儲存維修明細？", "儲存明細", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (result == DialogResult.Cancel)
            {
                return; // do nothing
            }
            else if (result == DialogResult.Yes)
            {
                if (!SaveServiceDetailsToFile())
                {
                    // If save failed or was cancelled, don't exit
                    return;
                }
            }

            Close();
        }

        // Clear methods
        private void ClearOilLube()
        {
            chkChangeOil.Checked = false;
            chkLubeService.Checked = false;
        }

        private void ClearFlushes()
        {
            chkRadiatorFlush.Checked = false;
            chkTransmissionFlush.Checked = false;
        }

        private void ClearMisc()
        {
            chkInspection.Checked = false;
            chkReplaceMuffler.Checked = false;
            chkTireRotation.Checked = false;
        }

        private void ClearOther()
        {
            txtParts.Text = string.Empty;
            txtLaborHours.Text = string.Empty;
        }

        private void ClearFees()
        {
            lblServiceLaborValue.Text = string.Empty;
            lblPartsCostValue.Text = string.Empty;
            lblPartsTaxValue.Text = string.Empty;
            lblTotalCostValue.Text = string.Empty;
        }

        // File save
        private bool SaveServiceDetailsToFile()
        {
            try
            {
                // Build report
                var sb = new StringBuilder();
                var now = DateTime.Now;
                sb.AppendLine("汽車維修服務明細");
                sb.AppendLine("日期: " + now.ToString("yyyy-MM-dd HH:mm:ss"));
                sb.AppendLine(new string('-', 60));
                sb.AppendLine("服務項目:");

                decimal oilLube = OilLubeCharges();
                decimal flushes = FlushCharges();
                decimal misc = MiscCharges();
                decimal serviceCharges = oilLube + flushes + misc;

                if (chkChangeOil.Checked) sb.AppendLine(" - 更換機油: NT$780");
                if (chkLubeService.Checked) sb.AppendLine(" - 潤滑保養: NT$540");
                if (chkRadiatorFlush.Checked) sb.AppendLine(" - 水箱清洗: NT$900");
                if (chkTransmissionFlush.Checked) sb.AppendLine(" - 變速箱清洗: NT$2,400");
                if (chkInspection.Checked) sb.AppendLine(" - 檢驗: NT$450");
                if (chkReplaceMuffler.Checked) sb.AppendLine(" - 更換消音器: NT$3,000");
                if (chkTireRotation.Checked) sb.AppendLine(" - 輪胎換位: NT$600");

                sb.AppendLine();

                decimal partsCost = ParseDecimalSafe(txtParts.Text, 0m);
                decimal hours = ParseDecimalSafe(txtLaborHours.Text, 0m);
                if (partsCost < 0m) partsCost = 0m;
                if (hours < 0m) hours = 0m;

                decimal laborCost = hours * LABOR_RATE_PER_HOUR;
                decimal tax = TaxCharges(partsCost);
                decimal serviceAndLabor = serviceCharges + laborCost;
                decimal total = TotalCharges(serviceAndLabor, partsCost, tax);

                sb.AppendLine("明細:");
                sb.AppendLine($"  服務與工資: NT${serviceAndLabor:N0}");
                sb.AppendLine($"  零件: NT${partsCost:N0}");
                sb.AppendLine($"  稅金(零件 6%): NT${tax:N0}");
                sb.AppendLine($"  總費用: NT${total:N0}");
                sb.AppendLine();
                sb.AppendLine("計算過程:");
                sb.AppendLine($"  服務費用小計: NT${serviceCharges:N0}");
                sb.AppendLine($"  工時: {hours} 小時 x NT${LABOR_RATE_PER_HOUR:N0} = NT${laborCost:N0}");
                sb.AppendLine($"  零件費用: NT${partsCost:N0}");
                sb.AppendLine($"  零件稅 ({PARTS_TAX_RATE:P0}): NT${tax:N0}");
                sb.AppendLine($"  最終總費用: NT${total:N0}");

                sb.AppendLine(new string('-', 60));

                using (var sfd = new SaveFileDialog())
                {
                    sfd.Title = "儲存維修明細";
                    sfd.Filter = "文字檔 (*.txt)|*.txt|所有檔案 (*.*)|*.*";
                    sfd.DefaultExt = "txt";
                    sfd.FileName = "RepairReport_" + now.ToString("yyyyMMdd_HHmmss") + ".txt";

                    if (sfd.ShowDialog() != DialogResult.OK)
                    {
                        return false; // user cancelled
                    }

                    using (var writer = new StreamWriter(sfd.FileName, false, new UTF8Encoding(false)))
                    {
                        writer.Write(sb.ToString());
                    }
                }

                MessageBox.Show("已成功儲存維修明細。", "儲存完成", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("儲存檔案時發生錯誤：\n" + ex.Message, "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        // Helper: safe decimal parse
        private decimal ParseDecimalSafe(string? text, decimal defaultValue)
        {
            if (string.IsNullOrWhiteSpace(text)) return defaultValue;
            decimal value;
            // Try current culture then invariant
            if (decimal.TryParse(text, NumberStyles.Number, CultureInfo.CurrentCulture, out value))
            {
                return value;
            }
            if (decimal.TryParse(text, NumberStyles.Number, CultureInfo.InvariantCulture, out value))
            {
                return value;
            }
            return defaultValue;
        }
    }
}
