using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Password_Validation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // 並回傳其中大寫字母的數量。
        private int NumberUpperCase(string str)
        {
            int count = 0;
            foreach (char c in str)
            {
                if (char.IsUpper(c))
                {
                    count++;
                }
            }
            return count;
        }

        // 並回傳其中小寫字母的數量。
        private int NumberLowerCase(string str)
        {
            int count = 0;
            foreach (char c in str)
            {
                if (char.IsLower(c))
                {
                    count++;
                }
            }
            return count;
        }

        // 並回傳其中數字字元的數量。
        private int NumberDigits(string str)
        {
            int count = 0;
            foreach (char c in str)
            {
                if (char.IsDigit(c))
                {
                    count++;
                }
            }
            return count;
        }

        // 並回傳其中特殊字元的數量。
        private int NumberSpecialCharacters(string str)
        {
            int count = 0;
            foreach (char c in str)
            {
                if (!char.IsLetterOrDigit(c))
                {
                    count++;
                }
            }
            return count;
        }

        private void checkPasswordButton_Click(object sender, EventArgs e)
        {
            const int MIN_LENGTH = 8;
            string password = passwordTextBox.Text;
            if (password.Length < MIN_LENGTH)
            {
                MessageBox.Show("密碼必須至少包含 8 個字元。");
                return;
            }
            else
            {
                int upperCaseCount = NumberUpperCase(password);
                int lowerCaseCount = NumberLowerCase(password);
                int digitCount = NumberDigits(password);
                if (upperCaseCount < 1)
                {
                    MessageBox.Show("密碼必須至少包含一個大寫字母。");
                    return;
                }
                else if (lowerCaseCount < 1)
                {
                    MessageBox.Show("密碼必須至少包含一個小寫字母。");
                    return;
                }
                else if (digitCount < 1)
                {
                    MessageBox.Show("密碼必須至少包含一個數字字元。");
                    return;
                }
                else
                {
                    MessageBox.Show("密碼有效！");
                }
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉視窗。
            this.Close();
        }

        private void instructionsLabel_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
