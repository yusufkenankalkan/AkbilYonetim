namespace AkbilYonetim
{
    partial class FrmAnaSayfa
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
            this.btnAkbil = new System.Windows.Forms.Button();
            this.btnTalimat = new System.Windows.Forms.Button();
            this.btnAyarlar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAkbil
            // 
            this.btnAkbil.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAkbil.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAkbil.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAkbil.Location = new System.Drawing.Point(60, 41);
            this.btnAkbil.Name = "btnAkbil";
            this.btnAkbil.Size = new System.Drawing.Size(172, 88);
            this.btnAkbil.TabIndex = 0;
            this.btnAkbil.Text = "AKBİL İŞLEMLERİ";
            this.btnAkbil.UseVisualStyleBackColor = false;
            this.btnAkbil.Click += new System.EventHandler(this.btnAkbil_Click);
            // 
            // btnTalimat
            // 
            this.btnTalimat.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnTalimat.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnTalimat.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnTalimat.Location = new System.Drawing.Point(61, 178);
            this.btnTalimat.Name = "btnTalimat";
            this.btnTalimat.Size = new System.Drawing.Size(172, 88);
            this.btnTalimat.TabIndex = 1;
            this.btnTalimat.Text = "TALİMAT İŞLEMLERİ";
            this.btnTalimat.UseVisualStyleBackColor = false;
            // 
            // btnAyarlar
            // 
            this.btnAyarlar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAyarlar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAyarlar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAyarlar.Location = new System.Drawing.Point(60, 315);
            this.btnAyarlar.Name = "btnAyarlar";
            this.btnAyarlar.Size = new System.Drawing.Size(172, 88);
            this.btnAyarlar.TabIndex = 2;
            this.btnAyarlar.Text = "AYARLAR";
            this.btnAyarlar.UseVisualStyleBackColor = false;
            this.btnAyarlar.Click += new System.EventHandler(this.btnAyarlar_Click);
            // 
            // FrmAnaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 450);
            this.Controls.Add(this.btnAyarlar);
            this.Controls.Add(this.btnTalimat);
            this.Controls.Add(this.btnAkbil);
            this.Name = "FrmAnaSayfa";
            this.Text = "Ana Sayfa";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnAkbil;
        private Button btnTalimat;
        private Button btnAyarlar;
    }
}