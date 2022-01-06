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
    public partial class InputSheet : Form
    {
        public InputSheet()
        {
            InitializeComponent();
        }

        private void InputSheet_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'finalC_DBDataSet.NHAPKHO' table. You can move, or remove it, as needed.
            this.nHAPKHOTableAdapter.Fill(this.finalC_DBDataSet.NHAPKHO);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.nHAPKHOBindingSource.EndEdit();
            this.nHAPKHOTableAdapter.Update(finalC_DBDataSet);
            MessageBox.Show("Save Successful!");
        }
    }
}
