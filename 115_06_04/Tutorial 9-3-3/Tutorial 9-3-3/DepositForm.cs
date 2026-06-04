using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tutorial_9_3_3
{
    public partial class DepositForm : Form
    {
        private List<BankAccount> bankAccounts;
        public DepositForm()
        {
            InitializeComponent();
        }

        public DepositForm(List<BankAccount> accounts)
        {
            InitializeComponent();
            this.bankAccounts = accounts ?? new List<BankAccount>();

            // 顯示或隱藏存款群組視圖，若沒有帳戶則隱藏
            this.depositGroupBox.Visible = (this.bankAccounts.Count > 0);
        }

        private void depositButton_Click(object sender, EventArgs e)
        {
            // 讀取使用者輸入的帳號
            string accountId = depositIdTextBox.Text.Trim();
            if (string.IsNullOrEmpty(accountId))
            {
                MessageBox.Show("請輸入帳號", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 在列表中尋找對應帳號
            BankAccount target = null;
            foreach (var a in bankAccounts)
            {
                if (a.AccountNumber == accountId)
                {
                    target = a;
                    break;
                }
            }

            if (target == null)
            {
                MessageBox.Show("找不到對應的帳號", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // 解析存款金額
            if (!decimal.TryParse(depositTextBox.Text.Trim(), out decimal amount))
            {
                MessageBox.Show("請輸入有效的存款金額", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 執行存款
            target.Deposit(amount);

            // 更新畫面顯示該帳戶資訊
            balanceLabel.Text = target.AccountNumber + "\n" + target.Name + "\n" + target.Balance.ToString("C");

            // 清空存款輸入欄位
            depositTextBox.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
