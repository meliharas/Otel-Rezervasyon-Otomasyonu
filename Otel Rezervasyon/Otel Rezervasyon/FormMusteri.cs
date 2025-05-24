using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Otel_Rezervasyon
{
    public partial class FormMusteri : Form
    {
        MusteriManager musteriYonetimi = new MusteriManager();

        public FormMusteri()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            // Kapsüllenmiş müşteri nesnesi oluştur
            Musteri yeniMusteri = new Musteri(
                  txtAd.Text,
                  txtSoyad.Text,
                  txtTC.Text,
                  txtTelefon.Text,
                  txtEmail.Text
                );


            // Gelişmiş versiyon: bu metodu ekleyeceğiz
            musteriYonetimi.MusteriEkle(yeniMusteri);

            MessageBox.Show("Musteri başarıyla eklendi!");
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
