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

namespace lamdatagridview
{
    public partial class DangKi : Form
    {
        public DangKi()
        {
            InitializeComponent();
        }
        public string constr = @"Data Source=DESKTOP-3N66U8D;Initial Catalog=qlykhachsan;Integrated Security=True";
        private void DangKi_Load(object sender, EventArgs e)
        {

        }

        private void btnDK_Click(object sender, EventArgs e)
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                cnn.Open();
               
                using (SqlCommand cmd = cnn.CreateCommand())
                {
                    cmd.CommandText = "insert into tblLogin(tendn,mk) values (N'"+tendn.Text+"',N'"+mk.Text+"')";
                     int i=cmd.ExecuteNonQuery();

                    if (i > 0)
                    {
                        MessageBox.Show("dang ki thanh cong");
                        
                    }
                    else
                    {
                        MessageBox.Show("dang ki that bai");
                    }
                }
                cnn.Close();
            }
        }

        private void btndn_Click(object sender, EventArgs e)
        {
            DangNhap dn = new DangNhap();
            this.Hide();
            dn.Show();
        }
    }
}
