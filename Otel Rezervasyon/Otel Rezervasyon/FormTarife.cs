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
    public partial class FormTarife : Form
    {
        SqlConnection baglanti = Veritabani.Baglanti();
        public FormTarife()
        {
            InitializeComponent();
        }


        private void FormTarife_Load(object sender, EventArgs e)
        {
           // varsayılan seçim
        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (cmbTip.Text != "" && txtUcret.Text != "")
            {
                try
                {
                    baglanti.Open();
                    SqlCommand cmd = new SqlCommand("update Tarife set  Ucret=@ucret  where TarifeID=(select TarifeID from Tarife where Tip=@tip)", baglanti);
                    cmd.Parameters.AddWithValue("@tip", cmbTip.Text);
                    cmd.Parameters.AddWithValue("@ucret", decimal.Parse(txtUcret.Text));
                    cmd.ExecuteNonQuery();
                    baglanti.Close();
                    cmd.Parameters.Clear();

                    MessageBox.Show("Tarife başarıyla eklendi.");
                    txtUcret.Clear();
                    cmbTip.SelectedIndex = 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                    baglanti.Close();
                }
            }
            else
            {
                MessageBox.Show("Lütfen tüm alanları doldurun.");
            }
        }
    }
}

