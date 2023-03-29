﻿using System;
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
    public partial class FrmAyarlar : Form
    {
        public FrmAyarlar()
        {
            InitializeComponent();
        }

        private void FrmAyarlar_Load(object sender, EventArgs e)
        {

            txtSifre.PasswordChar = '*';
            dtpDogumTarihi.MaxDate = new DateTime(2016, 1, 1);
            dtpDogumTarihi.Value = new DateTime(2016, 1, 1);
            dtpDogumTarihi.Format = DateTimePickerFormat.Short;

            KullanicininBilgileriniGetir();
        }

        private void KullanicininBilgileriniGetir()
        {
            try
            {
                if (string.IsNullOrEmpty(Properties.Settings1.Default.KullaniciEmail))
                {
                    MessageBox.Show("Giriş yapmadan bu sayfaya ulaşamazsınız !");
                    return;
                }
                else
                {
                    string baglantiCumlesi = "Server=DESKTOP-E30TBPJ;Database=AKBILDB;Trusted_Connection=True;";
                    SqlConnection baglanti = new SqlConnection(baglantiCumlesi);
                    SqlCommand komut = new SqlCommand($"select * from Kullanicilar where Email = '{Properties.Settings1.Default.KullaniciEmail}'" +
                        $" and Parola = '{Properties.Settings1.Default.KullaniciSifre}'", baglanti);
                    baglanti.Open();
                    SqlDataReader okuyucu = komut.ExecuteReader();
                    if (okuyucu.HasRows)
                    {
                        while (okuyucu.Read())
                        {
                            txtEmail.Text = okuyucu["Email"].ToString();
                            txtEmail.Enabled = false;
                            txtIsim.Text = okuyucu["Ad"].ToString().ToUpper();
                            txtSoyisim.Text = okuyucu["Soyad"].ToString().ToUpper();
                            dtpDogumTarihi.Value = Convert.ToDateTime(okuyucu["DogumTarihi"]);
                        }
                    }
                    baglanti.Close();
                }
            }
            catch (Exception hata)
            {

                MessageBox.Show("Beklenmedik bir sorun oluştu !" + hata.Message);
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                string baglantiCumlesi = "Server=DESKTOP-E30TBPJ;Database=AKBILDB;Trusted_Connection=True;";
                SqlConnection baglanti = new SqlConnection(baglantiCumlesi);
                string sorgu = $"update Kullanicilar set " +
                    $"Ad='{txtIsim.Text.Trim()}', " +
                    $"Soyad = '{txtSoyisim.Text.Trim()}', " +
                    $"DogumTarihi = '{dtpDogumTarihi.Value.ToString("yyyyMMdd")}' ";
                if (!string.IsNullOrEmpty(txtSifre.Text))
                {
                    sorgu += $",Parola = '{txtSifre.Text.Trim()}'";
                }

                sorgu += $" where Email = '{txtEmail.Text.Trim()}'";

                SqlCommand komut = new SqlCommand(sorgu, baglanti);
                baglanti.Open();
                if (komut.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Bilgiler GÜNCELLENDİ ! ");
                    KullanicininBilgileriniGetir();
                }
                else
                {

                }
            }
            catch (Exception hata)
            {

                MessageBox.Show("Güncelleme BAŞARISIZDIR !" + hata.Message);
            }
        }
    }
}
