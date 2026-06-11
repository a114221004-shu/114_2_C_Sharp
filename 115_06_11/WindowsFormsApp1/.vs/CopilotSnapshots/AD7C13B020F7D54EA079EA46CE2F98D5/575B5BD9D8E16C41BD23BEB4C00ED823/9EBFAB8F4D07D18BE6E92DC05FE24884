using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        // 使用 struct 記錄每一筆摩斯密碼資料
        public struct MorseMapping
        {
            public char Character;   // 記錄字元
            public string MorseCode; // 記錄摩斯密碼
        }

        // 使用 List 儲存完整摩斯密碼表，不使用 Dictionary
        private List<MorseMapping> morseCodeTable = new List<MorseMapping>();

        private const string TableFileName = "morse_code_table.md";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadMorseCodeTable();
        }

        private void LoadMorseCodeTable()
        {
            if (!File.Exists(TableFileName))
            {
                MessageBox.Show($"找不到摩斯密碼表檔案：{TableFileName}\n請確認檔案是否已放置於程式執行目錄中。", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using (StreamReader inputFile = File.OpenText(TableFileName))
                {
                    while (!inputFile.EndOfStream)
                    {
                        string line = inputFile.ReadLine();

                        if (string.IsNullOrWhiteSpace(line) || line.StartsWith("#") || line.Contains(":---"))
                            continue;

                        string[] parts = line.Split('|');
                        for (int i = 1; i < parts.Length - 1; i += 2)
                        {
                            if (i + 1 >= parts.Length) break;

                            string rawCharStr = parts[i].Trim();
                            string rawCodeStr = parts[i + 1].Trim().Replace("`", "");

                            if (string.IsNullOrEmpty(rawCharStr) || string.IsNullOrEmpty(rawCodeStr) ||
                                rawCharStr == "Character" || rawCharStr == "Code")
                                continue;

                            char targetChar;
                            if (rawCharStr.Equals("space", StringComparison.OrdinalIgnoreCase)) targetChar = ' ';
                            else if (rawCharStr.Equals("comma", StringComparison.OrdinalIgnoreCase)) targetChar = ',';
                            else if (rawCharStr.Equals("period", StringComparison.OrdinalIgnoreCase)) targetChar = '.';
                            else targetChar = rawCharStr.ToUpper()[0];

                            MorseMapping mapping = new MorseMapping
                            {
                                Character = targetChar,
                                MorseCode = rawCodeStr
                            };
                            morseCodeTable.Add(mapping);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"讀取檔案時發生錯誤：{ex.Message}", "系統錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            listBox1.Items.Clear();

            string inputText = textBox1.Text;
            if (string.IsNullOrEmpty(inputText)) return;

            List<string> totalMorseList = new List<string>();

            foreach (char rawChar in inputText)
            {
                char searchChar = char.ToUpper(rawChar);

                string foundMorse = null;
                foreach (var item in morseCodeTable)
                {
                    if (item.Character == searchChar)
                    {
                        foundMorse = item.MorseCode;
                        break;
                    }
                }

                if (foundMorse != null)
                {
                    totalMorseList.Add(foundMorse);
                    string displayChar = (searchChar == ' ') ? "空白" : searchChar.ToString();
                    listBox1.Items.Add($"{displayChar}\t{foundMorse}");
                }
            }

            textBox2.Text = string.Join(" ", totalMorseList);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            listBox1.Items.Clear();
            textBox1.Focus();
        }
    }
}
