using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coin_Toss
{
    class Coin
    {
        Random rand = new Random();   // 建立隨機數產生器。         
        private string sideUp;

        public Coin()
        { 
            sideUp = "Heads";  // 將初始面設定為「正面」。
        }
        public void Toss()
        {                        
            int tossResult = rand.Next(2);  // 產生隨機數，結果為 0 或 1。            
            if (tossResult == 0)  // 根據隨機結果設定顯示面。
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


