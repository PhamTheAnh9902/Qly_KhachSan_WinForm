using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.Shared;
using CrystalDecisions.CrystalReports.Engine;
using System.Data.SqlClient;

namespace lamdatagridview
{
    public partial class reportNhanVien : Form
    {
        
        public reportNhanVien()
        {
            InitializeComponent();
        }
        private string tendn;
        private string mk;
        public reportNhanVien(string _tendn, string _mk) : this()
        {
            tendn = _tendn;
            mk = _mk;
        }

        private void reportNhanVien_Load(object sender, EventArgs e)
        {
            ReportDocument rptNhanVien = new ReportDocument();
            rptNhanVien.Load(@"C:\Users\DELLL\Desktop\btl_lthsk\lamdatagridview\nhanvien.rpt");
            //rptNhanVien.RecordSelectionFormula = "{tblNhanVien.heSoLuong}=3";
            //rptNhanVien.RecordSelectionFormula = "{tblLogin.tendn} ='"+tendn+"'";

            

                crystalReportViewer1.ReportSource = rptNhanVien;
            crystalReportViewer1.Refresh();
        }
    }
}
