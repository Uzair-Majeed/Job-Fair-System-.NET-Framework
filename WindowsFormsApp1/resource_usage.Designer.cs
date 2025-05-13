namespace WindowsFormsApp1
{
    partial class resource_usage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.label1 = new System.Windows.Forms.Label();
            this.button13 = new System.Windows.Forms.Button();
            this.job_FairDataSet = new WindowsFormsApp1.Job_FairDataSet();
            this.jobFairDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.coordTimeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.job_FairDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobFairDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coordTimeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "BoothSpace";
            reportDataSource1.Value = this.jobFairDataSetBindingSource;
            reportDataSource2.Name = "coordTime";
            reportDataSource2.Value = this.jobFairDataSetBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "WindowsFormsApp1.resource_usage.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(24, 122);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(802, 555);
            this.reportViewer1.TabIndex = 0;
            // 
            // reportViewer2
            // 
            this.reportViewer2.LocalReport.ReportEmbeddedResource = "WindowsFormsApp1.Report1.rdlc";
            this.reportViewer2.Location = new System.Drawing.Point(842, 122);
            this.reportViewer2.Name = "reportViewer2";
            this.reportViewer2.ServerReport.BearerToken = null;
            this.reportViewer2.Size = new System.Drawing.Size(769, 555);
            this.reportViewer2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("The Bold Font", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(300, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(834, 31);
            this.label1.TabIndex = 5;
            this.label1.Text = "Resource usage metrics (booth space, coordinator time)";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(34, 23);
            this.button13.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(106, 46);
            this.button13.TabIndex = 33;
            this.button13.Text = "Go back";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // job_FairDataSet
            // 
            this.job_FairDataSet.DataSetName = "Job_FairDataSet";
            this.job_FairDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // jobFairDataSetBindingSource
            // 
            this.jobFairDataSetBindingSource.DataSource = this.job_FairDataSet;
            this.jobFairDataSetBindingSource.Position = 0;
            // 
            // coordTimeBindingSource
            // 
            this.coordTimeBindingSource.DataMember = "coordTime";
            this.coordTimeBindingSource.DataSource = this.job_FairDataSet;
            // 
            // resource_usage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1623, 704);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.reportViewer2);
            this.Controls.Add(this.reportViewer1);
            this.Name = "resource_usage";
            this.Text = "resource_usage";
            this.Load += new System.EventHandler(this.resource_usage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.job_FairDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobFairDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coordTimeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.BindingSource jobFairDataSetBindingSource;
        private Job_FairDataSet job_FairDataSet;
        private System.Windows.Forms.BindingSource coordTimeBindingSource;
    }
}