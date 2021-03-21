namespace Project_hos
{
    partial class query_booking
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(query_booking));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.maskedTextBoxTime = new System.Windows.Forms.MaskedTextBox();
            this.comboBoxP_name = new System.Windows.Forms.ComboBox();
            this.comboBoxD_name = new System.Windows.Forms.ComboBox();
            this.comboBoxPay = new System.Windows.Forms.ComboBox();
            this.dateTimePickerDate = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxB_id = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonAdd_booking = new System.Windows.Forms.Button();
            this.buttonQuery_dept = new System.Windows.Forms.Button();
            this.buttonAdd_patient = new System.Windows.Forms.Button();
            this.buttonQuery_doctor = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(216, 79);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(649, 169);
            this.dataGridView1.TabIndex = 56;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.maskedTextBoxTime);
            this.groupBox1.Controls.Add(this.comboBoxP_name);
            this.groupBox1.Controls.Add(this.comboBoxD_name);
            this.groupBox1.Controls.Add(this.comboBoxPay);
            this.groupBox1.Controls.Add(this.dateTimePickerDate);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBoxB_id);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 14F);
            this.groupBox1.Location = new System.Drawing.Point(270, 271);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(471, 256);
            this.groupBox1.TabIndex = 55;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Booking_Detailes";
            this.groupBox1.Visible = false;
            // 
            // maskedTextBoxTime
            // 
            this.maskedTextBoxTime.Location = new System.Drawing.Point(151, 173);
            this.maskedTextBoxTime.Mask = "90:00";
            this.maskedTextBoxTime.Name = "maskedTextBoxTime";
            this.maskedTextBoxTime.Size = new System.Drawing.Size(283, 30);
            this.maskedTextBoxTime.TabIndex = 57;
            this.maskedTextBoxTime.ValidatingType = typeof(System.DateTime);
            this.maskedTextBoxTime.Visible = false;
            // 
            // comboBoxP_name
            // 
            this.comboBoxP_name.FormattingEnabled = true;
            this.comboBoxP_name.Location = new System.Drawing.Point(152, 100);
            this.comboBoxP_name.Name = "comboBoxP_name";
            this.comboBoxP_name.Size = new System.Drawing.Size(283, 31);
            this.comboBoxP_name.TabIndex = 56;
            this.comboBoxP_name.Visible = false;
            // 
            // comboBoxD_name
            // 
            this.comboBoxD_name.FormattingEnabled = true;
            this.comboBoxD_name.Location = new System.Drawing.Point(152, 63);
            this.comboBoxD_name.Name = "comboBoxD_name";
            this.comboBoxD_name.Size = new System.Drawing.Size(285, 31);
            this.comboBoxD_name.TabIndex = 55;
            this.comboBoxD_name.Visible = false;
            // 
            // comboBoxPay
            // 
            this.comboBoxPay.FormattingEnabled = true;
            this.comboBoxPay.Items.AddRange(new object[] {
            "3000",
            "4000",
            "5000",
            "6000",
            "7000"});
            this.comboBoxPay.Location = new System.Drawing.Point(151, 209);
            this.comboBoxPay.Name = "comboBoxPay";
            this.comboBoxPay.Size = new System.Drawing.Size(287, 31);
            this.comboBoxPay.TabIndex = 54;
            this.comboBoxPay.Visible = false;
            // 
            // dateTimePickerDate
            // 
            this.dateTimePickerDate.Location = new System.Drawing.Point(151, 137);
            this.dateTimePickerDate.Name = "dateTimePickerDate";
            this.dateTimePickerDate.Size = new System.Drawing.Size(288, 30);
            this.dateTimePickerDate.TabIndex = 53;
            this.dateTimePickerDate.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 212);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 23);
            this.label6.TabIndex = 51;
            this.label6.Text = "Required_Pay";
            this.label6.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 23);
            this.label5.TabIndex = 49;
            this.label5.Text = "Time_Booking";
            this.label5.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 23);
            this.label4.TabIndex = 47;
            this.label4.Text = "Date_Booking";
            this.label4.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 23);
            this.label3.TabIndex = 45;
            this.label3.Text = "Patient_name";
            this.label3.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 23);
            this.label1.TabIndex = 43;
            this.label1.Text = "Doctor_name";
            this.label1.Visible = false;
            // 
            // textBoxB_id
            // 
            this.textBoxB_id.Location = new System.Drawing.Point(151, 28);
            this.textBoxB_id.Name = "textBoxB_id";
            this.textBoxB_id.Size = new System.Drawing.Size(289, 30);
            this.textBoxB_id.TabIndex = 42;
            this.textBoxB_id.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 23);
            this.label2.TabIndex = 41;
            this.label2.Text = "Booking_ID";
            this.label2.Visible = false;
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
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.buttonAdd_booking);
            this.panel1.Controls.Add(this.buttonQuery_dept);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.buttonAdd_patient);
            this.panel1.Controls.Add(this.buttonQuery_doctor);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(189, 526);
            this.panel1.TabIndex = 57;
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
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label7.Location = new System.Drawing.Point(35, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 19);
            this.label7.TabIndex = 15;
            this.label7.Text = "Query_Booking";
            // 
            // query_booking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 558);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Name = "query_booking";
            this.Text = "query_booking";
            this.Load += new System.EventHandler(this.query_booking_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxTime;
        private System.Windows.Forms.ComboBox comboBoxP_name;
        private System.Windows.Forms.ComboBox comboBoxD_name;
        private System.Windows.Forms.ComboBox comboBoxPay;
        private System.Windows.Forms.DateTimePicker dateTimePickerDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxB_id;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonAdd_booking;
        private System.Windows.Forms.Button buttonQuery_dept;
        private System.Windows.Forms.Button buttonAdd_patient;
        private System.Windows.Forms.Button buttonQuery_doctor;
    }
}