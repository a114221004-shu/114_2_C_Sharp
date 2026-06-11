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
    public partial class MainForm : Form
    {
        public List<Employee> Employees { get; private set; } = new List<Employee>();
        private string employeeFile;

        public MainForm()
        {
            InitializeComponent();
            // ensure employees file is located next to executable
            this.employeeFile = System.IO.Path.Combine(Application.StartupPath, "employees.txt");
            // wire up buttons
            this.btnAdd.Click += BtnAdd_Click;
            this.btnDelete.Click += BtnDelete_Click;
            this.btnEdit.Click += BtnEdit_Click;
            this.btnQuery.Click += BtnQuery_Click;
            this.FormClosing += MainForm_FormClosing;
            // load employees and display
            LoadEmployees();
            RefreshEmployeeListBox();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveEmployees();
        }

        private void LoadEmployees()
        {
            Employees.Clear();
            try
            {
                if (!System.IO.File.Exists(employeeFile)) return;
                var lines = System.IO.File.ReadAllLines(employeeFile, Encoding.GetEncoding(950));
                foreach (var line in lines)
                {
                    if (string.IsNullOrWhiteSpace(line)) continue;
                    var parts = line.Split('|');
                    if (parts.Length >= 4)
                    {
                        int id;
                        if (int.TryParse(parts[0], out id))
                        {
                            Employees.Add(new Employee(parts[1], id, parts[2], parts[3]));
                        }
                    }
                }
            }
            catch
            {
                // ignore load errors
            }
        }

        private void SaveEmployees()
        {
            try
            {
                var lines = new List<string>();
                foreach (var e in Employees)
                {
                    lines.Add($"{e.IdNumber}|{e.Name}|{e.Department}|{e.Position}");
                }
                System.IO.File.WriteAllLines(employeeFile, lines, Encoding.GetEncoding(950));
            }
            catch
            {
                // ignore save errors
            }
        }

        private void RefreshEmployeeListBox()
        {
            employeeListBox.Items.Clear();
            foreach (var e in Employees)
            {
                employeeListBox.Items.Add($"{e.IdNumber}\t{e.Name}");
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            using (var f = new 新增員工())
            {
                f.ShowDialog(this);
            }
            // after close, reload file (forms currently do not modify list)
            LoadEmployees();
            RefreshEmployeeListBox();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            using (var f = new 刪除員工())
            {
                f.ShowDialog(this);
            }
            LoadEmployees();
            RefreshEmployeeListBox();
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            using (var f = new 修改員工資料())
            {
                f.ShowDialog(this);
            }
            LoadEmployees();
            RefreshEmployeeListBox();
        }

        private void BtnQuery_Click(object sender, EventArgs e)
        {
            using (var f = new 查詢員工())
            {
                f.ShowDialog(this);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
