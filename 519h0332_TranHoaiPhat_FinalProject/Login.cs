using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _519h0332_TranHoaiPhat_FinalProject
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data Source  = LAPTOP-BATC8T2F\SQLEXPRESS; Initial Catalog=FinalC_DB; Integrated Security = True";
            conn.Open();
            String sql = "select UserID,Password from Users where UserID = '" + textBox1.Text + "'and Password = '" + textBox2.Text + "'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Login Successful");
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid Login");
            }
            conn.Close();
        }
    }
}
