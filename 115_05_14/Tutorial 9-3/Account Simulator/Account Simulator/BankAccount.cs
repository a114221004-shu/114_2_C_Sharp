using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Account_Simulator
{
    // BankAccount 類別：表示一個簡單的銀行帳戶
    // 此類別封裝帳戶餘額，並提供存款與提款的基本操作。
    // 所有輸入都會進行基本驗證，遇到非法參數或不足餘額時會拋出例外。
    class BankAccount
    {
        // 私有欄位：儲存帳戶的目前餘額
        // 使用 decimal 型別以避免浮點數精度問題，適合用於貨幣計算
        private decimal balance;

        /// <summary>
        /// 建構子：使用初始餘額建立帳戶
        /// </summary>
        /// <param name="initialBalance">初始餘額（以 decimal 表示）</param>
        public BankAccount(decimal initialBalance)
        {
            // 將初始餘額指派給內部欄位
            balance = initialBalance;
        }

        /// <summary>
        /// 讀取帳戶目前餘額（唯讀屬性）
        /// </summary>
        public decimal Balance
        {
            get { return balance; }
        }

        /// <summary>
        /// 對帳戶進行存款操作
        /// </summary>
        /// <param name="amount">欲存入的金額（必須大於 0）</param>
        /// <exception cref="ArgumentException">當 amount 小於等於 0 時拋出</exception>
        public void Deposit(decimal amount)
        {
            // 驗證存款金額必須為正值
            if (amount > 0)
            {
                // 將有效的金額加入餘額
                balance += amount;
            }
            else
            {
                // 若輸入不合法，顯示訊息框以告知使用者
                MessageBox.Show("存款金額必須為正數");
            }
        }

        /// <summary>
        /// 對帳戶進行提款操作
        /// </summary>
        /// <param name="amount">欲提取的金額（必須大於 0 且不得超過目前餘額）</param>
        /// <exception cref="ArgumentException">當 amount 小於等於 0 時拋出</exception>
        /// <exception cref="InvalidOperationException">當餘額不足以支應提款時拋出</exception>
        public void Withdraw(decimal amount)
        {
            // 驗證提款金額必須為正值
            if (amount > 0)
            {
                // 檢查是否有足夠的餘額
                if (amount > 0 && amount <= balance)
                {
                    // 若足夠，扣除餘額
                    balance -= amount;
                }
                else
                {
                    // 餘額不足，顯示訊息框以告知使用者
                    MessageBox.Show("餘額不足");
                }
            }
            else
            {
                // 非法提款金額，顯示訊息框以告知使用者
                MessageBox.Show("提款金額必須為正數");
            }
        }
    }
}
