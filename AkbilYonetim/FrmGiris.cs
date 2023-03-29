using System.Data.SqlClient;

namespace AkbilYonetim
{
    public partial class FrmGiris : Form
    {
        public string Email { get; set; } // Kayýt ol formunda kayýt olan kullanýcýnýn emaili buraya gelsin
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
                //1) Email ve þifre textboxlarý dolu mu?

                if (string.IsNullOrEmpty(txtEmail.Text) || string.IsNullOrEmpty(txtSifre.Text))
                {
                    MessageBox.Show("Bilgileri eksiksiz giriniz !", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }

                //2) Girdiði email ve þifre veritabanýnda mevcut mu?

                string baglantiCumlesi = "Server=DESKTOP-E30TBPJ;Database=AKBILDB;Trusted_Connection=True;";
                SqlConnection baglanti = new SqlConnection(baglantiCumlesi);
                string sorgu = $"select * from Kullanicilar where Email = '{txtEmail.Text.Trim()}' " +
                    $"and Parola = '{txtSifre.Text.Trim()}'";
                SqlCommand komut = new SqlCommand(sorgu, baglanti);
                baglanti.Open();
                SqlDataReader okuyucu = komut.ExecuteReader();
                if (!okuyucu.HasRows) //DEÐÝLSE yanlýþ giriþ mesajý verecek
                {
                    MessageBox.Show("Email ya da þifrenizi doðru girdiðinize emin olunuz !", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    baglanti.Close();
                    return;
                }
                else
                {
                    while (okuyucu.Read())
                    {
                        MessageBox.Show($"Hoþgeldiniz {okuyucu["Ad"].ToString().ToUpper()} " +
                            $"{okuyucu["Soyad"].ToString().ToUpper()}");
                        Properties.Settings1.Default.KullaniciId = (int)okuyucu["Id"];
                    }
                    baglanti.Close();

                    //Eðer email -þifre doðruysa
                    //Eðer beni Hatýrla'yý týkladýysa ?? Bilgileri hatýrlanacak...
                    //hoþgeldiniz yazacak ve anasayfa formuna yönlendirilecek

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
                //Dipnot : exceptionlar kullanýcýya gösterilmez, loglanýr. Biz þu an geliþtirme yaptýðýmýz için yazdýk
                MessageBox.Show("Beklenmedik bir sorun oluþtu !" + hata.Message);
            }
        }


        private void txtSifre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter)) //basýlan tuþ enter ise giriþ yapacak
            {
                GirisYap();
            }
        }
    }
}