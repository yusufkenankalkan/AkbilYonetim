using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AkbilYonetim
{
    public partial class FrmKayitOl : Form
    {
        public FrmKayitOl()
        {
            InitializeComponent();
        }

        private void FrmKayitOl_Load(object sender, EventArgs e)
        {
            #region Ayarlar
            txtSifre.PasswordChar = '*';
            dtpDogumTarihi.MaxDate = new DateTime(2016, 1, 1);
            dtpDogumTarihi.Value = new DateTime(2016, 1, 1);
            dtpDogumTarihi.Format = DateTimePickerFormat.Short;

            #endregion
        }

        private void btnKayitOl_Click(object sender, EventArgs e)
        {
            try
            {
                //1) Emailden kayıtlı biri zaten var mı ?
                string baglantiCumlesi = "Server=DESKTOP-E30TBPJ;Database=AKBILDB;Trusted_Connection=True;";

                SqlConnection baglanti = new SqlConnection(); //baglanti nesnesi
                baglanti.ConnectionString = baglantiCumlesi; // nereye bağlanacak
                SqlCommand komut = new SqlCommand(); // komut nesnesi türettik
                komut.Connection = baglanti; // komutun hangi bağlantıda çalışacağını atadık
                komut.CommandText = $"select * from Kullanicilar (nolock) where Email = '{txtEmail.Text.Trim()}' "; // sql komutu
                baglanti.Open();

                SqlDataReader okuyucu = komut.ExecuteReader(); // çalıştır
                if (okuyucu.HasRows) // Satır var mı ?
                {
                    MessageBox.Show("Bu email zaten sisteme kayıtlıdır", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }
                baglanti.Close();

                //2) Emaili daha önce kayıtlı değilse KAYIT OLACAK
                if (string.IsNullOrEmpty(txtIsim.Text) || string.IsNullOrEmpty(txtSoyisim.Text) || string.IsNullOrEmpty(txtEmail.Text) || string.IsNullOrEmpty(txtSifre.Text))
                {
                    MessageBox.Show("Bilgileri eksiksiz giriniz !", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }
                string insertSQL = $"insert into Kullanicilar (EklenmeTarihi,Email,Parola,Ad,Soyad,DogumTarihi) values" +
                    $" ('{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}','{txtEmail.Text.Trim()}','{txtSifre.Text.Trim()}','{txtIsim.Text.Trim()}','{txtSoyisim.Text.Trim()}','{dtpDogumTarihi.Value.ToString("yyyyMMdd")}')";
                baglanti.ConnectionString = baglantiCumlesi;
                SqlCommand eklemeKomut = new SqlCommand(insertSQL, baglanti);
                baglanti.Open();
                int rowsEffected = eklemeKomut.ExecuteNonQuery(); //insert update delete için kullanılır
                if (rowsEffected > 0)
                {
                    MessageBox.Show("Kayıt Eklendi !", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    GirisFormunaGit();
                }
                else
                {
                    MessageBox.Show("Kayıt Eklenemedi !", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                baglanti.Close();

            }
            catch (Exception ex)
            {
                // ex log.txt'ye yazılacak(loglama)
                MessageBox.Show("Beklenmedik bir hata oluştu ! Lütfen tekrar deneyiniz !");
            }
        }

        private void GirisFormunaGit()
        {
            FrmGiris frmGiris = new FrmGiris();
            frmGiris.Email = txtEmail.Text.Trim();
            this.Hide();
            frmGiris.Show();
        }

        private void FrmKayitOl_FormClosed(object sender, FormClosedEventArgs e)
        {
            GirisFormunaGit();
        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            GirisFormunaGit();
        }

        private void txtIsim_TextChanged(object sender, EventArgs e)
        {
            txtIsim.Text = txtIsim.Text.ToUpper();
            txtIsim.SelectionStart = txtIsim.Text.Length;
        }

        private void txtSoyisim_TextChanged(object sender, EventArgs e)
        {
            txtSoyisim.Text = txtSoyisim.Text.ToUpper();
            txtSoyisim.SelectionStart = txtSoyisim.Text.Length;
        }
    }
}
