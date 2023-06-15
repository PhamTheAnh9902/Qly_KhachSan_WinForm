using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;

namespace lamdatagridview
{
    public partial class reportPhong : Form
    {
        public reportPhong()
        {
            InitializeComponent();
        }

        private void reportPhong_Load(object sender, EventArgs e)
        {
            ReportDocument rptPhong = new ReportDocument();
            rptPhong.Load(@"C:\Users\DELLL\Desktop\btl_lthsk\lamdatagridview\HDphong.rpt");

            
            crystalReportViewer1.ReportSource = rptPhong;
            crystalReportViewer1.Refresh();
        }
    }
}
