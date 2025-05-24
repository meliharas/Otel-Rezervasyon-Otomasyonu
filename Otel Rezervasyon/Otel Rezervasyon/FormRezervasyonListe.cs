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

namespace Otel_Rezervasyon
{
    public partial class FormRezervasyonListe : Form
    {
        SqlConnection baglanti = Veritabani.Baglanti();
        RezervasyonManager rezervasyonManager = new RezervasyonManager();
        public FormRezervasyonListe()
        {
            InitializeComponent();
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlDataAdapter da = new SqlDataAdapter(@"SELECT 
                R.RezervasyonID, 
                M.Ad + ' ' + M.Soyad AS Musteri,
                O.OdaNumarasi,
                R.GirisTarihi,
                R.CikisTarihi,
                R.Ucret,
                R.ToplamTutar
                FROM Rezervasyon R
                JOIN Musteri M ON R.MusteriID = M.MusteriID
                JOIN Oda O ON R.OdaID = O.OdaID", baglanti);

            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();
        }
        

        

        private void FormRezervasyonListe_Load_1(object sender, EventArgs e)
        {
            rezervasyonManager.RezervasyonListele(dataGridView1);
        }
    }
}