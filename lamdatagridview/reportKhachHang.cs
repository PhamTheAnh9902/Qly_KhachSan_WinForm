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
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;

namespace lamdatagridview
{
    public partial class reportKhachHang : Form
    {
        public reportKhachHang()
        {
            InitializeComponent();
        }
        public string constr = @"Data Source=DESKTOP-3N66U8D;Initial Catalog=qlykhachsan;Integrated Security=True";
        private void reportKhachHang_Load(object sender, EventArgs e)
        {
            ReportDocument rptKhachHang = new ReportDocument();
            rptKhachHang.Load(@"C:\Users\DELLL\Desktop\btl_lthsk\lamdatagridview\khachhang.rpt");
            crystalReportViewer1.ReportSource = rptKhachHang;
            crystalReportViewer1.Refresh();

            using(SqlConnection cnn = new SqlConnection(constr))
            {
                cnn.Open();
                using (SqlCommand cmd = new SqlCommand("select DiaChi from tblKhachHang", cnn))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable table = new DataTable();
                        adapter.Fill(table);
                        comboBox1.ValueMember = "DiaChi";
                        comboBox1.DataSource = table;
                    }
                }
            }
        }

        private void btnLocKH_diachi_Click_1(object sender, EventArgs e)
        {
            ReportDocument rptKhachHang = new ReportDocument();
            rptKhachHang.Load(@"C:\Users\DELLL\Desktop\btl_lthsk\lamdatagridview\khachhang.rpt");

            ParameterFieldDefinition pfd = rptKhachHang.DataDefinition.ParameterFields["diaChi"];
            ParameterValues pv = new ParameterValues();
            rptKhachHang.RecordSelectionFormula = "{tblKhachHang.diaChi} = {?diaChi}";
            ParameterDiscreteValue pdv = new ParameterDiscreteValue();

            pdv.Value = comboBox1.Text;
            pv.Add(pdv);
            pfd.CurrentValues.Clear();
            pfd.ApplyCurrentValues(pv);
            crystalReportViewer1.ReportSource = rptKhachHang;
            crystalReportViewer1.Refresh();
        }
    }
}
