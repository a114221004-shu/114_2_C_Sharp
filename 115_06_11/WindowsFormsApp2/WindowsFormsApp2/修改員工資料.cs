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
    public partial class 修改員工資料 : Form
    {
        public 修改員工資料()
        {
            InitializeComponent();
            this.btnQuery.Click += BtnQuery_Click;
            this.btnSave.Click += BtnSave_Click;
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
                        txtName.Text = parts[1];
                        txtDept.Text = parts[2];
                        txtJob.Text = parts[3];
                        msgBox.Text = "找到員工，已填入欄位，可修改後按儲存";
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

        private void BtnSave_Click(object sender, EventArgs e)
        {
            msgBox.Clear();
            string idText = txtId.Text.Trim();
            if (!int.TryParse(idText, out int id))
            {
                msgBox.Text = "請輸入有效的員工編號";
                return;
            }

            string name = txtName.Text.Trim();
            string dept = txtDept.Text.Trim();
            string job = txtJob.Text.Trim();

            string path = System.IO.Path.Combine(Application.StartupPath, "employees.txt");
            if (!System.IO.File.Exists(path))
            {
                msgBox.Text = "找不到 employees.txt";
                return;
            }

            try
            {
                var lines = new List<string>(System.IO.File.ReadAllLines(path, Encoding.GetEncoding(950)));
                bool found = false;
                for (int i = 0; i < lines.Count; i++)
                {
                    var line = lines[i];
                    if (string.IsNullOrWhiteSpace(line)) continue;
                    var parts = line.Split('|');
                    if (parts.Length < 4) continue;
                    if (int.TryParse(parts[0], out int x) && x == id)
                    {
                        lines[i] = $"{id}|{name}|{dept}|{job}";
                        found = true;
                        break;
                    }
                }

                if (!found)
                {
                    msgBox.Text = "未找到指定員工編號，無法儲存";
                    return;
                }

                System.IO.File.WriteAllLines(path, lines, Encoding.GetEncoding(950));
                msgBox.Text = "儲存完成";
            }
            catch (Exception ex)
            {
                msgBox.Text = "發生錯誤：" + ex.Message;
            }
        }
    }
}
