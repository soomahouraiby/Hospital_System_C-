namespace Project_hos
{
    partial class Formemp
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
            this.label1 = new System.Windows.Forms.Label();
            this.buttonmanger = new System.Windows.Forms.Button();
            this.buttondoctor = new System.Windows.Forms.Button();
            this.buttonemp = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(2, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(183, 525);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Project_hos.Properties.Resources.images__2_;
            this.pictureBox1.Location = new System.Drawing.Point(3, 171);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(179, 126);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(439, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 58);
            this.label1.TabIndex = 1;
            this.label1.Text = "Welcome";
            // 
            // buttonmanger
            // 
            this.buttonmanger.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonmanger.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonmanger.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonmanger.Location = new System.Drawing.Point(675, 172);
            this.buttonmanger.Name = "buttonmanger";
            this.buttonmanger.Size = new System.Drawing.Size(210, 136);
            this.buttonmanger.TabIndex = 4;
            this.buttonmanger.Text = "Manger";
            this.buttonmanger.UseVisualStyleBackColor = false;
            this.buttonmanger.Click += new System.EventHandler(this.buttonmanger_Click);
            // 
            // buttondoctor
            // 
            this.buttondoctor.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttondoctor.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttondoctor.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttondoctor.Location = new System.Drawing.Point(436, 173);
            this.buttondoctor.Name = "buttondoctor";
            this.buttondoctor.Size = new System.Drawing.Size(210, 136);
            this.buttondoctor.TabIndex = 5;
            this.buttondoctor.Text = "Doctor";
            this.buttondoctor.UseVisualStyleBackColor = false;
            this.buttondoctor.Click += new System.EventHandler(this.buttondoctor_Click);
            // 
            // buttonemp
            // 
            this.buttonemp.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonemp.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonemp.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonemp.Location = new System.Drawing.Point(200, 172);
            this.buttonemp.Name = "buttonemp";
            this.buttonemp.Size = new System.Drawing.Size(210, 136);
            this.buttonemp.TabIndex = 6;
            this.buttonemp.Text = "Reciptions";
            this.buttonemp.UseVisualStyleBackColor = false;
            this.buttonemp.Click += new System.EventHandler(this.buttonemp_Click);
            // 
            // Formemp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 528);
            this.Controls.Add(this.buttonemp);
            this.Controls.Add(this.buttondoctor);
            this.Controls.Add(this.buttonmanger);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "Formemp";
            this.Text = "Formemp";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonmanger;
        private System.Windows.Forms.Button buttondoctor;
        private System.Windows.Forms.Button buttonemp;
    }
}