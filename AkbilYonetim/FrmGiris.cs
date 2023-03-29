using System.Data.SqlClient;

namespace AkbilYonetim
{
    public partial class FrmGiris : Form
    {
        public string Email { get; set; } // Kay�t ol formunda kay�t olan kullan�c�n�n emaili buraya gelsin
        public FrmGiris()
        {
            InitializeComponent();
        }
        private void FrmGiris_Load(object sender, EventArgs e)
        {

            txtEmail.TabIndex = 1;
            txtSifre.TabIndex = 2;
            checkBoxHatirla.TabIndex = 3;
            btnGirisYap.TabIndex = 4;
            btnKayitOl.TabIndex = 5;

            txtSifre.PasswordChar = '*';

            if (Email != null)
            {
                txtEmail.Text = Email;
            }
            if (Properties.Settings1.Default.BeniHatirla == true)
            {
                txtEmail.Text = Properties.Settings1.Default.KullaniciEmail;
                txtSifre.Text = Properties.Settings1.Default.KullaniciSifre;
                checkBoxHatirla.Checked = true;

            }

        }
        private void btnKayitOl_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmKayitOl frm = new FrmKayitOl();
            frm.Show();
        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            GirisYap();
        }

        private void GirisYap()
        {
            try
            {
                //1) Email ve �ifre textboxlar� dolu mu?

                if (string.IsNullOrEmpty(txtEmail.Text) || string.IsNullOrEmpty(txtSifre.Text))
                {
                    MessageBox.Show("Bilgileri eksiksiz giriniz !", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }

                //2) Girdi�i email ve �ifre veritaban�nda mevcut mu?

                string baglantiCumlesi = "Server=DESKTOP-E30TBPJ;Database=AKBILDB;Trusted_Connection=True;";
                SqlConnection baglanti = new SqlConnection(baglantiCumlesi);
                string sorgu = $"select * from Kullanicilar where Email = '{txtEmail.Text.Trim()}' " +
                    $"and Parola = '{txtSifre.Text.Trim()}'";
                SqlCommand komut = new SqlCommand(sorgu, baglanti);
                baglanti.Open();
                SqlDataReader okuyucu = komut.ExecuteReader();
                if (!okuyucu.HasRows) //DE��LSE yanl�� giri� mesaj� verecek
                {
                    MessageBox.Show("Email ya da �ifrenizi do�ru girdi�inize emin olunuz !", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    baglanti.Close();
                    return;
                }
                else
                {
                    while (okuyucu.Read())
                    {
                        MessageBox.Show($"Ho�geldiniz {okuyucu["Ad"].ToString().ToUpper()} " +
                            $"{okuyucu["Soyad"].ToString().ToUpper()}");
                        Properties.Settings1.Default.KullaniciId = (int)okuyucu["Id"];
                    }
                    baglanti.Close();

                    //E�er email -�ifre do�ruysa
                    //E�er beni Hat�rla'y� t�klad�ysa ?? Bilgileri hat�rlanacak...
                    //ho�geldiniz yazacak ve anasayfa formuna y�nlendirilecek

                    if (checkBoxHatirla.Checked)
                    {
                        Properties.Settings1.Default.BeniHatirla = true;
                        Properties.Settings1.Default.KullaniciEmail = txtEmail.Text.Trim();
                        Properties.Settings1.Default.KullaniciSifre = txtSifre.Text.Trim();
                        Properties.Settings1.Default.Save();
                    }
                    else
                    {
                        Properties.Settings1.Default.BeniHatirla = false;
                        Properties.Settings1.Default.KullaniciEmail = "";
                        Properties.Settings1.Default.KullaniciSifre = "";
                        Properties.Settings1.Default.Save();
                    }
                    this.Hide();
                    FrmAnaSayfa frmAnaSayfa = new FrmAnaSayfa();
                    frmAnaSayfa.Show(); 
                }

            }
            catch (Exception hata)
            {
                //Dipnot : exceptionlar kullan�c�ya g�sterilmez, loglan�r. Biz �u an geli�tirme yapt���m�z i�in yazd�k
                MessageBox.Show("Beklenmedik bir sorun olu�tu !" + hata.Message);
            }
        }


        private void txtSifre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter)) //bas�lan tu� enter ise giri� yapacak
            {
                GirisYap();
            }
        }
    }
}