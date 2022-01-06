using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _519h0332_TranHoaiPhat_FinalProject
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            Login loginform = new Login();
            loginform.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            InputSheet inputsheet = new InputSheet();
            inputsheet.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OutputSheet outputsheet = new OutputSheet();
            outputsheet.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            InputSheetMonth inputsheetmonth = new InputSheetMonth();
            inputsheetmonth.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OutputSheetMonth outputsheetmonth = new OutputSheetMonth();
            outputsheetmonth.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            InforCustomer inforcus = new InforCustomer();
            inforcus.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Status status = new Status();
            status.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
