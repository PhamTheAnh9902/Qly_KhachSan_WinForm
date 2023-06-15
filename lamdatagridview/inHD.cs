using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lamdatagridview
{
    public partial class inHD : Form
    {
        string mahd;
        public inHD(string mahd)
        {
            InitializeComponent();
            this.mahd = mahd;
        }

        private void inHD_Load(object sender, EventArgs e)
        {
            string sqlconnectstring = @"Data Source=DESKTOP-3N66U8D;Initial Catalog=qlykhachsan;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(sqlconnectstring))
            {
                string query = "execute loc_hdPhong N'" + mahd + "'";
                connection.Open();
                SqlDataAdapter adater = new SqlDataAdapter(query, connection);
                DataHDphong hd = new DataHDphong();
                adater.Fill(hd, "Hoa Don");

                HDphong1 hd1 = new HDphong1();
                hd1.SetDataSource(hd.Tables[1]);
                crystalReportViewer1.ReportSource = hd1;
            }
        }
    }
}