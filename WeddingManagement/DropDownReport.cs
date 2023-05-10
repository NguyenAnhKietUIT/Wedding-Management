using System;
using System.Windows.Forms;

namespace WeddingManagement
{
    public partial class DropDownReport : UserControl
    {
        public DropDownReport()
        {
            InitializeComponent();
        }

        private void btnDay_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            ReportDay frm = new ReportDay();
            frm.ShowDialog();
        }

        private void btnMonth_Click(object sender, EventArgs e)
        {
            FormReportMonth frm = new FormReportMonth();
            frm.ShowDialog();
            this.Visible = false;
        }
    }
}
