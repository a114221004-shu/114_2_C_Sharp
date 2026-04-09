using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Linq.Expressions;

namespace Test_Score_List
{
    public partial class Form1 : Form
    {
        // 儲存讀取到的分數清單，供多個事件處理器使用
        private List<int> scoresList = new List<int>();

        public Form1()
        {
            InitializeComponent();
            // 在建構子綁定搜尋按鈕的事件處理器（設計檔可能未綁定）
            this.searchButton.Click += new EventHandler(this.searchButton_Click);
        }



        // 讀取分數清單的方法，將檔案中的每一行轉為 int 並加入傳入的 List
        private void ReadScores(List<int> scoresList)
        {
            string filePath = "TestScores.txt"; // 要讀取的檔案名稱
            try
            {
                using (StreamReader reader = File.OpenText(filePath))
                {
                    string line; // 暫存每一行的字串
                    // 從檔案逐行讀取分數，直到檔案結束
                    while (!reader.EndOfStream)
                    {
                        // 將讀取到的字串轉為 int，並加入清單
                        scoresList.Add(int.Parse(reader.ReadLine()));
                    }
                }

            }
            catch (Exception ex)
            {
                // 若讀檔發生錯誤，顯示錯誤訊息（繁體中文）
                MessageBox.Show("讀取檔案發生錯誤：" + ex.Message);
            }
        }

        // 顯示分數清單到 ListBox（顯示用，若無資料則顯示提示）
        private void DisplayScores(List<int> scoresList)
        {
            testScoresListBox.Items.Clear();
            if (scoresList == null || scoresList.Count == 0)
            {
                // 若無分數則顯示提示文字
                testScoresListBox.Items.Add("無分數資料");
                return;
            }

            // 將每一個分數加入 ListBox，顯示為 "編號: 分數"（編號從 1 開始）
            for (int i = 0; i < scoresList.Count; i++)
            {
                testScoresListBox.Items.Add($"{i + 1}: {scoresList[i]}");
            }
        }

        // 計算傳入清單的平均值，若無資料則回傳 0
        private double Average(List<int> scoresList)
        {
            if (scoresList == null || scoresList.Count == 0)
                return 0.0;

            // 使用 LINQ 計算平均
            return scoresList.Average();
        }

        // 計算高於傳入平均值的分數數量
        private int AboveAverage(List<int> scoresList, double averageScore)
        {
            if (scoresList == null || scoresList.Count == 0)
                return 0;

            int count = 0;
            foreach (int score in scoresList)
            {
                if (score > averageScore)
                    count++;
            }
            return count;
        }

        // 計算低於平均分數的數量（會重新計算平均）
        private int BelowAverage(List<int> scoresList)
        {
            if (scoresList == null || scoresList.Count == 0)
                return 0;

            double avg = Average(scoresList);
            int count = 0;
            foreach (int score in scoresList)
            {
                if (score < avg)
                    count++;
            }
            return count;
        }

        // 點選「取得成績」按鈕時觸發，負責讀取、計算與顯示成績相關資訊
        private void getScoresButton_Click(object sender, EventArgs e)
        {
            double averageScore;    // 用來儲存平均分數
            int numAboveAverage;    // 高於平均的分數數量
            int numBelowAverage;    // 低於平均的分數數量

            // 清空現有的分數清單，準備重新讀取
            scoresList.Clear();

            // 讀取檔案中的分數到 List（讀取結果會放入 scoresList 欄位）
            ReadScores(scoresList);

            // 顯示分數清單
            DisplayScores(scoresList);

            // 計算並顯示平均分數
            averageScore = Average(scoresList);
            averageLabel.Text = averageScore.ToString("n1");

            // 計算並顯示高於平均的分數數量
            numAboveAverage = AboveAverage(scoresList, averageScore);
            aboveAverageLabel.Text = numAboveAverage.ToString();

            // 計算並顯示低於平均的分數數量
            numBelowAverage = BelowAverage(scoresList);
            belowAverageLabel.Text = numBelowAverage.ToString();
        }

        // 點選「離開」按鈕時關閉表單
        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉視窗
            this.Close();
        }

        // 搜尋按鈕的事件處理器：搜尋使用者輸入的分數，若找到則顯示所在位置（從 1 開始），否則顯示「分數不存在」
        private void searchButton_Click(object sender, EventArgs e)
        {
            int searchScore; // 用來儲存使用者輸入的分數

            if (!int.TryParse(searchTextBox.Text, out searchScore))
            {
                searchResultLabel.Text = "請輸入有效的整數分數";
                return;
            }

            if (scoresList == null || scoresList.Count == 0)
            {
                // 尚未讀取或無資料，視為不存在
                searchResultLabel.Text = "分數不存在";
                return;
            }

            int position = scoresList.IndexOf(searchScore);
            if (position == -1)
            {
                searchResultLabel.Text = "分數不存在";
            }
            else
            {
                // 顯示使用者可理解的 1 基底位置
                searchResultLabel.Text = $"分數 {searchScore} 位於清單中的位置：{position + 1}";
            }
        }
    }
}
