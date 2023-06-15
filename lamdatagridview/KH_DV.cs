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
    public partial class KH_DV : Form
    {
        public KH_DV()
        {
            InitializeComponent();
        }
        public string constr = @"Data Source=DESKTOP-3N66U8D;Initial Catalog=qlykhachsan;Integrated Security=True";
        private void KH_DV_Load(object sender, EventArgs e)
        {
            string query = "select *from khachHang_coDV ";
            DataTable data = LoadData.Instance.ExcuteQuery(query);
            dataGridViewKH_DV.DataSource = data;

            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("select MaKH from khachHang_coDV ", cnn))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        comboBoxMaKH.ValueMember = "MaKH";
                        comboBoxMaKH.DataSource = dt;
                    }

                }
            }
        }

        private void btnXemDV_Click(object sender, EventArgs e)
        {
            string query = "execute khachHangcoDV N'" + (comboBoxMaKH.Text).ToString() + "'";
            DataTable data = LoadData.Instance.ExcuteQuery(query);
            dataGridViewKH_DV.DataSource = data;
        }

        private void btnTatca_Click(object sender, EventArgs e)
        {
            string query = "select *from khachHang_coDV ";
            DataTable data = LoadData.Instance.ExcuteQuery(query);
            dataGridViewKH_DV.DataSource = data;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            comboBoxMaKH.Text = "";
        }

    }
}
