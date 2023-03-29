namespace AkbilYonetim
{
    partial class FrmGiris
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.checkBoxHatirla = new System.Windows.Forms.CheckBox();
            this.btnKayitOl = new System.Windows.Forms.Button();
            this.btnGirisYap = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(458, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Email :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(462, 125);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Şifre :";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtEmail.Location = new System.Drawing.Point(530, 43);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(233, 29);
            this.txtEmail.TabIndex = 2;
            // 
            // txtSifre
            // 
            this.txtSifre.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSifre.Location = new System.Drawing.Point(530, 122);
            this.txtSifre.Margin = new System.Windows.Forms.Padding(4);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(233, 29);
            this.txtSifre.TabIndex = 3;
            this.txtSifre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSifre_KeyPress);
            // 
            // checkBoxHatirla
            // 
            this.checkBoxHatirla.AutoSize = true;
            this.checkBoxHatirla.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxHatirla.Font = new System.Drawing.Font("MV Boli", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.checkBoxHatirla.Location = new System.Drawing.Point(530, 178);
            this.checkBoxHatirla.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxHatirla.Name = "checkBoxHatirla";
            this.checkBoxHatirla.Size = new System.Drawing.Size(131, 25);
            this.checkBoxHatirla.TabIndex = 4;
            this.checkBoxHatirla.Text = "Beni Hatırla";
            this.checkBoxHatirla.UseVisualStyleBackColor = false;
            // 
            // btnKayitOl
            // 
            this.btnKayitOl.BackColor = System.Drawing.Color.LightCoral;
            this.btnKayitOl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnKayitOl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnKayitOl.Location = new System.Drawing.Point(530, 239);
            this.btnKayitOl.Margin = new System.Windows.Forms.Padding(4);
            this.btnKayitOl.Name = "btnKayitOl";
            this.btnKayitOl.Size = new System.Drawing.Size(107, 32);
            this.btnKayitOl.TabIndex = 5;
            this.btnKayitOl.Text = "Kayıt Ol";
            this.btnKayitOl.UseVisualStyleBackColor = false;
            this.btnKayitOl.Click += new System.EventHandler(this.btnKayitOl_Click);
            // 
            // btnGirisYap
            // 
            this.btnGirisYap.BackColor = System.Drawing.Color.Lime;
            this.btnGirisYap.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnGirisYap.Location = new System.Drawing.Point(657, 239);
            this.btnGirisYap.Margin = new System.Windows.Forms.Padding(4);
            this.btnGirisYap.Name = "btnGirisYap";
            this.btnGirisYap.Size = new System.Drawing.Size(107, 32);
            this.btnGirisYap.TabIndex = 6;
            this.btnGirisYap.Text = "Giriş Yap";
            this.btnGirisYap.UseVisualStyleBackColor = false;
            this.btnGirisYap.Click += new System.EventHandler(this.btnGirisYap_Click);
            // 
            // FrmGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AkbilYonetim.Properties.Resources.GalataGirisEkrani;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(809, 483);
            this.Controls.Add(this.btnGirisYap);
            this.Controls.Add(this.btnKayitOl);
            this.Controls.Add(this.checkBoxHatirla);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmGiris";
            this.Text = "HOŞGELDİNİZ..";
            this.Load += new System.EventHandler(this.FrmGiris_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtEmail;
        private TextBox txtSifre;
        private CheckBox checkBoxHatirla;
        private Button btnKayitOl;
        private Button btnGirisYap;
    }
}