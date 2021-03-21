namespace Project_hos
{
    partial class welcome_emp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(welcome_emp));
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonAdd_booking = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonQuery_dept = new System.Windows.Forms.Button();
            this.buttonAdd_patient = new System.Windows.Forms.Button();
            this.buttonQuery_doctor = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.buttonAdd_booking);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.buttonQuery_dept);
            this.panel1.Controls.Add(this.buttonAdd_patient);
            this.panel1.Controls.Add(this.buttonQuery_doctor);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(189, 526);
            this.panel1.TabIndex = 10;
            // 
            // buttonAdd_booking
            // 
            this.buttonAdd_booking.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonAdd_booking.Font = new System.Drawing.Font("Tahoma", 12F);
            this.buttonAdd_booking.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonAdd_booking.Image = global::Project_hos.Properties.Resources.insert1;
            this.buttonAdd_booking.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAdd_booking.Location = new System.Drawing.Point(1, 241);
            this.buttonAdd_booking.Name = "buttonAdd_booking";
            this.buttonAdd_booking.Size = new System.Drawing.Size(186, 33);
            this.buttonAdd_booking.TabIndex = 18;
            this.buttonAdd_booking.Text = "Add_Booking";
            this.buttonAdd_booking.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonAdd_booking.UseVisualStyleBackColor = false;
            this.buttonAdd_booking.Click += new System.EventHandler(this.buttonAdd_booking_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Project_hos.Properties.Resources.images__2_;
            this.pictureBox1.Location = new System.Drawing.Point(0, 75);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(185, 129);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // buttonQuery_dept
            // 
            this.buttonQuery_dept.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonQuery_dept.Font = new System.Drawing.Font("Tahoma", 12F);
            this.buttonQuery_dept.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonQuery_dept.Image = ((System.Drawing.Image)(resources.GetObject("buttonQuery_dept.Image")));
            this.buttonQuery_dept.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonQuery_dept.Location = new System.Drawing.Point(0, 409);
            this.buttonQuery_dept.Name = "buttonQuery_dept";
            this.buttonQuery_dept.Size = new System.Drawing.Size(187, 30);
            this.buttonQuery_dept.TabIndex = 17;
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
            this.buttonAdd_patient.Location = new System.Drawing.Point(2, 298);
            this.buttonAdd_patient.Name = "buttonAdd_patient";
            this.buttonAdd_patient.Size = new System.Drawing.Size(186, 33);
            this.buttonAdd_patient.TabIndex = 15;
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
            this.buttonQuery_doctor.Location = new System.Drawing.Point(2, 359);
            this.buttonQuery_doctor.Name = "buttonQuery_doctor";
            this.buttonQuery_doctor.Size = new System.Drawing.Size(186, 31);
            this.buttonQuery_doctor.TabIndex = 16;
            this.buttonQuery_doctor.Text = "Query_doctor";
            this.buttonQuery_doctor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonQuery_doctor.UseVisualStyleBackColor = false;
            this.buttonQuery_doctor.Click += new System.EventHandler(this.buttonQuery_doctor_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(423, 307);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(257, 35);
            this.label3.TabIndex = 13;
            this.label3.Text = "لمستشفى الحياة";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(406, 240);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(286, 39);
            this.label2.TabIndex = 12;
            this.label2.Text = " نظام المستشفى";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(382, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(338, 58);
            this.label1.TabIndex = 11;
            this.label1.Text = "مرحبا بكم في";
            // 
            // welcome_emp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 524);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "welcome_emp";
            this.Text = "welcome_emp";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonAdd_booking;
        private System.Windows.Forms.Button buttonQuery_dept;
        private System.Windows.Forms.Button buttonAdd_patient;
        private System.Windows.Forms.Button buttonQuery_doctor;
    }
}