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
    public partial class Status : Form
    {
        public Status()
        {
            InitializeComponent();
        }

        private void Status_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'finalC_DBDataSet6.TINHTRANG' table. You can move, or remove it, as needed.
            this.tINHTRANGTableAdapter.Fill(this.finalC_DBDataSet6.TINHTRANG);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tINHTRANGBindingSource.EndEdit();
            this.tINHTRANGTableAdapter.Update(finalC_DBDataSet6);
            MessageBox.Show("Save Successful!");
        }
    }
}
