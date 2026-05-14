using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cell_Phone_Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // GetPhoneData 方法接受一個 CellPhone 物件作為參數。
        // 此方法應將使用者輸入的資料指派給該物件的屬性。
        private void GetPhoneData(CellPhone phone)
        {
            phone.Brand = brandTextBox.Text;  // 從品牌輸入框獲取文本並賦值給 phone 的 Brand 屬性
            phone.Model = modelTextBox.Text;  // 從型號輸入框獲取文本並賦值給 phone 的 Model 屬性
            if (decimal.TryParse(priceTextBox.Text, out decimal price))  // 嘗試將價格輸入框的文本轉換為 decimal 類型
            {
                phone.Price = price;  // 如果轉換成功，將價格賦值給 phone 的 Price 屬性
            }
            else
            {
                MessageBox.Show("請輸入有效的價格。");  // 如果轉換失敗，顯示錯誤消息
                phone.Price = 0;  // 將價格設置為 0 或其他適當的默認值
            }

        }

        private void createObjectButton_Click(object sender, EventArgs e)
        {
            CellPhone myPhone = new CellPhone(); // 創建一個 CellPhone 類別的實例，命名為 myPhone。

            GetPhoneData(myPhone);   // 呼叫 GetPhoneData 方法，將 myPhone 物件傳遞給它，以便從使用者輸入中填充該物件的屬性。

            brandLabel.Text = myPhone.Brand;  // 將品牌顯示在標籤上
            modelLabel.Text = myPhone.Model;  // 將型號顯示在標籤上
            priceLabel.Text = myPhone.Price.ToString("C");  // 將價格轉換為字串以顯示在標籤上
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉表單
            this.Close();
        }
    }
}
