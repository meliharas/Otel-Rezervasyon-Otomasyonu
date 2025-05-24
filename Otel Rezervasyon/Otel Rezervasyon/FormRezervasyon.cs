using System;
using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Windows.Forms;
using Otel_Rezervasyon;


namespace Otel_Rezervasyon
{
    public partial class FormRezervasyon : Form
    {
        SqlConnection baglanti = Veritabani.Baglanti();
        RezervasyonManager rezervasyonManager = new RezervasyonManager();

        public FormRezervasyon()
        {
            InitializeComponent();
            MusteriGetir();
            OdaGetir();

        
        }
        bool odaYuklendi = false; // formun içinde, class seviyesinde

        private void dtpGiris_ValueChanged(object sender, EventArgs e)
        {
            UcretHesapla();
        }

        private void dtpCikis_ValueChanged(object sender, EventArgs e)
        {
         
            UcretHesapla();
        }

        private void MusteriGetir()
        {
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("SELECT MusteriID, Ad + ' ' + Soyad AS AdSoyad FROM Musteri", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmbMusteri.DataSource = dt;
            cmbMusteri.DisplayMember = "AdSoyad";
            cmbMusteri.ValueMember = "MusteriID";
            baglanti.Close();
        }
        

        private void OdaGetir()
        {
            if (baglanti.State != ConnectionState.Open)
                baglanti.Open();

            SqlDataAdapter da = new SqlDataAdapter("SELECT OdaID, OdaNumarasi FROM Oda", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);

            cmbOda.DataSource = dt;
            cmbOda.DisplayMember = "OdaNumarasi";
            cmbOda.ValueMember = "OdaID";

            cmbOda.SelectedIndex = -1; // hiçbir şey seçili değil
            odaYuklendi = true; // artık combobox hazır

            baglanti.Close();
        }


        private void UcretHesapla()
        {
            if (decimal.TryParse(txtUcret.Text, out decimal ucret))
            {
                int gun = (dtpCikis.Value.Date - dtpGiris.Value.Date).Days;
                if (gun < 1) gun = 1; // Aynı günse en az 1 gün olsun
                decimal toplam = ucret * gun;
                txtToplam.Text = toplam.ToString("0.00");
            }
            else
            {
                txtToplam.Text = "0.00"; // Ucret boşsa
            }
        }


        public void btnKaydet_Click(object sender, EventArgs e)
        {
            if (cmbMusteri.SelectedValue == null || cmbOda.SelectedValue == null || txtUcret.Text == "" || txtToplam.Text == "")
            {
                MessageBox.Show("Lütfen tüm alanları doldurun.");
                return;
            }

            // Verileri al
            int musteriID = Convert.ToInt32(cmbMusteri.SelectedValue);
            int odaID = Convert.ToInt32(cmbOda.SelectedValue);
            DateTime giris = dtpGiris.Value;
            DateTime cikis = dtpCikis.Value;
            decimal ucret = decimal.Parse(txtUcret.Text);
            decimal toplam = decimal.Parse(txtToplam.Text);

            // Rezervasyon nesnesi oluştur
            Rezervasyon yeniRez = new Rezervasyon(musteriID, odaID, giris, cikis, ucret, toplam);

            // OOP ile yönlendir
            rezervasyonManager.RezervasyonYap(yeniRez);

            MessageBox.Show("Rezervasyon başarıyla kaydedildi.");
        }
        public decimal ToplamTutar { get; set; }

        
        private void cmbOda_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!odaYuklendi || cmbOda.SelectedValue == null || cmbOda.SelectedIndex == -1)
                return;

            try
            {
                if (baglanti.State != ConnectionState.Open)
                    baglanti.Open();

                if (!int.TryParse(cmbOda.SelectedValue.ToString(), out int odaId))
                {
                    MessageBox.Show("Geçersiz oda ID");
                    return;
                }

                // Oda tipini al
                SqlCommand cmd = new SqlCommand("SELECT Tip FROM Oda WHERE OdaID = @id", baglanti);
                cmd.Parameters.AddWithValue("@id", odaId);
                string tip = cmd.ExecuteScalar()?.ToString();

                // Ücreti al
                SqlCommand cmd2 = new SqlCommand("SELECT Ucret FROM Tarife WHERE Tip = @tip", baglanti);
                cmd2.Parameters.AddWithValue("@tip", tip);
                object ucret = cmd2.ExecuteScalar();

                txtUcret.Text = ucret != null ? ucret.ToString() : "0";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
            finally
            {
                if (baglanti.State == ConnectionState.Open)
                    baglanti.Close();
            }

            UcretHesapla();
        }
    }
}

