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
    public partial class InputSheetMonth : Form
    {
        public InputSheetMonth()
        {
            InitializeComponent();
        }

        private void InputSheetMonth_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'finalC_DBDataSet2.TK_HANGVAO' table. You can move, or remove it, as needed.
            this.tK_HANGVAOTableAdapter.Fill(this.finalC_DBDataSet2.TK_HANGVAO);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tKHANGVAOBindingSource.EndEdit();
            this.tK_HANGVAOTableAdapter.Update(finalC_DBDataSet2);
            MessageBox.Show("Save Successful!");
        }
    }
}
