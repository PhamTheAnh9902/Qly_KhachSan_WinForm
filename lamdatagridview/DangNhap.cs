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
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }
        public string constr = @"Data Source=DESKTOP-3N66U8D;Initial Catalog=qlykhachsan;Integrated Security=True";

        int dem;
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            try
            {
                conn.ConnectionString = constr;
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "LogIn_QLTP";
                cmd.Parameters.AddWithValue("@tendn", tendn.Text);
                cmd.Parameters.AddWithValue("@mk", mk.Text);
                cmd.Connection = conn;
                string TaiKhoan = tendn.Text;
                object kq = cmd.ExecuteScalar();
                int code = Convert.ToInt32(kq);
                if (code == 1)
                {
                    Main child = new Main(tendn.Text, mk.Text);

                    this.Hide();
                    child.ShowDialog();
                    this.Show();
                }
                else if (code == 2)
                {
                    MessageBox.Show("Tài khoản hoặc mật khẩu không đúng !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tendn.Text = "";
                    mk.Text = "";
                    tendn.Focus();
                    dem++;
                }
                else
                {
                    MessageBox.Show("Tài khoản không tồn tại !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tendn.Text = "";
                    mk.Text = "";
                    tendn.Focus();
                    dem++;
                }

                if (dem == 3)
                {
                    MessageBox.Show("Tài khoản bị khóa! vui lòng quay lại sau 5 phút");
                    btnDangNhap.Enabled = false;
                    
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DangKi dangki = new DangKi();
            this.Hide();
            dangki.Show();
        }
    }
}
