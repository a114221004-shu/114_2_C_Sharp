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
    public partial class 刪除員工 : Form
    {
        public 刪除員工()
        {
            InitializeComponent();
            this.btnDelete.Click += BtnDelete_Click;
            this.btnClose.Click += BtnClose_Click;
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
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
                var lines = new List<string>(System.IO.File.ReadAllLines(path, Encoding.GetEncoding(950)));
                int originalCount = lines.Count;
                lines.RemoveAll(l =>
                {
                    if (string.IsNullOrWhiteSpace(l)) return false;
                    var parts = l.Split('|');
                    if (parts.Length < 1) return false;
                    if (int.TryParse(parts[0], out int x) && x == id) return true;
                    return false;
                });

                if (lines.Count == originalCount)
                {
                    msgBox.Text = "未找到指定員工編號";
                    return;
                }

                System.IO.File.WriteAllLines(path, lines, Encoding.GetEncoding(950));
                msgBox.Text = "刪除完成";
                txtId.Clear();
            }
            catch (Exception ex)
            {
                msgBox.Text = "發生錯誤：" + ex.Message;
            }
        }
    }
}
