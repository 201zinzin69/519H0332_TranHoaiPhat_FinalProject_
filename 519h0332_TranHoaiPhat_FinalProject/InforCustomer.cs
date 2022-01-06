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
    public partial class InforCustomer : Form
    {
        public InforCustomer()
        {
            InitializeComponent();
        }

        private void InforCustomer_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'finalC_DBDataSet4.DATHANG' table. You can move, or remove it, as needed.
            this.dATHANGTableAdapter.Fill(this.finalC_DBDataSet4.DATHANG);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.dATHANGBindingSource.EndEdit();
            this.dATHANGTableAdapter.Update(finalC_DBDataSet4);
            MessageBox.Show("Save Successful!");
        }
    }
}
