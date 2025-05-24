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
using Otel_Rezervasyon;



namespace Otel_Rezervasyon
{
    public partial class FormOda : Form

    {
        OdaManager odaManager = new OdaManager();

        SqlConnection baglanti = Veritabani.Baglanti();

        public FormOda()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (txtOdaNo.Text == "" || txtKat.Text == "" || cmbTip.SelectedItem == null || cmbDurum.SelectedItem == null)
            {
                MessageBox.Show("Tüm alanları doldur.");
                return;
            }

            // OOP: kapsüllenmiş nesne oluşturuluyor
            Oda yeniOda = new Oda(
                txtOdaNo.Text,
                txtKat.Text,
                cmbTip.SelectedItem.ToString(),
                cmbDurum.SelectedItem.ToString()
            );

            // OdaManager üzerinden ekleme işlemi
            odaManager.OdaEkle(yeniOda);

            MessageBox.Show("Oda başarıyla eklendi!");
        }

    }
    
        }
    




