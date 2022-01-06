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
    public partial class OutputSheetMonth : Form
    {
        public OutputSheetMonth()
        {
            InitializeComponent();
        }

        private void OutputSheetMonth_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'finalC_DBDataSet3.TK_HANGRA' table. You can move, or remove it, as needed.
            this.tK_HANGRATableAdapter.Fill(this.finalC_DBDataSet3.TK_HANGRA);

        }

        private void Save_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tKHANGRABindingSource.EndEdit();
            this.tK_HANGRATableAdapter.Update(finalC_DBDataSet3);
            MessageBox.Show("Save Successful!");
        }
    }
}
