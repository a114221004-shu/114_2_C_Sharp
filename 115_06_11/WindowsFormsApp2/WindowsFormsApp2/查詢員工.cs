using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class 查詢員工 : Form
    {
        public 查詢員工()
        {
            InitializeComponent();
            this.btnQuery.Click += BtnQuery_Click;
            this.btnClose.Click += BtnClose_Click;
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnQuery_Click(object sender, EventArgs e)
        {
            msgBox.Clear();
            string idText = txtId.Text.Trim();
            if (!int.TryParse(idText, out int id))
            {
                msgBox.Text = "請輸入有效的員工編號";
                return;
            }

            string path = System.IO.Path.Combine(Application.StartupPath, "employees.txt");
            if (!System.IO.File.Exists(path))
            {
                msgBox.Text = "找不到 employees.txt";
                return;
            }

            try
            {
                var lines = System.IO.File.ReadAllLines(path, Encoding.GetEncoding(950));
                foreach (var line in lines)
                {
                    if (string.IsNullOrWhiteSpace(line)) continue;
                    var parts = line.Split('|');
                    if (parts.Length < 4) continue;
                    if (int.TryParse(parts[0], out int x) && x == id)
                    {
                        // Found
                        var sb = new StringBuilder();
                        sb.AppendLine($"員工編號：{parts[0]}");
                        sb.AppendLine($"姓名：{parts[1]}");
                        sb.AppendLine($"部門：{parts[2]}");
                        sb.AppendLine($"職稱：{parts[3]}");
                        msgBox.Text = sb.ToString();
                        return;
                    }
                }

                msgBox.Text = "未找到指定員工編號";
            }
            catch (Exception ex)
            {
                msgBox.Text = "發生錯誤：" + ex.Message;
            }
        }
    }
}
