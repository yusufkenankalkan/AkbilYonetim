namespace AkbilYonetim
{
    partial class FrmKayitOl
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtIsim = new System.Windows.Forms.TextBox();
            this.txtSoyisim = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.btnKayitOl = new System.Windows.Forms.Button();
            this.btnGirisYap = new System.Windows.Forms.Button();
            this.dtpDogumTarihi = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(58, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "İsim :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(58, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Soyisim :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(58, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Email :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(58, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Şifre :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(58, 255);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 21);
            this.label5.TabIndex = 4;
            this.label5.Text = "D. Tarihi :";
            // 
            // txtIsim
            // 
            this.txtIsim.BackColor = System.Drawing.SystemColors.Window;
            this.txtIsim.Location = new System.Drawing.Point(140, 37);
            this.txtIsim.Name = "txtIsim";
            this.txtIsim.Size = new System.Drawing.Size(191, 23);
            this.txtIsim.TabIndex = 5;
            this.txtIsim.TextChanged += new System.EventHandler(this.txtIsim_TextChanged);
            // 
            // txtSoyisim
            // 
            this.txtSoyisim.Location = new System.Drawing.Point(140, 91);
            this.txtSoyisim.Name = "txtSoyisim";
            this.txtSoyisim.Size = new System.Drawing.Size(191, 23);
            this.txtSoyisim.TabIndex = 6;
            this.txtSoyisim.TextChanged += new System.EventHandler(this.txtSoyisim_TextChanged);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(140, 145);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(191, 23);
            this.txtEmail.TabIndex = 7;
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(140, 199);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(191, 23);
            this.txtSifre.TabIndex = 8;
            // 
            // btnKayitOl
            // 
            this.btnKayitOl.BackColor = System.Drawing.Color.Gold;
            this.btnKayitOl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnKayitOl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnKayitOl.Location = new System.Drawing.Point(58, 319);
            this.btnKayitOl.Name = "btnKayitOl";
            this.btnKayitOl.Size = new System.Drawing.Size(273, 39);
            this.btnKayitOl.TabIndex = 10;
            this.btnKayitOl.Text = "KAYIT OL";
            this.btnKayitOl.UseVisualStyleBackColor = false;
            this.btnKayitOl.Click += new System.EventHandler(this.btnKayitOl_Click);
            // 
            // btnGirisYap
            // 
            this.btnGirisYap.BackColor = System.Drawing.Color.Lime;
            this.btnGirisYap.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnGirisYap.Location = new System.Drawing.Point(58, 381);
            this.btnGirisYap.Name = "btnGirisYap";
            this.btnGirisYap.Size = new System.Drawing.Size(273, 39);
            this.btnGirisYap.TabIndex = 11;
            this.btnGirisYap.Text = "GİRİŞ YAP";
            this.btnGirisYap.UseVisualStyleBackColor = false;
            this.btnGirisYap.Click += new System.EventHandler(this.btnGirisYap_Click);
            // 
            // dtpDogumTarihi
            // 
            this.dtpDogumTarihi.Location = new System.Drawing.Point(140, 255);
            this.dtpDogumTarihi.Name = "dtpDogumTarihi";
            this.dtpDogumTarihi.Size = new System.Drawing.Size(191, 23);
            this.dtpDogumTarihi.TabIndex = 12;
            // 
            // FrmKayitOl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(396, 472);
            this.Controls.Add(this.dtpDogumTarihi);
            this.Controls.Add(this.btnGirisYap);
            this.Controls.Add(this.btnKayitOl);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtSoyisim);
            this.Controls.Add(this.txtIsim);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmKayitOl";
            this.Text = "KAYIT EKRANI";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmKayitOl_FormClosed);
            this.Load += new System.EventHandler(this.FrmKayitOl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtIsim;
        private TextBox txtSoyisim;
        private TextBox txtEmail;
        private TextBox txtSifre;
        private Button btnKayitOl;
        private Button btnGirisYap;
        private DateTimePicker dtpDogumTarihi;
    }
}