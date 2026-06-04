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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void displayButton_Click(object sender, EventArgs e)
        {
            // Create an instance of the NutritionForm class.
            FoodItem selectedFood = null;

            // Find the selected radio button.
            if (bananaRadioButton.Checked)
            {
                selectedFood = new FoodItem("1 根香蕉", 100, 0.4, 27);
           
            }
            else if (popcornRadioButton.Checked)
            {
                selectedFood = new FoodItem("1 杯氣爆玉米花", 31, 0.4, 6);
               
            }
            else if (muffinRadioButton.Checked)
            {
                selectedFood = new FoodItem("1 個大藍莓馬芬", 385, 9, 67);
            }

            // Display the NutritionForm if a food was selected.
            if (selectedFood != null)
            {
                NutritionForm nutriForm = new NutritionForm();
                nutriForm.foodLabel.Text = selectedFood.Name;
                nutriForm.caloriesLabel.Text = selectedFood.Calories.ToString();
                nutriForm.fatLabel.Text = selectedFood.Fat.ToString();
                nutriForm.carbLabel.Text = selectedFood.Carb.ToString();
                nutriForm.ShowDialog();
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
