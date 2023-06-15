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
    public partial class inHDdichvu : Form
    {
        string makh;
        public inHDdichvu(string makh)
        {
            InitializeComponent();
            this.makh = makh;
        }

        private void inHDdichvu_Load(object sender, EventArgs e)
        {
            string sqlconnectstring = @"Data Source=DESKTOP-3N66U8D;Initial Catalog=qlykhachsan;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(sqlconnectstring))
            {
                string query = "execute loc_dhDichVu N'" + makh + "'";
                connection.Open();
                SqlDataAdapter adater = new SqlDataAdapter(query, connection);
                DataHDdichvu hd = new DataHDdichvu();
                adater.Fill(hd, "Hoa Don");

                HDdichvu hd1 = new HDdichvu();
                hd1.SetDataSource(hd.Tables[1]);
                crystalReportViewer1.ReportSource = hd1;
            }

        }
    }
}
