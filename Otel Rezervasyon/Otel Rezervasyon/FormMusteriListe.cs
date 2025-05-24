using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Otel_Rezervasyon
{
    public partial class FormMusteriListe : Form
    {
        public FormMusteriListe()
        {
            InitializeComponent();
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = Veritabani.Baglanti();
            baglanti.Open();

            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Musteri", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            baglanti.Close();
        }
    }
}
