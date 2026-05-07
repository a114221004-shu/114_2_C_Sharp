using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 吃角子老虎機遊戲
{
    public partial class Form1 : Form
    {
        // 目前餘額（balance）: 玩家可用的籌碼，初始為 0
        private int balance = 0;
        // 累計存入（totalDeposited）: 用於結算盈虧之用，初始為 0
        private int totalDeposited = 0;
        // 累計旋轉次數（totalSpins）: 每完成一次旋轉即 +1
        private int totalSpins = 0;
        // 累計中獎次數（winCount）: 每次 prize > 0 即 +1
        private int winCount = 0;
        // 上一次獲得的獎金（lastPrize / prize）: 供 UI 顯示使用
        private int lastPrize = 0;
        // 亂數產生器（rand / rng）: 用於決定圖片索引與動畫中隨機切換
        private Random rng = new Random();


        // 三個轉輪最終的圖片索引（n1, n2, n3），範圍依 imageList1.Images.Count 決定
        private int n1 = 0, n2 = 0, n3 = 0;
        // 本次旋轉獎金（prize），由 checkWinner 計算
        private int prize = 0;
        // 動畫計時器（spinTimer）: 每 80ms Tick 一次以驅動畫面切換
        private System.Windows.Forms.Timer spinTimer;
        // 目前已累計的 Tick 次數（spinTick），用於判斷何時停止每個轉輪
        private int spinTick = 0;
        // 本次下注金額（lastBet），動畫結束時用於判斷獎金
        private int lastBet = 0;
        // 每個 PictureBox 是否已停止的旗標（停止後顯示最終圖片）
        private bool pb1Stopped = false, pb2Stopped = false, pb3Stopped = false;
        // 停止門檻常數（Tick 次數）
        private const int TICKS_STOP_PB1 = 10; // 約 800ms
        private const int TICKS_STOP_PB2 = 17; // 約 1360ms
        private const int TICKS_STOP_PB3 = 24; // 約 1920ms

        // 儲存檔路徑（savegame.txt），位於執行檔同目錄
        private static readonly string SAVE_FILE = Path.Combine(Application.StartupPath, "savegame.txt");
        

        public Form1()
        {
            // 初始化 Windows Form 控制項（由 Designer 產生）
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // load saved game if exists
            LoadGame();

            this.comboBox_bet.Items.Clear();
            this.comboBox_bet.Items.AddRange(new object[] { "$1", "$5", "$10", "$50" });
            this.comboBox_bet.SelectedIndex = 0;

            this.button_deposit.Click += button_deposit_Click;
            this.comboBox_bet.SelectedIndexChanged += comboBox_bet_SelectedIndexChanged;
            this.button1.Click += button1_Click;

            // 設定動畫用的 Timer，Interval = 80ms
            spinTimer = new System.Windows.Forms.Timer();
            spinTimer.Interval = 80;
            spinTimer.Tick += spinTimer_Tick;

            // ensure save on close
            this.FormClosing += Form1_FormClosing;

            // 顯示初始圖片（getImage 的初始版本會同時決定亂數並顯示）
            GetImage();
            prize = 0;
            // 更新介面與統計顯示
            UpdateUI();
            UpdateStats();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            int netGain = balance - totalDeposited;
            string netLabel;
            string netAmount;
            if (netGain < 0)
            {
                netLabel = "虧損";
                netAmount = (-netGain).ToString("C");
            }
            else if (netGain > 0)
            {
                netLabel = "盈餘";
                netAmount = netGain.ToString("C");
            }
            else
            {
                netLabel = "持平";
                netAmount = netGain.ToString("C");
            }

            string msg = string.Format("累計存入：{0}\r\n目前餘額：{1}\r\n{2}：{3}\r\n\r\n旋轉次數：{4} 次　中獎次數：{5} 次",
                totalDeposited.ToString("C"), balance.ToString("C"), netLabel, netAmount, totalSpins, winCount);

            MessageBox.Show(msg, "結算摘要", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private int GetBetAmount()
        {
            if (this.comboBox_bet.SelectedItem == null) return 1;
            string s = this.comboBox_bet.SelectedItem.ToString();
            if (s.StartsWith("$")) s = s.Substring(1);
            int v;
            if (!int.TryParse(s, out v)) v = 1;
            return v;
        }

        private void GetImage()
        {
            int count = Math.Max(1, this.imageList1.Images.Count);
            if (this.imageList1.Images.Count == 0)
            {
                this.pictureBox1.Image = null;
                this.pictureBox2.Image = null;
                this.pictureBox3.Image = null;
                return;
            }

            // 為初始顯示隨機決定三個索引，並顯示於三個 PictureBox
            n1 = rng.Next(count);
            n2 = rng.Next(count);
            n3 = rng.Next(count);

            this.pictureBox1.Image = (Image)this.imageList1.Images[n1];
            this.pictureBox2.Image = (Image)this.imageList1.Images[n2];
            this.pictureBox3.Image = (Image)this.imageList1.Images[n3];
        }

        private int CheckWinner(int bet)
        {
            int pay = 0;
            // 三個相同為頭獎（下注 x10）
            if (n1 == n2 && n2 == n3)
            {
                pay = bet * 10;
            }
            // 任意兩個相同為普獎（下注 x2）
            else if (n1 == n2 || n1 == n3 || n2 == n3)
            {
                pay = bet * 2;
            }
            return pay;
        }

        private void UpdateUI()
        {
            // 更新餘額與本次獲得之顯示，使用貨幣格式
            this.label_balance.Text = "餘額：" + balance.ToString("C");
            this.label_lastWin.Text = "本次獲得：" + prize.ToString("C");

            // 決定旋轉按鈕是否可用
            // 若動畫進行中（spinTimer.Enabled），則強制停用旋轉按鈕以避免重複觸發
            if (spinTimer != null && spinTimer.Enabled)
            {
                this.button1.Enabled = false;
            }
            else
            {
                int bet = GetBetAmount();
                this.button1.Enabled = (balance >= bet && balance > 0);
            }
        }

        private void UpdateStats()
        {
            this.label_totalSpins.Text = $"旋轉：{totalSpins} 次";
            this.label_winCount.Text = $"中獎：{winCount} 次";
            double rate = 0.0;
            if (totalSpins > 0) rate = (double)winCount / totalSpins * 100.0;
            this.label_winRate.Text = $"勝率：{rate:F1}%";
        }

        private void comboBox_bet_SelectedIndexChanged(object sender, EventArgs e)
        {
            // 切換下注金額時也需檢查動畫狀態，以免在動畫中改變按鈕可用性
            UpdateUI();
        }

        private void button_deposit_Click(object sender, EventArgs e)
        {
            string txt = this.textBox_deposit.Text.Trim();
            int v;
            if (!int.TryParse(txt, out v) || v <= 0)
            {
                // 輸入不是正整數時以訊息方塊提示，並中止存入流程
                MessageBox.Show("請輸入有效的存入金額（必須為正整數）", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            balance += v;
            totalDeposited += v;
            this.textBox_deposit.Text = string.Empty;
            UpdateUI();
            UpdateStats();
            SaveGame();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int bet = GetBetAmount();
            if (balance < bet) { UpdateUI(); return; }
            // 扣除下注金額（立即扣款），並啟動動畫
            balance -= bet;
            lastBet = bet;

            // 在動畫開始前決定最終索引（n1,n2,n3），動畫過程僅為視覺效果
            int count = Math.Max(1, this.imageList1.Images.Count);
            n1 = rng.Next(count);
            n2 = rng.Next(count);
            n3 = rng.Next(count);

            // 重置動畫旗標與 tick 計數
            spinTick = 0;
            pb1Stopped = pb2Stopped = pb3Stopped = false;
            prize = 0;

            // 更新 UI（旋轉按鈕會因動畫而停用），啟動計時器
            UpdateUI();
            if (spinTimer != null) spinTimer.Start();
        }

        private void spinTimer_Tick(object sender, EventArgs e)
        {
            // 每次 Tick 更新
            spinTick++;

            int count = Math.Max(1, this.imageList1.Images.Count);

            // 尚未停止的轉輪顯示隨機圖案（模擬滾動效果）
            if (!pb1Stopped)
            {
                int idx = rng.Next(count);
                this.pictureBox1.Image = (Image)this.imageList1.Images[idx];
            }
            if (!pb2Stopped)
            {
                int idx = rng.Next(count);
                this.pictureBox2.Image = (Image)this.imageList1.Images[idx];
            }
            if (!pb3Stopped)
            {
                int idx = rng.Next(count);
                this.pictureBox3.Image = (Image)this.imageList1.Images[idx];
            }

            // 在預定的 Tick 次數停止對應的轉輪並顯示最終圖片
            if (spinTick >= TICKS_STOP_PB1 && !pb1Stopped)
            {
                pb1Stopped = true;
                if (this.imageList1.Images.Count > 0) this.pictureBox1.Image = (Image)this.imageList1.Images[n1];
            }

            if (spinTick >= TICKS_STOP_PB2 && !pb2Stopped)
            {
                pb2Stopped = true;
                if (this.imageList1.Images.Count > 0) this.pictureBox2.Image = (Image)this.imageList1.Images[n2];
            }

            if (spinTick >= TICKS_STOP_PB3 && !pb3Stopped)
            {
                pb3Stopped = true;
                if (this.imageList1.Images.Count > 0) this.pictureBox3.Image = (Image)this.imageList1.Images[n3];

                // 動畫結束，停止計時器並計算勝負
                if (spinTimer != null) spinTimer.Stop();

                // 計算獎金並更新餘額與中獎次數
                prize = CheckWinner(lastBet);
                if (prize > 0)
                {
                    balance += prize;
                    winCount++;
                }

                // 更新統計資料
                totalSpins++;

                UpdateUI();
                UpdateStats();
                // 每次旋轉結束後儲存紀錄
                SaveGame();
            }
        }

        private void SaveGame()
        {
            try
            {
                var lines = new List<string>
                {
                    $"balance={balance}",
                    $"totalDeposited={totalDeposited}",
                    $"totalSpins={totalSpins}",
                    $"winCount={winCount}"
                };
                File.WriteAllLines(SAVE_FILE, lines);
            }
            catch
            {
                // ignore save errors
            }
        }

        private void LoadGame()
        {
            try
            {
                if (!File.Exists(SAVE_FILE)) return;
                var lines = File.ReadAllLines(SAVE_FILE);
                foreach (var line in lines)
                {
                    var parts = line.Split('=');
                    if (parts.Length != 2) continue;
                    var key = parts[0].Trim();
                    var val = parts[1].Trim();
                    int x;
                    if (!int.TryParse(val, out x)) continue;
                    switch (key)
                    {
                        case "balance": balance = x; break;
                        case "totalDeposited": totalDeposited = x; break;
                        case "totalSpins": totalSpins = x; break;
                        case "winCount": winCount = x; break;
                    }
                }
            }
            catch
            {
                // on error reset to zero
                balance = totalDeposited = totalSpins = winCount = 0;
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveGame();
        }
    }
}
