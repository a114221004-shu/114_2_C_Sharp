using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Food_Facts
{
    public partial class NutritionForm : Form
    {
        // 儲存目前要顯示的食物資料
        private FoodItem foodItem;

        // 預設建構子：初始化元件
        public NutritionForm()
        {
            InitializeComponent();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }

        // 設定要顯示的食物資料


        private void NutritionForm_Load(object sender, EventArgs e)
        {
            if (foodItem != null)
            {
                foodLabel.Text = foodItem.Name;
                caloriesLabel.Text = foodItem.Calories.ToString();
                fatLabel.Text = foodItem.Fat.ToString();
                carbLabel.Text = foodItem.Carb.ToString();
            }
        }
    }
}
