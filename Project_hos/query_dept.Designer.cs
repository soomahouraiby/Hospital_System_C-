namespace Project_hos
{
    partial class query_dept
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(query_dept));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonAdd_booking = new System.Windows.Forms.Button();
            this.buttonQuery_dept = new System.Windows.Forms.Button();
            this.buttonAdd_patient = new System.Windows.Forms.Button();
            this.buttonQuery_doctor = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxid = new System.Windows.Forms.TextBox();
            this.textBoxname = new System.Windows.Forms.TextBox();
            this.labelid = new System.Windows.Forms.Label();
            this.labelname = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Project_hos.Properties.Resources.images__2_;
            this.pictureBox1.Location = new System.Drawing.Point(4, 78);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(185, 129);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.buttonAdd_booking);
            this.panel1.Controls.Add(this.buttonQuery_dept);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.buttonAdd_patient);
            this.panel1.Controls.Add(this.buttonQuery_doctor);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(189, 526);
            this.panel1.TabIndex = 9;
            // 
            // buttonAdd_booking
            // 
            this.buttonAdd_booking.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonAdd_booking.Font = new System.Drawing.Font("Tahoma", 12F);
            this.buttonAdd_booking.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonAdd_booking.Image = global::Project_hos.Properties.Resources.insert1;
            this.buttonAdd_booking.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAdd_booking.Location = new System.Drawing.Point(0, 228);
            this.buttonAdd_booking.Name = "buttonAdd_booking";
            this.buttonAdd_booking.Size = new System.Drawing.Size(186, 33);
            this.buttonAdd_booking.TabIndex = 14;
            this.buttonAdd_booking.Text = "Add_Booking";
            this.buttonAdd_booking.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonAdd_booking.UseVisualStyleBackColor = false;
            this.buttonAdd_booking.Click += new System.EventHandler(this.buttonAdd_booking_Click);
            // 
            // buttonQuery_dept
            // 
            this.buttonQuery_dept.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonQuery_dept.Font = new System.Drawing.Font("Tahoma", 12F);
            this.buttonQuery_dept.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonQuery_dept.Image = ((System.Drawing.Image)(resources.GetObject("buttonQuery_dept.Image")));
            this.buttonQuery_dept.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonQuery_dept.Location = new System.Drawing.Point(-1, 396);
            this.buttonQuery_dept.Name = "buttonQuery_dept";
            this.buttonQuery_dept.Size = new System.Drawing.Size(187, 30);
            this.buttonQuery_dept.TabIndex = 13;
            this.buttonQuery_dept.Text = "Query_Dept";
            this.buttonQuery_dept.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonQuery_dept.UseVisualStyleBackColor = false;
            this.buttonQuery_dept.Click += new System.EventHandler(this.buttonQuery_dept_Click);
            // 
            // buttonAdd_patient
            // 
            this.buttonAdd_patient.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonAdd_patient.Font = new System.Drawing.Font("Tahoma", 12F);
            this.buttonAdd_patient.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonAdd_patient.Image = global::Project_hos.Properties.Resources.user__1_;
            this.buttonAdd_patient.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAdd_patient.Location = new System.Drawing.Point(1, 285);
            this.buttonAdd_patient.Name = "buttonAdd_patient";
            this.buttonAdd_patient.Size = new System.Drawing.Size(186, 33);
            this.buttonAdd_patient.TabIndex = 10;
            this.buttonAdd_patient.Text = "Add_Patient";
            this.buttonAdd_patient.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonAdd_patient.UseVisualStyleBackColor = false;
            this.buttonAdd_patient.Click += new System.EventHandler(this.buttonAdd_patient_Click);
            // 
            // buttonQuery_doctor
            // 
            this.buttonQuery_doctor.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonQuery_doctor.Font = new System.Drawing.Font("Tahoma", 12F);
            this.buttonQuery_doctor.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonQuery_doctor.Image = ((System.Drawing.Image)(resources.GetObject("buttonQuery_doctor.Image")));
            this.buttonQuery_doctor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonQuery_doctor.Location = new System.Drawing.Point(1, 346);
            this.buttonQuery_doctor.Name = "buttonQuery_doctor";
            this.buttonQuery_doctor.Size = new System.Drawing.Size(186, 31);
            this.buttonQuery_doctor.TabIndex = 11;
            this.buttonQuery_doctor.Text = "Query_doctor";
            this.buttonQuery_doctor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonQuery_doctor.UseVisualStyleBackColor = false;
            this.buttonQuery_doctor.Click += new System.EventHandler(this.buttonQuery_doctor_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxid);
            this.groupBox1.Controls.Add(this.textBoxname);
            this.groupBox1.Controls.Add(this.labelid);
            this.groupBox1.Controls.Add(this.labelname);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 12F);
            this.groupBox1.Location = new System.Drawing.Point(345, 303);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(375, 140);
            this.groupBox1.TabIndex = 72;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dept_Data";
            this.groupBox1.Visible = false;
            // 
            // textBoxid
            // 
            this.textBoxid.Location = new System.Drawing.Point(137, 41);
            this.textBoxid.Name = "textBoxid";
            this.textBoxid.PasswordChar = '*';
            this.textBoxid.Size = new System.Drawing.Size(204, 27);
            this.textBoxid.TabIndex = 69;
            this.textBoxid.Visible = false;
            // 
            // textBoxname
            // 
            this.textBoxname.Location = new System.Drawing.Point(137, 92);
            this.textBoxname.Name = "textBoxname";
            this.textBoxname.Size = new System.Drawing.Size(204, 27);
            this.textBoxname.TabIndex = 68;
            this.textBoxname.Visible = false;
            // 
            // labelid
            // 
            this.labelid.AutoSize = true;
            this.labelid.Font = new System.Drawing.Font("Tahoma", 14F);
            this.labelid.Location = new System.Drawing.Point(21, 41);
            this.labelid.Name = "labelid";
            this.labelid.Size = new System.Drawing.Size(78, 23);
            this.labelid.TabIndex = 67;
            this.labelid.Text = "Dept_Id";
            this.labelid.Visible = false;
            // 
            // labelname
            // 
            this.labelname.AutoSize = true;
            this.labelname.Font = new System.Drawing.Font("Tahoma", 14F);
            this.labelname.Location = new System.Drawing.Point(21, 92);
            this.labelname.Name = "labelname";
            this.labelname.Size = new System.Drawing.Size(107, 23);
            this.labelname.TabIndex = 66;
            this.labelname.Text = "Dept_name";
            this.labelname.Visible = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(369, 101);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(339, 176);
            this.dataGridView1.TabIndex = 71;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label1.Location = new System.Drawing.Point(36, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 19);
            this.label1.TabIndex = 15;
            this.label1.Text = "Query_Dept";
            // 
            // query_dept
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 504);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "query_dept";
            this.Text = "query_dept";
            this.Load += new System.EventHandler(this.query_dept_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonAdd_booking;
        private System.Windows.Forms.Button buttonQuery_dept;
        private System.Windows.Forms.Button buttonAdd_patient;
        private System.Windows.Forms.Button buttonQuery_doctor;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxid;
        private System.Windows.Forms.TextBox textBoxname;
        private System.Windows.Forms.Label labelid;
        private System.Windows.Forms.Label labelname;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
    }
}