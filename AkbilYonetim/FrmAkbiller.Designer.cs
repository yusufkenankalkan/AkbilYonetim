namespace AkbilYonetim
{
    partial class FrmAkbiller
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aNASAYFAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çIKIŞYAPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbAkbilTipleri = new System.Windows.Forms.ComboBox();
            this.maskTxtAkbilNo = new System.Windows.Forms.MaskedTextBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewAkbiller = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAkbiller)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aNASAYFAToolStripMenuItem,
            this.çIKIŞYAPToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(611, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aNASAYFAToolStripMenuItem
            // 
            this.aNASAYFAToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.aNASAYFAToolStripMenuItem.Name = "aNASAYFAToolStripMenuItem";
            this.aNASAYFAToolStripMenuItem.Size = new System.Drawing.Size(90, 21);
            this.aNASAYFAToolStripMenuItem.Text = "ANA SAYFA";
            // 
            // çIKIŞYAPToolStripMenuItem
            // 
            this.çIKIŞYAPToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.çIKIŞYAPToolStripMenuItem.Name = "çIKIŞYAPToolStripMenuItem";
            this.çIKIŞYAPToolStripMenuItem.Size = new System.Drawing.Size(79, 21);
            this.çIKIŞYAPToolStripMenuItem.Text = "ÇIKIŞ YAP";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LimeGreen;
            this.groupBox1.Controls.Add(this.cmbAkbilTipleri);
            this.groupBox1.Controls.Add(this.maskTxtAkbilNo);
            this.groupBox1.Controls.Add(this.btnKaydet);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(570, 163);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // cmbAkbilTipleri
            // 
            this.cmbAkbilTipleri.FormattingEnabled = true;
            this.cmbAkbilTipleri.Items.AddRange(new object[] {
            "Öğrenci Kart",
            "Normal Kart",
            "Anne Kart",
            "65+ Kart",
            "Öğretmen Kart",
            "Mavi Kart"});
            this.cmbAkbilTipleri.Location = new System.Drawing.Point(114, 89);
            this.cmbAkbilTipleri.Name = "cmbAkbilTipleri";
            this.cmbAkbilTipleri.Size = new System.Drawing.Size(271, 25);
            this.cmbAkbilTipleri.TabIndex = 6;
            // 
            // maskTxtAkbilNo
            // 
            this.maskTxtAkbilNo.Location = new System.Drawing.Point(114, 37);
            this.maskTxtAkbilNo.Mask = "0000000000000000";
            this.maskTxtAkbilNo.Name = "maskTxtAkbilNo";
            this.maskTxtAkbilNo.Size = new System.Drawing.Size(271, 25);
            this.maskTxtAkbilNo.TabIndex = 5;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(421, 37);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(109, 77);
            this.btnKaydet.TabIndex = 4;
            this.btnKaydet.Text = "YENİ AKBİL KAYDET";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(25, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Akbil Tip :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(29, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Akbil no :";
            // 
            // dataGridViewAkbiller
            // 
            this.dataGridViewAkbiller.AllowUserToAddRows = false;
            this.dataGridViewAkbiller.AllowUserToDeleteRows = false;
            this.dataGridViewAkbiller.AllowUserToOrderColumns = true;
            this.dataGridViewAkbiller.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAkbiller.Location = new System.Drawing.Point(12, 235);
            this.dataGridViewAkbiller.Name = "dataGridViewAkbiller";
            this.dataGridViewAkbiller.ReadOnly = true;
            this.dataGridViewAkbiller.RowTemplate.Height = 25;
            this.dataGridViewAkbiller.Size = new System.Drawing.Size(570, 209);
            this.dataGridViewAkbiller.TabIndex = 2;
            // 
            // Akbiller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.ClientSize = new System.Drawing.Size(611, 458);
            this.Controls.Add(this.dataGridViewAkbiller);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Akbiller";
            this.Text = "Akbiller";
            this.Load += new System.EventHandler(this.FrmAkbiller_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAkbiller)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem aNASAYFAToolStripMenuItem;
        private ToolStripMenuItem çIKIŞYAPToolStripMenuItem;
        private GroupBox groupBox1;
        private ComboBox cmbAkbilTipleri;
        private MaskedTextBox maskTxtAkbilNo;
        private Button btnKaydet;
        private Label label2;
        private Label label1;
        private DataGridView dataGridViewAkbiller;
    }
}