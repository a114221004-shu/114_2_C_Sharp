using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MutiFormVarlable
{
    public partial class MainForm : Form
    {
        public string userName = "Yang";
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Secondform secondform = new Secondform(this);
            secondform.Show();
        }
    }
}
