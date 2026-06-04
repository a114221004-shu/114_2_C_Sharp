using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Food_Facts
{
    internal class FoodItem
    {
        private string name;
        private double calories;
        private double fat;
        private double carb;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public double Calories
        {
            get { return calories; }
            set { calories = value; }
        }

        public double Carb
        {
            get { return carb; }
            set { carb = value; }
        }

        public double Fat
        {
            get { return fat; }
            set { fat = value; }
        }

        // 預設建構子：將欄位初始化為合理的預設值
        public FoodItem()
        {
            this.name = string.Empty;
            this.calories = 0.0;
            this.fat = 0.0;
            this.carb = 0.0;
        }

        // 具參數的建構子，方便直接建立帶資料的 FoodItem
        public FoodItem(string name, double calories, double fat, double carb)
        {
            this.name = name;
            this.calories = calories;
            this.fat = fat;
            this.carb = carb;
        }
    }
}
