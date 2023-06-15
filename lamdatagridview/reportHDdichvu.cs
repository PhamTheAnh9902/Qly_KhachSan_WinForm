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
    public partial class reportHDdichvu : Form
    {
        public reportHDdichvu()
        {
            InitializeComponent();
        }
        public string constr = @"Data Source=DESKTOP-3N66U8D;Initial Catalog=qlykhachsan;Integrated Security=True";
        
        private void reportHDdichvu_Load(object sender, EventArgs e)
        {
            string query = "select *from TatCaHDdichvu";
            DataTable data = LoadData.Instance.ExcuteQuery(query);
            dataGridView1.DataSource = data;

            using (SqlConnection cnn = new SqlConnection(constr))
            {
                cnn.Open();
                using (SqlCommand cmd = new SqlCommand("select MaKH from tblKhachHang", cnn))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        comboBox1.ValueMember = "MaKH";
                        comboBox1.DataSource = dt;
                    }

                }

            }

            /*using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("select MaPhong from tblPhong", cnn))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        cbMaPhong.ValueMember = "MaPhong";
                        cbMaPhong.DataSource = dt;
                    }

                }
            }*/


        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            string query = "execute loc_dhDichVu N'" + (comboBox1.Text).ToString() + "'";
            DataTable data = LoadData.Instance.ExcuteQuery(query);
            dataGridView1.DataSource = data;
        }

        private void btnTatCa_Click(object sender, EventArgs e)
        {
            string query = "select *from TatCaHDdichvu";
            DataTable data = LoadData.Instance.ExcuteQuery(query);
            dataGridView1.DataSource = data;
        }

        private void btnInrepoort_Click(object sender, EventArgs e)
        {
            inHDdichvu inhd = new inHDdichvu(comboBox1.Text);
            inhd.Show();
        }

        private void btnLocPhong_Click(object sender, EventArgs e)
        {

        }
    }
}
