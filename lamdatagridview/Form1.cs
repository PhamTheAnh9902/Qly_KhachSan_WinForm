using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Windows.Forms;

namespace lamdatagridview
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private string tendn;
        private string mk;
        public Form1(string _tendn, string _mk) : this()
        {
            tendn = _tendn;
            mk = _mk;
        }

        public string constr = @"Data Source=DESKTOP-3N66U8D;Initial Catalog=qlykhachsan;Integrated Security=True";
        private void Form1_Load(object sender, EventArgs e)
        {

            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("select * from tblNhanVien", cnn))
                {
                    cmd.CommandType = CommandType.Text;
                    cnn.Open();
                    using (SqlDataAdapter adp = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adp.Fill(dt);
                        dataGridView1.DataSource = dt;
                    }
                }
            }

            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("select YEAR(GETDATE())- YEAR(ngaySinh) as N'Tuổi' from tblNhanVien", cnn))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        cbMaNV.ValueMember = "Tuổi";
                        cbMaNV.DataSource = dt;
                    }

                }
            }
        }

        private void hienthi()
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("select * from tblNhanVien", cnn))
                {
                    cmd.CommandType = CommandType.Text;
                    cnn.Open();
                    using (SqlDataAdapter adp = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adp.Fill(dt);
                        dataGridView1.DataSource = dt;
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                //cnn.Open();
                //int namht = DateTime.Today.Year;
                //int namsinh = ngaysinh.Value.Year;
                //if(namht-namsinh > 18)
                //{
                    
                    using (SqlDataAdapter adp = new SqlDataAdapter())
                    {
                        adp.TableMappings.Add("Tables", "tblNhanVien");

                        adp.SelectCommand = new SqlCommand("select * from tblNhanVien", cnn);
                        DataSet dts = new DataSet();
                        adp.Fill(dts, "tblNhanVien");

                        DataTable table = dts.Tables["tblNhanVien"];

                        string sql = "insert into tblNhanVien (MaNV,hoTen,ngaySinh,diaChi,soDT,heSoLuong)" +
                            "values (@MaNV,@hoTen,@ngaySinh,@diaChi,@soDT,@heSoLuong)";
                        adp.InsertCommand = new SqlCommand(sql, cnn);
                        adp.InsertCommand.Parameters.Add("@MaNV", SqlDbType.NVarChar, 10).Value = maNV.Text;
                        adp.InsertCommand.Parameters.Add("@hoTen", SqlDbType.NVarChar, 30).Value = hoten.Text;
                        adp.InsertCommand.Parameters.Add("@ngaySinh", SqlDbType.DateTime).Value = DateTime.Parse(ngaysinh.Text);
                        adp.InsertCommand.Parameters.Add("@diaChi", SqlDbType.NVarChar, 50).Value = diachi.Text;
                        adp.InsertCommand.Parameters.Add("@soDT", SqlDbType.NVarChar, 12).Value = soDT.Text;
                        adp.InsertCommand.Parameters.Add("@heSoLuong", SqlDbType.Float).Value = txthsl.Text;

                        table.Rows.Add();
                        adp.Update(dts, "tblNhanVien");
                        adp.Fill(dts, "tblNhanVien");
                    //dataGridView1.DataSource = table;
                    hienthi();

                    }
                using (SqlConnection cn = new SqlConnection(constr))
                {
                    using (SqlCommand cmd = new SqlCommand("select MaNV from tblNhanVien", cn))
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);
                            cbMaNV.ValueMember = "MaNV";
                            cbMaNV.DataSource = dt;
                        }

                    }
                }
                //}
                //else
                //{
                //    MessageBox.Show("khong du tuoi lam nhan vien");

                //}



                cnn.Close();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            maNV.Text = dataGridView1.CurrentRow.Cells["MaNV"].Value.ToString();
            hoten.Text = dataGridView1.CurrentRow.Cells["hoTen"].Value.ToString();
            soDT.Text = dataGridView1.CurrentRow.Cells["soDT"].Value.ToString();
            ngaysinh.Text = dataGridView1.CurrentRow.Cells["ngaySinh"].Value.ToString();
            diachi.Text = dataGridView1.CurrentRow.Cells["diaChi"].Value.ToString();
            txthsl.Text = dataGridView1.CurrentRow.Cells["heSoLuong"].Value.ToString();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                cnn.Open();
                using(SqlCommand cmd = cnn.CreateCommand())
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "SP_suaNhanVien";
                    cmd.Parameters.AddWithValue("@MaNV", maNV.Text);
                    cmd.Parameters.AddWithValue("@hoTen", hoten.Text);
                    cmd.Parameters.AddWithValue("@ngaySinh", DateTime.Parse(ngaysinh.Text));
                    cmd.Parameters.AddWithValue("@soDT", soDT.Text);
                    cmd.Parameters.AddWithValue("@diaChi", diachi.Text);
                    cmd.Parameters.AddWithValue("@heSoLuong", txthsl.Text);

                    cmd.ExecuteNonQuery();
                }
                hienthi();
                cnn.Close();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult chose = MessageBox.Show("Bạn thực sự muốn xóa?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if(chose == DialogResult.OK)
            {
                using (SqlConnection cnn = new SqlConnection(constr))
                {
                    cnn.Open();
                    using (SqlCommand cmd = cnn.CreateCommand())
                    {
                        cmd.CommandText = "delete from tblNhanVien where MaNV = '" + maNV.Text + "'";
                        cmd.ExecuteNonQuery();
                        hienthi();
                    }
                    cnn.Close();
                    using (SqlCommand cmd = new SqlCommand("select MaNV from tblNhanVien", cnn))
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);
                            cbMaNV.ValueMember = "MaNV";
                            cbMaNV.DataSource = dt;
                        }
                    }
                }
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {

            reportNhanVien x = new reportNhanVien();
           
            this.Hide();
            x.ShowDialog();
            this.Show();

        }


        private void btnRestart_Click(object sender, EventArgs e)
        {
            maNV.Text = "";
            hoten.Text = "";
            soDT.Text = "";
            diachi.Text = "";
            txthsl.Text = "";
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("select * from tblNhanVien", cnn))
                {
                    cmd.CommandType = CommandType.Text;
                    cnn.Open();
                    using (SqlDataAdapter adp = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adp.Fill(dt);
                        dataGridView1.DataSource = dt;
                    }
                }
            }
        }

        private void bnTK_Click(object sender, EventArgs e)
        {
            string query = "select * from tblNhanVien where YEAR(GETDATE())- YEAR(ngaySinh) = "+textBox1.Text;
            DataTable data = LoadData.Instance.ExcuteQuery(query);
            dataGridView2.DataSource = data;
        }

        private void IsNumber(string value)
        {
            if (value == "")
            {

            }
            else
                try
                {
                    if (int.Parse(value) <= 0)
                    {
                        MessageBox.Show("SDT phải là số");
                        //errorProvider1.SetError(soDT, "SDT phai la so");
                        soDT.Focus();

                    }
                }
                catch
                {
                    //MessageBox.Show("SDT phải là số");
                    soDT.Focus();

                }
            int dem = 0;
            foreach (char c in value)
            {
                dem++;
            }
            if (dem > 10 || dem < 7)
            {
                MessageBox.Show("SDT phải là phải có 9 đến 12 số");
                //errorProvider1.SetError(soDT, "Số điện thoại phải có 9 đến 12 số");
                soDT.Focus();

            }
        }

        private void soDT_Validating(object sender, CancelEventArgs e)
        {
            IsNumber(soDT.Text);
        }
    }
}
