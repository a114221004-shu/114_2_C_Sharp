using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Telephone_Format
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // The IsValidNumber method accepts a string and
        // returns true if it contains 10 digits, or false
        // otherwise.
        private bool IsValidNumber(string str)
        {
            if(str == null || str.Length != 10)
            {
                return false;
            }
            foreach (char c in str)
            {
                if (!char.IsDigit(c))
                {
                    return false;
                }
            }
            return true;
        }

        // The TelephoneFormat method accepts a string argument
        // by reference and formats it as a telephone number.
        private void TelephoneFormat(ref string str)
        {
            //string part1 = str.Substring(0, 2);
            //string part2 = str.Substring(2, 4);
            //string part3 = str.Substring(6, 4);
            //str = "("+part1+")"+part2+"-"+part3;
            str = str.Insert(0, "(")
                     .Insert(3, ")")
                     .Insert(9, "-");
        }

        private void formatButton_Click(object sender, EventArgs e)
        {
            string number = numberTextBox.Text;
            if (IsValidNumber(number))
            {
                TelephoneFormat(ref number);
                MessageBox.Show("格式化後的電話號碼是: " + number);
            }
            else
            {
                MessageBox.Show("請輸入一個10位數字。");
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }
    }
}
