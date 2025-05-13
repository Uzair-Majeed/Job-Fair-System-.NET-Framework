using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using WindowsFormsApp1.Job_FairDataSetTableAdapters;

namespace WindowsFormsApp1
{
    public partial class resource_usage : Form
    {
        public resource_usage()
        {
            InitializeComponent();
        }

        private void resource_usage_Load(object sender, EventArgs e)
        {


            var adapter = new boothSpaceTableAdapter();
            var dt = new Job_FairDataSet.boothSpaceDataTable();
            adapter.Fill(dt);
            reportViewer1.LocalReport.ReportPath = @"E:\BS Software Engineering\Semester IV\DB_LAB\Projects\Iteration_02\WindowsFormsApp1\WindowsFormsApp1\resource_usage.rdlc";
            ReportDataSource rds = new ReportDataSource("boothSpace", (DataTable)dt);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rds);
            reportViewer1.Refresh();
            reportViewer1.RefreshReport();


            var adapter1 = new coordTimeTableAdapter();
            var dt1 = new Job_FairDataSet.coordTimeDataTable();
            adapter1.Fill(dt1);

            reportViewer2.LocalReport.ReportPath = @"E:\BS Software Engineering\Semester IV\DB_LAB\Projects\Iteration_02\WindowsFormsApp1\WindowsFormsApp1\Report1.rdlc";

            reportViewer2.LocalReport.DataSources.Clear();
            reportViewer2.LocalReport.DataSources.Add(new ReportDataSource("coordTime", (DataTable)dt1));

            reportViewer2.RefreshReport();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
            REPORT_Interface rEPORT_Interface = new REPORT_Interface();
            this.Hide();
            rEPORT_Interface.Show();
        }
    }
}
