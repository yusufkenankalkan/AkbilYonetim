namespace AkbilYonetim
{
    partial class FrmAyarlar
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
            this.dtpDogumTarihi = new System.Windows.Forms.DateTimePicker();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtSoyisim = new System.Windows.Forms.TextBox();
            this.txtIsim = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dtpDogumTarihi
            // 
            this.dtpDogumTarihi.Location = new System.Drawing.Point(143, 265);
            this.dtpDogumTarihi.Name = "dtpDogumTarihi";
            this.dtpDogumTarihi.Size = new System.Drawing.Size(191, 23);
            this.dtpDogumTarihi.TabIndex = 24;
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.Color.Lime;
            this.btnGuncelle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnGuncelle.Location = new System.Drawing.Point(50, 346);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(284, 39);
            this.btnGuncelle.TabIndex = 23;
            this.btnGuncelle.Text = "GÜNCELLE";
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(143, 209);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(191, 23);
            this.txtSifre.TabIndex = 21;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(143, 155);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(191, 23);
            this.txtEmail.TabIndex = 20;
            // 
            // txtSoyisim
            // 
            this.txtSoyisim.Location = new System.Drawing.Point(143, 101);
            this.txtSoyisim.Name = "txtSoyisim";
            this.txtSoyisim.Size = new System.Drawing.Size(191, 23);
            this.txtSoyisim.TabIndex = 19;
            // 
            // txtIsim
            // 
            this.txtIsim.Location = new System.Drawing.Point(143, 47);
            this.txtIsim.Name = "txtIsim";
            this.txtIsim.Size = new System.Drawing.Size(191, 23);
            this.txtIsim.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(50, 263);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 21);
            this.label5.TabIndex = 17;
            this.label5.Text = "D. Tarihi :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(50, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 21);
            this.label4.TabIndex = 16;
            this.label4.Text = "Yeni Şifre :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(50, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 21);
            this.label3.TabIndex = 15;
            this.label3.Text = "Email :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(50, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 21);
            this.label2.TabIndex = 14;
            this.label2.Text = "Soyisim :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(50, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 21);
            this.label1.TabIndex = 13;
            this.label1.Text = "İsim :";
            // 
            // FrmAyarlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(372, 441);
            this.Controls.Add(this.dtpDogumTarihi);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtSoyisim);
            this.Controls.Add(this.txtIsim);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmAyarlar";
            this.Text = "FrmAyarlar";
            this.Load += new System.EventHandler(this.FrmAyarlar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DateTimePicker dtpDogumTarihi;
        private Button btnGuncelle;
        private TextBox txtSifre;
        private TextBox txtEmail;
        private TextBox txtSoyisim;
        private TextBox txtIsim;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}