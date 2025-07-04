using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductSaleReports
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            var sales = ProductSaleReports.GetSales(dtpStartDate.Value, dtpEndDate.Value);
            if (sales.Count == 0)
            {
                MessageBox.Show("No results found for the selected date range.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var report = new ProductSaleReports();
            report.DataSource = sales;
            report.DataMember = "";
            report.FindControl("StartDate", true).Text = dtpStartDate.Value.ToString("dd-MM-yyyy");
            report.FindControl("EndDate", true).Text =  dtpEndDate.Value.ToString("dd-MM-yyyy");

            report.CreateDocument();

            var tool = new ReportPrintTool(report);
            tool.ShowPreviewDialog();
        }
    }
}
