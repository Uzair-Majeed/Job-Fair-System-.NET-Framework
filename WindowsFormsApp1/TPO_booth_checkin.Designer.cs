﻿namespace WindowsFormsApp1
{
    partial class TPO_booth_checkin
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
            this.button4 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button10 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.jobFairDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.job_FairDataSet1 = new WindowsFormsApp1.Job_FairDataSet1();
            this.bOOTHCHECKINBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bOOTH_CHECKINTableAdapter = new WindowsFormsApp1.Job_FairDataSet1TableAdapters.BOOTH_CHECKINTableAdapter();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobFairDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.job_FairDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bOOTHCHECKINBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(26, 12);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(88, 32);
            this.button4.TabIndex = 31;
            this.button4.Text = "Go back";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.button8);
            this.panel1.Controls.Add(this.button7);
            this.panel1.Controls.Add(this.button10);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(26, 60);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 522);
            this.panel1.TabIndex = 32;
            // 
            // button10
            // 
            this.button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.Location = new System.Drawing.Point(17, 471);
            this.button10.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(165, 36);
            this.button10.TabIndex = 9;
            this.button10.Text = "LOGOUT";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(17, 182);
            this.button5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(165, 76);
            this.button5.TabIndex = 4;
            this.button5.Text = "Booth Check-ins";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(17, 122);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(165, 52);
            this.button3.TabIndex = 2;
            this.button3.Text = "Assign Booths";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(17, 81);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(165, 36);
            this.button2.TabIndex = 1;
            this.button2.Text = "Job Fairs";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(17, 39);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(165, 36);
            this.button1.TabIndex = 0;
            this.button1.Text = "Profile";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(620, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 32);
            this.label1.TabIndex = 33;
            this.label1.Text = "Booth Checkin";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gray;
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Location = new System.Drawing.Point(256, 60);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(925, 522);
            this.panel2.TabIndex = 34;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(142, 39);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(665, 468);
            this.dataGridView1.TabIndex = 0;
            // 
            // jobFairDataSet1BindingSource
            // 
            this.jobFairDataSet1BindingSource.DataSource = this.job_FairDataSet1;
            this.jobFairDataSet1BindingSource.Position = 0;
            // 
            // job_FairDataSet1
            // 
            this.job_FairDataSet1.DataSetName = "Job_FairDataSet1";
            this.job_FairDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bOOTHCHECKINBindingSource
            // 
            this.bOOTHCHECKINBindingSource.DataMember = "BOOTH_CHECKIN";
            this.bOOTHCHECKINBindingSource.DataSource = this.jobFairDataSet1BindingSource;
            // 
            // bOOTH_CHECKINTableAdapter
            // 
            this.bOOTH_CHECKINTableAdapter.ClearBeforeFill = true;
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("The Bold Font", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(17, 357);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(165, 57);
            this.button7.TabIndex = 37;
            this.button7.Text = "MANAGE USERS";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("The Bold Font", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(17, 275);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(165, 76);
            this.button6.TabIndex = 36;
            this.button6.Text = "Approve/reject registrations";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("The Bold Font", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(17, 427);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(165, 39);
            this.button8.TabIndex = 35;
            this.button8.Text = "REPORTS";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // TPO_booth_checkin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1218, 611);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button4);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "TPO_booth_checkin";
            this.Text = "TPO_booth_checkin";
            this.Load += new System.EventHandler(this.TPO_booth_checkin_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobFairDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.job_FairDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bOOTHCHECKINBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource jobFairDataSet1BindingSource;
        private Job_FairDataSet1 job_FairDataSet1;
        private System.Windows.Forms.BindingSource bOOTHCHECKINBindingSource;
        private Job_FairDataSet1TableAdapters.BOOTH_CHECKINTableAdapter bOOTH_CHECKINTableAdapter;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
    }
}