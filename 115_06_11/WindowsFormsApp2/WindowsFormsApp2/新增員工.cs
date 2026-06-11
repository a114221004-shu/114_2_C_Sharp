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
    public partial class 新增員工 : Form
    {
        public 新增員工()
        {
            InitializeComponent();
            this.btnAdd.Click += BtnAdd_Click;
            this.btnClose.Click += btnClose_Click;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            msgBox.Clear();
            string idText = txtId.Text.Trim();
            if (!int.TryParse(idText, out int id))
            {
                msgBox.Text = "請輸入有效的員工編號";
                return;
            }

            string name = txtName.Text.Trim();
            if (string.IsNullOrEmpty(name))
            {
                msgBox.Text = "請輸入姓名";
                return;
            }

            string dept = txtDept.Text.Trim();
            string job = txtJob.Text.Trim();

            string path = System.IO.Path.Combine(Application.StartupPath, "employees.txt");
            try
            {
                var lines = new List<string>();
                if (System.IO.File.Exists(path))
                {
                    lines.AddRange(System.IO.File.ReadAllLines(path, Encoding.GetEncoding(950)));
                }

                // check duplicate id
                foreach (var line in lines)
                {
                    if (string.IsNullOrWhiteSpace(line)) continue;
                    var parts = line.Split('|');
                    if (parts.Length < 1) continue;
                    if (int.TryParse(parts[0], out int existing) && existing == id)
                    {
                        msgBox.Text = "員工編號已存在，無法新增";
                        return;
                    }
                }

                lines.Add($"{id}|{name}|{dept}|{job}");
                System.IO.File.WriteAllLines(path, lines, Encoding.GetEncoding(950));

                msgBox.Text = "新增完成";
                txtId.Clear();
                txtName.Clear();
                txtDept.Clear();
                txtJob.Clear();
            }
            catch (Exception ex)
            {
                msgBox.Text = "發生錯誤：" + ex.Message;
            }
        }
    }
}
