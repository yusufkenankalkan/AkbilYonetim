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
    public partial class FrmAkbiller : Form
    {
        public FrmAkbiller()
        {
            InitializeComponent();
        }

        string baglantiCumlesi = "Server=DESKTOP-E30TBPJ;Database=AKBILDB;Trusted_Connection=True;";
        private void FrmAkbiller_Load(object sender, EventArgs e)
        {
            cmbAkbilTipleri.Text = "Akbil tipi seçiniz...";
            cmbAkbilTipleri.SelectedIndex = -1;
            DataGridViewiDoldur();
        }


        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbAkbilTipleri.SelectedIndex < 0)
                {
                    MessageBox.Show("Lütfen eklemek istediğiniz akbil türünü seçiniz ! ");
                    return;
                }

                SqlConnection baglanti = new SqlConnection(baglantiCumlesi);
                SqlCommand komut = new SqlCommand();
                komut.Connection = baglanti;
                komut.CommandType = CommandType.Text;

                komut.CommandText = "insert into Akbiller (AkbilNo,EklenmeTarihi,AkbilTipi,Bakiye,AkbilSahibiId,VizelendigiTarih) " +
                    "values" +
                    "(@akblNo,@ektrh,@tip,@bakiye,@sahibi,null)";

                komut.Parameters.AddWithValue("@akblNo", maskTxtAkbilNo.Text);
                komut.Parameters.AddWithValue("@ektrh", DateTime.Now);
                komut.Parameters.AddWithValue("@tip", cmbAkbilTipleri.SelectedItem);
                komut.Parameters.AddWithValue("@bakiye", 0);
                komut.Parameters.AddWithValue("@sahibi", Properties.Settings1.Default.KullaniciId);


                baglanti.Open();
                if (komut.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Akbiliniz sisteme eklendi !");
                    maskTxtAkbilNo.Clear();
                    cmbAkbilTipleri.SelectedIndex = -1;
                    cmbAkbilTipleri.Text = "Akbil türünü seçiniz...";
                    DataGridViewiDoldur();
                }
                else
                {
                    MessageBox.Show("Akbiliniz sisteme EKLENEMEDİ !");
                }
            }
            catch (Exception hata)
            {
                MessageBox.Show("Beklenmedik bir hata oluştu !" + hata.Message);
            }
        }

        private void DataGridViewiDoldur()
        {
            try
            {
                SqlConnection connection = new SqlConnection(baglantiCumlesi);
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = $"select * from Akbiller where AkbilSahibiId=@sahibi";
                command.Parameters.AddWithValue("@sahibi", Properties.Settings1.Default.KullaniciId);
                // Data table
                // DataSet --> içinde birden çok datatable barındırır
                // SqlDataAdapter --> adaptör sorgu sonucundaki verileri Datatable/Dataset DOLDURUR (fill)

                //SqlDataAdapter adp = new SqlDataAdapter(command);

                SqlDataAdapter adp = new SqlDataAdapter();
                adp.SelectCommand = command;
                DataTable dt = new DataTable();
                connection.Open();
                adp.Fill(dt);
                connection.Close();
                dataGridViewAkbiller.DataSource = dt;

                // Bazı kolonlar gizlensin
                dataGridViewAkbiller.Columns["AkbilSahibiId"].Visible = false;
                dataGridViewAkbiller.Columns["VizelendigiTarih"].HeaderText = "Vizelendiği Tarih";
                dataGridViewAkbiller.Columns["VizelendigiTarih"].Width = 200;
            }
            catch (Exception hata)
            {
                MessageBox.Show("Akbilleri listeleyemedim !" + hata.Message);
            }
        }

    }
}
