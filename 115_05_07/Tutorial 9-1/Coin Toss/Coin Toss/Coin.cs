using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coin_Toss
{
    internal class Coin
    {
        private string sideUp; // 正面或反面
        
        public Coin()
        {
            // 將硬幣初始化為隨機面向。
            sideUp = "Heads"; // 預設為正面
        }

        public void Toss()
        {
            Random rand = new Random();
            if (rand.Next(2) == 0)
            {
                sideUp = "Heads";
            }
            else
            {
                sideUp = "Tails";
            }
        }

        public string GetSideUp()
        {
            return sideUp;
        }
    }
}
