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
    public partial class KhachHang : Form
    {
        public KhachHang()
        {
            InitializeComponent();
        }

        public string constr = @"Data Source=DESKTOP-3N66U8D;Initial Catalog=qlykhachsan;Integrated Security=True";

        private void KhachHang_Load(object sender, EventArgs e)
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("select * from tblKhachHang", cnn))
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
                //ThemNgaySinh();
            }
        }

        public void ThemNgaySinh()
        {
            using (SqlConnection cnn= new SqlConnection(constr))
            {
                cnn.Open();
                using (SqlCommand cmd = cnn.CreateCommand())
                {
                    cmd.CommandText = "alter table tblKhachHang ADD ngaySinh datetime";
                    cmd.ExecuteNonQuery();
                    hienKH();
                }
                cnn.Close();
            }
        }
        private void hienKH()
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("select * from tblKhachHang", cnn))
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

        private void btnThemKH_Click(object sender, EventArgs e)
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                cnn.Open();
                using (SqlDataAdapter adp = new SqlDataAdapter())
                {
                    adp.TableMappings.Add("Tables", "tblKhachHang");

                    adp.SelectCommand = new SqlCommand("select * from tblKhachHang", cnn);
                    DataSet dts = new DataSet();
                    adp.Fill(dts, "tblKhachHang");

                    DataTable table = dts.Tables["tblKhachHang"];

                    string sql = "insert into tblKhachHang (MaKH,hoTen,gioiTinh,diaChi,dienThoai,cmnd,ngaySinh)" +
                        "values (@MaKH,@hoTen,@gioiTinh,@diaChi,@dienThoai,@cmnd,@ngaySinh)";
                    adp.InsertCommand = new SqlCommand(sql, cnn);
                    adp.InsertCommand.Parameters.Add("@MaKH", SqlDbType.NVarChar, 10).Value = maKH.Text;
                    adp.InsertCommand.Parameters.Add("@hoTen", SqlDbType.NVarChar, 30).Value = hotenKH.Text;
                    adp.InsertCommand.Parameters.Add("@gioiTinh", SqlDbType.NVarChar, 3).Value = (cbGioiTinh.Text).ToString();
                    adp.InsertCommand.Parameters.Add("@diaChi", SqlDbType.NVarChar, 50).Value = diachiKH.Text;
                    adp.InsertCommand.Parameters.Add("@dienThoai", SqlDbType.NVarChar, 12).Value = soDT_KH.Text;
                    adp.InsertCommand.Parameters.Add("@cmnd", SqlDbType.NVarChar, 30).Value = cmnd.Text;
                    adp.InsertCommand.Parameters.Add("@ngaySinh", SqlDbType.DateTime).Value =DateTime.Parse(ngaySinh.Text);


                    table.Rows.Add();


                    adp.Update(dts, "tblKhachHang");
                    adp.Fill(dts, "tblKhachHang");
                    //dataGridView1.DataSource = table;
                    hienKH();
                }
                cnn.Close();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            hienKH();
            maKH.Text = "";
            hotenKH.Text ="";
            cbGioiTinh.Text = "";
            diachiKH.Text = "";
            soDT_KH.Text = "";
            cmnd.Text = "";
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            maKH.Text = dataGridView1.CurrentRow.Cells["MaKH"].Value.ToString();
            hotenKH.Text = dataGridView1.CurrentRow.Cells["hoTen"].Value.ToString();
            cbGioiTinh.Text = dataGridView1.CurrentRow.Cells["gioiTinh"].Value.ToString();
            diachiKH.Text = dataGridView1.CurrentRow.Cells["diaChi"].Value.ToString();
            soDT_KH.Text = dataGridView1.CurrentRow.Cells["dienThoai"].Value.ToString();
            cmnd.Text = dataGridView1.CurrentRow.Cells["cmnd"].Value.ToString();
            ngaySinh.Text= dataGridView1.CurrentRow.Cells["ngaySinh"].Value.ToString();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                cnn.Open();
                using (SqlCommand cmd = cnn.CreateCommand())
                {
                    DateTime date = DateTime.Parse(ngaySinh.Text);
                    cmd.CommandText = "update tblKhachHang set MaKH = '" + maKH.Text + "', hoTen = '" + hotenKH.Text + "',gioiTinh = '" + (cbGioiTinh.Text).ToString() + "', diaChi = '" + diachiKH.Text + "',dienThoai = '" + soDT_KH.Text + "',cmnd='"+ cmnd.Text +"',ngaySinh='" +date.ToString("dd/MM/yyyy") + "' where(MaKH = '" + maKH.Text + "')";
                    //cmd.CommandText = "sp_SuaKhachHang";
                    //cmd.Parameters.AddWithValue("@MaKH", maKH.Text);
                    //cmd.Parameters.AddWithValue("@hoTen", hotenKH.Text);
                    //cmd.Parameters.AddWithValue("@gioiTinh", gioitinh.Text);hoTen,gioiTinh,diaChi,dienThoai,cmnd,ngaySinh
                    //cmd.Parameters.AddWithValue("@diaChi", diachiKH.Text);
                    //cmd.Parameters.AddWithValue("@dienThoai", soDT_KH.Text);
                    //cmd.Parameters.AddWithValue("@cmnd", cmnd.Text);

                    cmd.ExecuteNonQuery();
                }
                hienKH();
                cnn.Close();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult chose = MessageBox.Show("Bạn thực sự muốn xóa?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (chose == DialogResult.OK)
            {
                using (SqlConnection cnn = new SqlConnection(constr))
                {
                    cnn.Open();
                    using (SqlCommand cmd = cnn.CreateCommand())
                    {
                        cmd.CommandText = "delete from tblKhachHang where MaKH = '" + maKH.Text + "'";
                        cmd.ExecuteNonQuery();
                        hienKH();
                    }
                    cnn.Close();
                }
            }
        }

        private void xuatRP_Click(object sender, EventArgs e)
        {
            reportKhachHang rptKH = new reportKhachHang();
            this.Hide();
            rptKH.ShowDialog();
            this.Show();
        }

        

        private void hotenKH_Validating(object sender, CancelEventArgs e)
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                cnn.Open();
                using (SqlCommand cmd = cnn.CreateCommand())
                {
                    cmd.CommandText = "select count(*) from tblKhachHang where (hoTen= '" + hotenKH.Text + "')";
                    cmd.ExecuteNonQuery();
                    int a = (int)cmd.ExecuteScalar();
                    if (a == 1)
                    {
                        errorProvider1.SetError(hotenKH, "bị trùng họ tên khách hàng");
                        btnThemKH.Enabled = false;
                    }
                    else
                    {

                        btnThemKH.Enabled = true;
                    }
                }
                cnn.Close();
            }
        }

        private void ngaySinh_Validating(object sender, CancelEventArgs e)
        {
            if(ngaySinh.Value > DateTime.Today)
            {
                errorProvider1.SetError(ngaySinh, "ngay sinh ko duoc lon hon ngay hien tai");
                btnThemKH.Enabled = false;
            }
            else
            {
                errorProvider1.SetError(ngaySinh, "");
            }
        }
    }
}
