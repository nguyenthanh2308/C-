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
    public partial class frmAdmin : Form
    {
        public frmAdmin()
        {
            InitializeComponent();
            btnAdd.Click += new EventHandler(Them);
            btnDelete.Click += new EventHandler(Xoa);
            btnUpdate.Click += new EventHandler(Sua);
            btnReload.Click += new EventHandler(LamMoi);
        }

        private void LamMoi(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Sua(object sender, EventArgs e)
        {
            frmUpdate frmUpdate = new frmUpdate();
            frmUpdate.Show();
        }

        private void Xoa(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source = Le Quang Hung; Initial Catalog = QLHV; User ID = sa; Password = 123456");
                    conn.Open();
            string name = txtUserName.Text;
            string sql = "DELETE from Nguoidung WHERE Tendangnhap='" +
           name + "'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Deleted");
            conn.Close();

        }
                private void Them(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source = Le Quang Hung; Initial Catalog = QLHV; User ID = Sa; Password = 123456");
            conn.Open();
            string name = txtUserName.Text;
            string pass = txtPassword.Text;
            string sql = "INSERT into Nguoidung values('" + name + "','" + pass + "')";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Added");
            conn.Close();
        }
    }
}
