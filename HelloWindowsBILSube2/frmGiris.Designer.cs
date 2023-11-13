namespace HelloWindowsBILSube2
{
    partial class frmGiris
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
            this.grpKullanici = new System.Windows.Forms.GroupBox();
            this.lblAd = new System.Windows.Forms.Label();
            this.lblSoyad = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.btnGiris = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdKolay = new System.Windows.Forms.RadioButton();
            this.rdOrta = new System.Windows.Forms.RadioButton();
            this.rdZor = new System.Windows.Forms.RadioButton();
            this.grpKullanici.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpKullanici
            // 
            this.grpKullanici.Controls.Add(this.lblAd);
            this.grpKullanici.Controls.Add(this.lblSoyad);
            this.grpKullanici.Controls.Add(this.txtAd);
            this.grpKullanici.Controls.Add(this.txtSoyad);
            this.grpKullanici.Location = new System.Drawing.Point(37, 42);
            this.grpKullanici.Name = "grpKullanici";
            this.grpKullanici.Size = new System.Drawing.Size(202, 123);
            this.grpKullanici.TabIndex = 0;
            this.grpKullanici.TabStop = false;
            this.grpKullanici.Text = "Kullanıcı Bilgileri";
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Location = new System.Drawing.Point(22, 48);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(20, 13);
            this.lblAd.TabIndex = 1;
            this.lblAd.Text = "Ad";
            // 
            // lblSoyad
            // 
            this.lblSoyad.AutoSize = true;
            this.lblSoyad.Location = new System.Drawing.Point(22, 74);
            this.lblSoyad.Name = "lblSoyad";
            this.lblSoyad.Size = new System.Drawing.Size(37, 13);
            this.lblSoyad.TabIndex = 2;
            this.lblSoyad.Text = "Soyad";
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(63, 41);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(100, 20);
            this.txtAd.TabIndex = 0;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(63, 67);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(100, 20);
            this.txtSoyad.TabIndex = 1;
            // 
            // btnGiris
            // 
            this.btnGiris.Location = new System.Drawing.Point(37, 258);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(202, 46);
            this.btnGiris.TabIndex = 5;
            this.btnGiris.Text = "Oyunu Başlat";
            this.btnGiris.UseVisualStyleBackColor = true;
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdZor);
            this.groupBox1.Controls.Add(this.rdOrta);
            this.groupBox1.Controls.Add(this.rdKolay);
            this.groupBox1.Location = new System.Drawing.Point(39, 171);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 81);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seviye İşlemleri";
            // 
            // rdKolay
            // 
            this.rdKolay.AutoSize = true;
            this.rdKolay.Location = new System.Drawing.Point(22, 36);
            this.rdKolay.Name = "rdKolay";
            this.rdKolay.Size = new System.Drawing.Size(51, 17);
            this.rdKolay.TabIndex = 2;
            this.rdKolay.TabStop = true;
            this.rdKolay.Text = "Kolay";
            this.rdKolay.UseVisualStyleBackColor = true;
            // 
            // rdOrta
            // 
            this.rdOrta.AutoSize = true;
            this.rdOrta.Location = new System.Drawing.Point(77, 36);
            this.rdOrta.Name = "rdOrta";
            this.rdOrta.Size = new System.Drawing.Size(45, 17);
            this.rdOrta.TabIndex = 3;
            this.rdOrta.TabStop = true;
            this.rdOrta.Text = "Orta";
            this.rdOrta.UseVisualStyleBackColor = true;
            // 
            // rdZor
            // 
            this.rdZor.AutoSize = true;
            this.rdZor.Location = new System.Drawing.Point(136, 36);
            this.rdZor.Name = "rdZor";
            this.rdZor.Size = new System.Drawing.Size(41, 17);
            this.rdZor.TabIndex = 4;
            this.rdZor.TabStop = true;
            this.rdZor.Text = "Zor";
            this.rdZor.UseVisualStyleBackColor = true;
            // 
            // frmGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 334);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnGiris);
            this.Controls.Add(this.grpKullanici);
            this.Name = "frmGiris";
            this.Text = "frmGiris";
            this.grpKullanici.ResumeLayout(false);
            this.grpKullanici.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpKullanici;
        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.Label lblSoyad;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.Button btnGiris;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdZor;
        private System.Windows.Forms.RadioButton rdOrta;
        private System.Windows.Forms.RadioButton rdKolay;
    }
}