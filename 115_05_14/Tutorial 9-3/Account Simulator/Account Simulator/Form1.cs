using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Account_Simulator
{
    public partial class Form1 : Form
    {
        private BankAccount account = new BankAccount(20000m);
        // BankAccount 欄位：使用 20000 作為初始餘額（decimal 後綴 m），供表單中的存提款操作使用。


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // 顯示起始餘額：將帳戶餘額以貨幣格式（C）顯示在 balanceLabel 上。
            balanceLabel.Text = account.Balance.ToString("C");
        }

        private void depositButton_Click(object sender, EventArgs e)
        {
            // 從使用者輸入的 depositTextBox 取得欲存入的金額，並解析為 decimal。
            decimal amount;
            if (decimal.TryParse(depositTextBox.Text, out amount))
            {
                // 呼叫 BankAccount.Deposit 執行存款。
                account.Deposit(amount);
                // 更新畫面上顯示的餘額（以貨幣格式顯示）。
                balanceLabel.Text = account.Balance.ToString("C");
                depositTextBox.Clear(); // 清空存款輸入框，方便下一次輸入。
            }
            else
            {
                // 若輸入無法解析為 decimal，顯示錯誤訊息。
                MessageBox.Show("請輸入有效的存款金額");
                depositTextBox.Clear(); // 清空存款輸入框，讓使用者重新輸入。
            }
        }

        private void withdrawButton_Click(object sender, EventArgs e)
        {
            // 從使用者輸入的 withdrawTextBox 取得欲提款的金額，並解析為 decimal。
            decimal amount;
            if (decimal.TryParse(withdrawTextBox.Text, out amount))
            {
                // 呼叫 BankAccount.Withdraw 執行提款。
                account.Withdraw(amount);
                // 更新畫面上顯示的餘額（以貨幣格式顯示）。
                balanceLabel.Text = account.Balance.ToString("C");
                withdrawTextBox.Clear(); // 清空提款輸入框，方便下一次輸入。
            }
            else
            {
                // 若輸入無法解析為 decimal，顯示錯誤訊息。
                MessageBox.Show("請輸入有效的提款金額");
                withdrawTextBox.Clear(); // 清空提款輸入框，讓使用者重新輸入。
            }
        }
                            
        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉表單並結束程式視窗。
            this.Close();
        }
    }
}
