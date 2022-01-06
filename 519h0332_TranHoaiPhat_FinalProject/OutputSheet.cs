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
    public partial class OutputSheet : Form
    {
        public OutputSheet()
        {
            InitializeComponent();
        }

        private void OutputSheet_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'finalC_DBDataSet1.XUATKHO' table. You can move, or remove it, as needed.
            this.xUATKHOTableAdapter.Fill(this.finalC_DBDataSet1.XUATKHO);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.xUATKHOBindingSource.EndEdit();
            this.xUATKHOTableAdapter.Update(finalC_DBDataSet1);
            MessageBox.Show("Save Successful!");
        }
    }
}
