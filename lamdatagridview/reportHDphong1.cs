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
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;


namespace lamdatagridview
{
    public partial class reportHDphong1 : Form
    {
        public reportHDphong1()
        {
            InitializeComponent();
        }

        public string constr= @"Data Source=DESKTOP-3N66U8D;Initial Catalog=qlykhachsan;Integrated Security=True";
       

        private void btn_loc_Click(object sender, EventArgs e)
        {
       
         string query= "execute loc_hdPhong N'"+(comboxMaKH.Text).ToString()+"'";
            DataTable data = LoadData.Instance.ExcuteQuery(query);
            dataGridView1.DataSource = data;

        }

        private void reportHDphong1_Load(object sender, EventArgs e)
        {   
            string query = "select *from TatCaHD";
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
                        comboxMaKH.ValueMember = "MaKH";
                        comboxMaKH.DataSource = dt;
                    }

                }
            }
        }

        private void btn_in_Click(object sender, EventArgs e)
        {
            inHD inhd = new inHD(comboxMaKH.Text);
            inhd.Show();
        }
    }
}
