using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ADO_Tech_week_1_
{
    public partial class frmUpdate : Form
    {
        public frmUpdate()
        {
            InitializeComponent();
            btnOK.Click += new EventHandler(OK);
            btnHuy.Click += new EventHandler(Huy);
        }

        private void Huy(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OK(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source = Le Quang Hung; Initial Catalog = QLHV; User ID = sa; Password = 123456");
            conn.Open();
            string oldname = txtOldUserName.Text;
            string newname = txtNewUserName.Text;
            string sql = "UPDATE Nguoidung SET Tendangnhap ='" + newname + "' WHERE Tendangnhap = '" + oldname + "'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Updated");
            conn.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {

        }
    }
}
