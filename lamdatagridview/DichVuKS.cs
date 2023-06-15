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
    public partial class DichVuKS : Form
    {
        public DichVuKS()
        {
            InitializeComponent();
        }

        public string constr = @"Data Source=DESKTOP-3N66U8D;Initial Catalog=qlykhachsan;Integrated Security=True";
        private void DichVuKS_Load(object sender, EventArgs e)
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                //tblphong
                using (SqlCommand cmd = new SqlCommand("select * from tblPhong", cnn))
                {
                    cmd.CommandType = CommandType.Text;
                    cnn.Open();
                    using (SqlDataAdapter adp = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adp.Fill(dt);
                        tblPhong.DataSource = dt;
                    }
                }

                //tbldv
                using (SqlCommand cmd = new SqlCommand("select * from tblDichVu", cnn))
                {
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataAdapter adp = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adp.Fill(dt);
                        tblDichvu.DataSource = dt;
                    }
                }
                //----//
            }
        }

        private void btnThemP_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection cnn = new SqlConnection(constr))
                {
                    cnn.Open();
                    using (SqlCommand cmd = cnn.CreateCommand())
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandText = "themPhong";
                        cmd.Parameters.AddWithValue("@MaPhong", MaPhong.Text);
                        cmd.Parameters.AddWithValue("@loaiPhong", loaiPhong.Text);
                        cmd.Parameters.AddWithValue("@giaPhong", float.Parse(giaPhong.Text));


                        int i = cmd.ExecuteNonQuery();

                        using (SqlDataAdapter adp = new SqlDataAdapter())
                        {
                            adp.TableMappings.Add("Tables", "tblPhong");
                            adp.SelectCommand = new SqlCommand("select * from tblPhong", cnn);
                            DataSet dts = new DataSet();
                            adp.Fill(dts, "tblPhong");
                            DataTable table = dts.Tables["tblPhong"];
                            tblPhong.DataSource = table;
                        }
                    }
                    cnn.Close();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Đã tồn tại phòng");
            }
        }


        private void CellClick(object sender, DataGridViewCellEventArgs e)
        {
            MaPhong.Text = tblPhong.CurrentRow.Cells["MaPhong"].Value.ToString();
            loaiPhong.Text = tblPhong.CurrentRow.Cells["loaiPhong"].Value.ToString();
            giaPhong.Text = tblPhong.CurrentRow.Cells["giaPhong"].Value.ToString();
        }


        private void btnXoaP_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection cnn = new SqlConnection(constr))
                {
                    cnn.Open();
                    using (SqlCommand cmd = cnn.CreateCommand())
                    {
                        //cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandText = "DELETE FROM tblPhong WHERE MaPhong = '" + MaPhong.Text + "'";
                        //cmd.Parameters.AddWithValue("@MaPhong", MaPhong.Text);
                        cmd.ExecuteNonQuery();
                        int i = cmd.ExecuteNonQuery();

                        using (SqlDataAdapter adp = new SqlDataAdapter())
                        {
                            adp.TableMappings.Add("Tables", "tblPhong");
                            adp.SelectCommand = new SqlCommand("select * from tblPhong", cnn);
                            DataSet dts = new DataSet();
                            adp.Fill(dts, "tblPhong");
                            DataTable table = dts.Tables["tblPhong"];
                            tblPhong.DataSource = table;
                        }
                    }
                    cnn.Close();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Phòng đang được sử dụng");
            }
        }

        private void btnSuaP_Click(object sender, EventArgs e)
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                cnn.Open();
                using (SqlCommand cmd = cnn.CreateCommand())
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "suaPhong";
                    cmd.Parameters.AddWithValue("@MaPhong", MaPhong.Text);
                    cmd.Parameters.AddWithValue("@loaiPhong", loaiPhong.Text);
                    cmd.Parameters.AddWithValue("@giaPhong", float.Parse(giaPhong.Text));
                   

                    cmd.ExecuteNonQuery();
                }

                using (SqlDataAdapter adp = new SqlDataAdapter())
                {
                    adp.TableMappings.Add("Tables", "tblPhong");
                    adp.SelectCommand = new SqlCommand("select * from tblPhong", cnn);
                    DataSet dts = new DataSet();
                    adp.Fill(dts, "tblPhong");
                    DataTable table = dts.Tables["tblPhong"];
                    tblPhong.DataSource = table;
                }
                cnn.Close();
            }
        }

        //dịch vụ khác
        private void btnThemDV_Click(object sender, EventArgs e)
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                cnn.Open();
                using (SqlCommand cmd = cnn.CreateCommand())
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "themDV";
                    cmd.Parameters.AddWithValue("@MaDV", MaDV.Text);
                    cmd.Parameters.AddWithValue("@tenDichVu", tenDV.Text);
                    cmd.Parameters.AddWithValue("@giaDichVu", float.Parse(giaDV.Text));


                    int i = cmd.ExecuteNonQuery();

                    using (SqlDataAdapter adp = new SqlDataAdapter())
                    {
                        adp.TableMappings.Add("Tables", "tblDichVu");
                        adp.SelectCommand = new SqlCommand("select * from tblDichVu", cnn);
                        DataSet dts = new DataSet();
                        adp.Fill(dts, "tblDichVu");
                        DataTable table = dts.Tables["tblDichVu"];
                        tblDichvu.DataSource = table;
                    }
                }
                cnn.Close();
            }
        }

        private void CellClickDV(object sender, DataGridViewCellEventArgs e)
        {
            MaDV.Text = tblDichvu.CurrentRow.Cells["MaDV"].Value.ToString();
            tenDV.Text = tblDichvu.CurrentRow.Cells["tenDichVu"].Value.ToString();
            giaDV.Text = tblDichvu.CurrentRow.Cells["giaDichVu"].Value.ToString();
        }

        private void btnSuaDV_Click(object sender, EventArgs e)
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                cnn.Open();
                using (SqlCommand cmd = cnn.CreateCommand())
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "suaDV";
                    cmd.Parameters.AddWithValue("@MaDV", MaDV.Text);
                    cmd.Parameters.AddWithValue("@tenDichVu", tenDV.Text);
                    cmd.Parameters.AddWithValue("@giaDichVu", float.Parse(giaDV.Text));


                    cmd.ExecuteNonQuery();
                }

                using (SqlDataAdapter adp = new SqlDataAdapter())
                {
                    adp.TableMappings.Add("Tables", "tblDichVu");
                    adp.SelectCommand = new SqlCommand("select * from tblDichVu", cnn);
                    DataSet dts = new DataSet();
                    adp.Fill(dts, "tblDichVu");
                    DataTable table = dts.Tables["tblDichVu"];
                    tblDichvu.DataSource = table;
                }
                cnn.Close();
            }
        }

        private void btnXoaDV_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection cnn = new SqlConnection(constr))
                {
                    cnn.Open();
                    using (SqlCommand cmd = cnn.CreateCommand())
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandText = "xoaDV";
                        cmd.Parameters.AddWithValue("@MaDV", MaDV.Text);
                        int i = cmd.ExecuteNonQuery();

                        using (SqlDataAdapter adp = new SqlDataAdapter())
                        {
                            adp.TableMappings.Add("Tables", "tblDichVu");
                            adp.SelectCommand = new SqlCommand("select * from tblDichVu", cnn);
                            DataSet dts = new DataSet();
                            adp.Fill(dts, "tblDichVu");
                            DataTable table = dts.Tables["tblDichVu"];
                            tblDichvu.DataSource = table;
                        }
                    }
                    cnn.Close();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Đang có người sử dụng dịch vụ này");
            }
        }


    }
}

