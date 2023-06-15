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
    public partial class ThemDVchoKH : Form
    {
        public ThemDVchoKH()
        {
            InitializeComponent();
        }
        public string constr = @"Data Source=LAPTOP-LN11OT07\SQLEXPRESS;Initial Catalog=HSK;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        private void ThemDVchoKH_Load(object sender, EventArgs e)
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                //tblphong
                using (SqlCommand cmd = new SqlCommand("select * from tblHoaDon_DichVu", cnn))
                {
                    cmd.CommandType = CommandType.Text;
                    cnn.Open();
                    using (SqlDataAdapter adp = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adp.Fill(dt);
                        tblHD_DV.DataSource = dt;
                    }
                }

               
                    using (SqlCommand cmd = new SqlCommand("select MaHD from tblHoaDon", cnn))
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);
                            comboBoxMaHD.ValueMember = "MaHD";
                            comboBoxMaHD.DataSource = dt;
                        }

                    }

                using (SqlCommand cmd = new SqlCommand("select MaDV from tblDichVu", cnn))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        comboBoxMaDV.ValueMember = "MaDV";
                        comboBoxMaDV.DataSource = dt;
                    }

                }

            }
        }

        private void btnThemDVKH_Click(object sender, EventArgs e)
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                cnn.Open();
                using (SqlCommand cmd = cnn.CreateCommand())
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "themDVchoKH";
                    cmd.Parameters.AddWithValue("@MaHD_DV", MaHD_DV.Text);
                    cmd.Parameters.AddWithValue("@MaHD", (comboBoxMaHD.Text).ToString());
                    cmd.Parameters.AddWithValue("@MaDV", (comboBoxMaDV.Text).ToString());
                    cmd.Parameters.AddWithValue("@soLuongDV", int.Parse(soLuongDV.Text));

                    
                    int i = cmd.ExecuteNonQuery();

                    using (SqlDataAdapter adp = new SqlDataAdapter())
                    {
                        adp.TableMappings.Add("Tables", "tblHoaDon_DichVu");
                        adp.SelectCommand = new SqlCommand("select * from tblHoaDon_DichVu", cnn);
                        DataSet dts = new DataSet();
                        adp.Fill(dts, "tblHoaDon_DichVu");
                        DataTable table = dts.Tables["tblHoaDon_DichVu"];
                        tblHD_DV.DataSource = table;
                    }
                }
                cnn.Close();
            }
        }
    }
}
