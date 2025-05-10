namespace WindowsFormsApp1
{
    partial class recruiter_profile
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button10 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.cOMPANYBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.job_FairDataSet = new WindowsFormsApp1.Job_FairDataSet();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.button13 = new System.Windows.Forms.Button();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cOMPANYBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cOMPANYTableAdapter = new WindowsFormsApp1.Job_FairDataSetTableAdapters.COMPANYTableAdapter();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cOMPANYBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.job_FairDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOMPANYBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("The Bold Font", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(629, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 31);
            this.label1.TabIndex = 23;
            this.label1.Text = "Profile";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.button10);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.button7);
            this.panel1.Controls.Add(this.button8);
            this.panel1.Location = new System.Drawing.Point(31, 63);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 525);
            this.panel1.TabIndex = 24;
            // 
            // button10
            // 
            this.button10.Font = new System.Drawing.Font("The Bold Font", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.Location = new System.Drawing.Point(17, 248);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(165, 36);
            this.button10.TabIndex = 9;
            this.button10.Text = "LOGOUT";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("The Bold Font", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(17, 202);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(165, 36);
            this.button5.TabIndex = 3;
            this.button5.Text = "Interviews";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("The Bold Font", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(17, 123);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(165, 73);
            this.button6.TabIndex = 2;
            this.button6.Text = "Review Job Applications";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("The Bold Font", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(17, 81);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(165, 36);
            this.button7.TabIndex = 1;
            this.button7.Text = "Post A job";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("The Bold Font", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(17, 39);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(165, 36);
            this.button8.TabIndex = 0;
            this.button8.Text = "Profile";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(31, 5);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(88, 33);
            this.button4.TabIndex = 25;
            this.button4.Text = "Go back";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gray;
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.maskedTextBox1);
            this.panel2.Controls.Add(this.textBox5);
            this.panel2.Controls.Add(this.textBox4);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(298, 63);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(848, 531);
            this.panel2.TabIndex = 26;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(340, 153);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(323, 26);
            this.textBox1.TabIndex = 29;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("The Bold Font", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(174, 152);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(144, 27);
            this.label10.TabIndex = 28;
            this.label10.Text = "Company : ";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.RosyBrown;
            this.panel3.Controls.Add(this.comboBox1);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.textBox8);
            this.panel3.Controls.Add(this.button13);
            this.panel3.Controls.Add(this.textBox7);
            this.panel3.Controls.Add(this.textBox2);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.textBox3);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Location = new System.Drawing.Point(0, 202);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(848, 329);
            this.panel3.TabIndex = 27;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.cOMPANYBindingSource1;
            this.comboBox1.DisplayMember = "Name";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(340, 234);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(323, 28);
            this.comboBox1.TabIndex = 30;
            this.comboBox1.ValueMember = "company_ID";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // cOMPANYBindingSource1
            // 
            this.cOMPANYBindingSource1.DataMember = "COMPANY";
            this.cOMPANYBindingSource1.DataSource = this.job_FairDataSet;
            // 
            // job_FairDataSet
            // 
            this.job_FairDataSet.DataSetName = "Job_FairDataSet";
            this.job_FairDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("The Bold Font", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(116, 229);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(202, 27);
            this.label11.TabIndex = 29;
            this.label11.Text = "NEW COMPANY : ";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(340, 112);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(323, 26);
            this.textBox8.TabIndex = 27;
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(404, 276);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(88, 33);
            this.button13.TabIndex = 19;
            this.button13.Text = "Save";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(340, 67);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(323, 26);
            this.textBox7.TabIndex = 26;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(340, 194);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(323, 26);
            this.textBox2.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("The Bold Font", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(253, 31);
            this.label4.TabIndex = 13;
            this.label4.Text = "Edit YOUR Details";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(340, 152);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(323, 26);
            this.textBox3.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("The Bold Font", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(168, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(152, 27);
            this.label6.TabIndex = 17;
            this.label6.Text = "New Name : ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("The Bold Font", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(29, 193);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(291, 27);
            this.label9.TabIndex = 20;
            this.label9.Text = "Reconfirm Password : ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("The Bold Font", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(166, 107);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(154, 27);
            this.label7.TabIndex = 18;
            this.label7.Text = "New Email : ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("The Bold Font", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(106, 151);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(214, 27);
            this.label8.TabIndex = 19;
            this.label8.Text = "New Password : ";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(340, 105);
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(323, 26);
            this.maskedTextBox1.TabIndex = 25;
            this.maskedTextBox1.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(340, 18);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(323, 26);
            this.textBox5.TabIndex = 24;
            this.textBox5.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(340, 63);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(323, 26);
            this.textBox4.TabIndex = 23;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("The Bold Font", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(164, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(156, 27);
            this.label5.TabIndex = 16;
            this.label5.Text = "Password : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("The Bold Font", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(222, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 27);
            this.label3.TabIndex = 15;
            this.label3.Text = "Email : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("The Bold Font", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(224, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 27);
            this.label2.TabIndex = 7;
            this.label2.Text = "Name : ";
            // 
            // cOMPANYBindingSource
            // 
            this.cOMPANYBindingSource.DataMember = "COMPANY";
            this.cOMPANYBindingSource.DataSource = this.job_FairDataSet;
            // 
            // cOMPANYTableAdapter
            // 
            this.cOMPANYTableAdapter.ClearBeforeFill = true;
            // 
            // recruiter_profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1294, 603);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "recruiter_profile";
            this.Text = "recruiter_profile";
            this.Load += new System.EventHandler(this.recruiter_profile_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cOMPANYBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.job_FairDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOMPANYBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox comboBox1;
        private Job_FairDataSet job_FairDataSet;
        private System.Windows.Forms.BindingSource cOMPANYBindingSource;
        private Job_FairDataSetTableAdapters.COMPANYTableAdapter cOMPANYTableAdapter;
        private System.Windows.Forms.BindingSource cOMPANYBindingSource1;
    }
}