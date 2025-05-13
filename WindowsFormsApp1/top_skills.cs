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
    public partial class top_skills : Form
    {
        public top_skills()
        {
            InitializeComponent();
        }

        private void top_skills_Load(object sender, EventArgs e)
        {
            var adapter = new top_skillsTableAdapter();
            var dt = new Job_FairDataSet.top_skillsDataTable();

            adapter.Fill(dt);

            reportViewer1.LocalReport.ReportPath = @"E:\BS Software Engineering\Semester IV\DB_LAB\Projects\Iteration_02\WindowsFormsApp1\WindowsFormsApp1\top_skills.rdlc";

            ReportDataSource rds = new ReportDataSource("top_skills", (DataTable)dt);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rds);

            reportViewer1.RefreshReport();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            REPORT_Interface rEPORT_Interface = new REPORT_Interface();
            this.Hide();
            rEPORT_Interface.Show();
        }
    }
}
