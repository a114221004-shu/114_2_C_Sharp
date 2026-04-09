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

namespace Test_Average
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Average 方法接受一個 int 陣列作為參數
        // 並回傳陣列中值的平均。使用 LINQ 查詢語法（不使用 lambda）。
        private double Average(int[] sArray, int index)
        {
            // 使用查詢語法建立一個整數序列，然後呼叫 Average() 計算平均
            var query = from s in sArray
                        select s;

            return query.Average();
        }

        // Highest 方法接受一個 int 陣列作為參數
        // 並回傳該陣列中的最大值。使用 LINQ 查詢語法（不使用 lambda）。
        private  int Highest(int[] sArray, int index)
        {
            // 以查詢語法將數值依照降冪排序，回傳第一個元素即為最大值
            var query = from s in sArray
                        orderby s descending
                        select s;

            return query.First();
        }

        // Lowest 方法接受一個 int 陣列作為參數
        // 並回傳該陣列中的最小值。使用 LINQ 查詢語法（不使用 lambda）。
        private int Lowest(int[] sArray, int index)
        {
            // 以查詢語法將數值依照升冪排序，回傳第一個元素即為最小值
            var query = from s in sArray
                        orderby s ascending
                        select s;

            return query.First();
        }

        private int getFileScoreCount()
        {
            int count = 0;
            StreamReader inputFile;
            try
            {
                inputFile = File.OpenText("TestScores.txt");
                while (!inputFile.EndOfStream)
                {
                    inputFile.ReadLine();
                    count++;
                }
                inputFile.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return count;
        }

        private void getScoresButton_Click(object sender, EventArgs e)
        {
            // 使用 LINQ 查詢語法讀取並解析檔案內容為整數序列（不使用 lambda）
            int[] scores = null;
            try
            {
                var linesQuery = from line in File.ReadAllLines("TestScores.txt")
                                 select int.Parse(line);

                scores = linesQuery.ToArray();

                testScoresListBox.Items.Add("學生人數：" + scores.Length + "人");
                foreach (int val in scores)
                {
                    testScoresListBox.Items.Add(val);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            // 使用已建立的 scores 陣列，並將長度傳入（方法簽章保留 index 參數）
            int index = (scores != null) ? scores.Length : 0;
            averageScoreLabel.Text = Average(scores, index).ToString("n1");
            highScoreLabel.Text = Highest(scores, index).ToString();
            lowScoreLabel.Text = Lowest(scores, index).ToString();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉表單。
            this.Close();
        }

        private void testScoresListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
