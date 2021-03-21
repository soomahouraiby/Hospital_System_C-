namespace Project_hos
{
    partial class welcome_manager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(welcome_manager));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonAdd_booking = new System.Windows.Forms.Button();
            this.buttonAdd_dept = new System.Windows.Forms.Button();
            this.buttonAdd_file = new System.Windows.Forms.Button();
            this.buttonAdd_patient = new System.Windows.Forms.Button();
            this.buttonAdd_doctor = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("PT Bold Heading", 48F);
            this.label1.Location = new System.Drawing.Point(378, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(301, 113);
            this.label1.TabIndex = 1;
            this.label1.Text = "مرحبا بكم";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tempus Sans ITC", 22.2F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(415, 242);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(225, 39);
            this.label2.TabIndex = 2;
            this.label2.Text = "في نظام الحجوزات";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tempus Sans ITC", 22.2F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(444, 304);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(179, 39);
            this.label3.TabIndex = 3;
            this.label3.Text = "مستشفى الحياة";
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
            this.panel1.Controls.Add(this.buttonAdd_booking);
            this.panel1.Controls.Add(this.buttonAdd_dept);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.buttonAdd_file);
            this.panel1.Controls.Add(this.buttonAdd_patient);
            this.panel1.Controls.Add(this.buttonAdd_doctor);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(189, 526);
            this.panel1.TabIndex = 4;
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
            // buttonAdd_dept
            // 
            this.buttonAdd_dept.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonAdd_dept.Font = new System.Drawing.Font("Tahoma", 12F);
            this.buttonAdd_dept.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonAdd_dept.Image = ((System.Drawing.Image)(resources.GetObject("buttonAdd_dept.Image")));
            this.buttonAdd_dept.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAdd_dept.Location = new System.Drawing.Point(-1, 457);
            this.buttonAdd_dept.Name = "buttonAdd_dept";
            this.buttonAdd_dept.Size = new System.Drawing.Size(187, 30);
            this.buttonAdd_dept.TabIndex = 13;
            this.buttonAdd_dept.Text = "Add_Dept";
            this.buttonAdd_dept.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonAdd_dept.UseVisualStyleBackColor = false;
            this.buttonAdd_dept.Click += new System.EventHandler(this.buttonAdd_dept_Click);
            // 
            // buttonAdd_file
            // 
            this.buttonAdd_file.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonAdd_file.Font = new System.Drawing.Font("Tahoma", 12F);
            this.buttonAdd_file.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonAdd_file.Image = ((System.Drawing.Image)(resources.GetObject("buttonAdd_file.Image")));
            this.buttonAdd_file.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAdd_file.Location = new System.Drawing.Point(-1, 404);
            this.buttonAdd_file.Name = "buttonAdd_file";
            this.buttonAdd_file.Size = new System.Drawing.Size(187, 28);
            this.buttonAdd_file.TabIndex = 12;
            this.buttonAdd_file.Text = "Add_File";
            this.buttonAdd_file.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonAdd_file.UseVisualStyleBackColor = false;
            this.buttonAdd_file.Click += new System.EventHandler(this.buttonAdd_file_Click);
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
            // buttonAdd_doctor
            // 
            this.buttonAdd_doctor.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonAdd_doctor.Font = new System.Drawing.Font("Tahoma", 12F);
            this.buttonAdd_doctor.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonAdd_doctor.Image = ((System.Drawing.Image)(resources.GetObject("buttonAdd_doctor.Image")));
            this.buttonAdd_doctor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAdd_doctor.Location = new System.Drawing.Point(1, 346);
            this.buttonAdd_doctor.Name = "buttonAdd_doctor";
            this.buttonAdd_doctor.Size = new System.Drawing.Size(186, 31);
            this.buttonAdd_doctor.TabIndex = 11;
            this.buttonAdd_doctor.Text = "Add_Doctor";
            this.buttonAdd_doctor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonAdd_doctor.UseVisualStyleBackColor = false;
            this.buttonAdd_doctor.Click += new System.EventHandler(this.buttonAdd_doctor_Click);
            // 
            // welcome_manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 524);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "welcome_manager";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonAdd_booking;
        private System.Windows.Forms.Button buttonAdd_dept;
        private System.Windows.Forms.Button buttonAdd_file;
        private System.Windows.Forms.Button buttonAdd_patient;
        private System.Windows.Forms.Button buttonAdd_doctor;
    }
}

