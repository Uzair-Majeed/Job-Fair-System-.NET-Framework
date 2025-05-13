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
    public partial class total_interviews_per_company : Form
    {
        public total_interviews_per_company()
        {
            InitializeComponent();
        }

        private void total_interviews_per_company_Load(object sender, EventArgs e)
        {
            var adapter = new Total_InterviewsTableAdapter();
            var dt = new Job_FairDataSet.Total_InterviewsDataTable();

            adapter.Fill(dt);

            reportViewer1.LocalReport.ReportPath = @"E:\BS Software Engineering\Semester IV\DB_LAB\Projects\Iteration_02\WindowsFormsApp1\WindowsFormsApp1\total_interviews_per_company.rdlc";

            ReportDataSource rds = new ReportDataSource("Total_Interviews", (DataTable)dt);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rds);

            reportViewer1.RefreshReport();
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
