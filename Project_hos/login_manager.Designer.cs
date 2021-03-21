namespace Project_hos
{
    partial class login_manager
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelUI = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonlogin = new System.Windows.Forms.Button();
            this.textBoxid = new System.Windows.Forms.TextBox();
            this.textBoxname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonclose = new System.Windows.Forms.Button();
            this.buttonback = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(2, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(238, 494);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Project_hos.Properties.Resources.images__2_;
            this.pictureBox1.Location = new System.Drawing.Point(0, 148);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(237, 172);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // labelUI
            // 
            this.labelUI.AutoSize = true;
            this.labelUI.Font = new System.Drawing.Font("Tahoma", 18F);
            this.labelUI.Location = new System.Drawing.Point(494, 73);
            this.labelUI.Name = "labelUI";
            this.labelUI.Size = new System.Drawing.Size(149, 29);
            this.labelUI.TabIndex = 1;
            this.labelUI.Text = "واجهة الدخول";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 1F);
            this.label4.Location = new System.Drawing.Point(433, 289);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 2);
            this.label4.TabIndex = 53;
            // 
            // buttonlogin
            // 
            this.buttonlogin.BackColor = System.Drawing.Color.Black;
            this.buttonlogin.Font = new System.Drawing.Font("Tahoma", 14F);
            this.buttonlogin.ForeColor = System.Drawing.Color.White;
            this.buttonlogin.Location = new System.Drawing.Point(536, 301);
            this.buttonlogin.Name = "buttonlogin";
            this.buttonlogin.Size = new System.Drawing.Size(103, 38);
            this.buttonlogin.TabIndex = 52;
            this.buttonlogin.Text = "دخول";
            this.buttonlogin.UseVisualStyleBackColor = false;
            this.buttonlogin.Click += new System.EventHandler(this.buttonlogin_Click);
            // 
            // textBoxid
            // 
            this.textBoxid.Location = new System.Drawing.Point(499, 234);
            this.textBoxid.Name = "textBoxid";
            this.textBoxid.PasswordChar = '*';
            this.textBoxid.Size = new System.Drawing.Size(204, 20);
            this.textBoxid.TabIndex = 51;
            // 
            // textBoxname
            // 
            this.textBoxname.Location = new System.Drawing.Point(499, 187);
            this.textBoxname.Name = "textBoxname";
            this.textBoxname.Size = new System.Drawing.Size(204, 20);
            this.textBoxname.TabIndex = 50;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 14F);
            this.label3.Location = new System.Drawing.Point(389, 234);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 23);
            this.label3.TabIndex = 49;
            this.label3.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 14F);
            this.label2.Location = new System.Drawing.Point(389, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 23);
            this.label2.TabIndex = 48;
            this.label2.Text = "User_name";
            // 
            // buttonclose
            // 
            this.buttonclose.BackColor = System.Drawing.Color.Black;
            this.buttonclose.Font = new System.Drawing.Font("Tahoma", 12F);
            this.buttonclose.ForeColor = System.Drawing.Color.White;
            this.buttonclose.Image = global::Project_hos.Properties.Resources.delete;
            this.buttonclose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonclose.Location = new System.Drawing.Point(797, 13);
            this.buttonclose.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonclose.Name = "buttonclose";
            this.buttonclose.Size = new System.Drawing.Size(78, 41);
            this.buttonclose.TabIndex = 47;
            this.buttonclose.Text = "اغلاق";
            this.buttonclose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonclose.UseVisualStyleBackColor = false;
            this.buttonclose.Click += new System.EventHandler(this.buttonclose_Click_1);
            // 
            // buttonback
            // 
            this.buttonback.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonback.Font = new System.Drawing.Font("Tahoma", 12F);
            this.buttonback.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonback.Location = new System.Drawing.Point(797, 432);
            this.buttonback.Name = "buttonback";
            this.buttonback.Size = new System.Drawing.Size(78, 46);
            this.buttonback.TabIndex = 54;
            this.buttonback.Text = "رجوع";
            this.buttonback.UseVisualStyleBackColor = false;
            this.buttonback.Click += new System.EventHandler(this.buttonback_Click);
            // 
            // login_manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 500);
            this.Controls.Add(this.buttonback);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonlogin);
            this.Controls.Add(this.textBoxid);
            this.Controls.Add(this.textBoxname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonclose);
            this.Controls.Add(this.labelUI);
            this.Controls.Add(this.panel1);
            this.Name = "login_manager";
            this.Text = "login";
            this.Load += new System.EventHandler(this.login_manager_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelUI;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonlogin;
        private System.Windows.Forms.TextBox textBoxid;
        private System.Windows.Forms.TextBox textBoxname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonclose;
        private System.Windows.Forms.Button buttonback;
    }
}