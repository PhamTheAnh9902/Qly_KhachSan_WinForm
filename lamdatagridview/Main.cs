using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lamdatagridview
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private string tendn;
        private string mk;
        public Main(string _tendn, string _mk) : this()
        {
            tendn = _tendn;
            mk = _mk;
        }
        private void thôngTinKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KhachHang kh = new KhachHang();
            kh.MdiParent = this;
            kh.Show();


        }

        private void thôngTinNhânViênToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form1 nhanvien = new Form1();
            nhanvien.MdiParent = this;
            nhanvien.Show();
        }
        private void Main_Load(object sender, EventArgs e)
        {

        }
       

       

        private void hDPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            reportHDphong1 rpPhong = new reportHDphong1();
            rpPhong.MdiParent = this;
            rpPhong.Show();
        }

        private void hDDịchVụToolStripMenuItem_Click(object sender, EventArgs e)
        {
            reportHDdichvu rpdv = new reportHDdichvu();
            rpdv.MdiParent = this;
            rpdv.Show();
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            reportNhanVien nhanvien = new reportNhanVien();
            nhanvien.MdiParent = this;
            nhanvien.Show();
        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            reportKhachHang kh = new reportKhachHang();
            kh.MdiParent = this;
            kh.Show();
        }

        private void dihchVụKhacToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DichVuKS dvks = new DichVuKS();
            dvks.MdiParent = this;
            dvks.Show();
        }

        private void kháchHàngDịchVụToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KH_DV khdv = new KH_DV();
            khdv.MdiParent = this;
            khdv.Show();
        }

        private void hóaĐơnPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            reportHDphong1 rpPhong = new reportHDphong1();
            rpPhong.MdiParent = this;
            rpPhong.Show();
        }

        private void hóaĐơnDịchVụToolStripMenuItem_Click(object sender, EventArgs e)
        {
            reportHDdichvu rpdv = new reportHDdichvu();
            rpdv.MdiParent = this;
            rpdv.Show();
        }

    }
}
