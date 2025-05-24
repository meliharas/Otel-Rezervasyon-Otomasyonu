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
    public partial class FormGiris : Form
    {
        public FormGiris()
        {
            InitializeComponent();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = Veritabani.Baglanti();
            baglanti.Open();

            SqlCommand cmd = new SqlCommand("SELECT Rol FROM Kullanici WHERE KullaniciAdi = @ad AND Sifre = @sifre", baglanti);
            cmd.Parameters.AddWithValue("@ad", txtKullaniciAdi.Text);
            cmd.Parameters.AddWithValue("@sifre", txtSifre.Text);
            object rol = cmd.ExecuteScalar();
            baglanti.Close();

            if (rol == null)
            {
                MessageBox.Show("Kullanıcı adı ya da şifre yanlış.");
                return;
            }

            string kullaniciRol = rol.ToString();
            MessageBox.Show("Rol: " + kullaniciRol); // Test için

            if (kullaniciRol == "admin")
            {
                new FormAdminPanel().Show();
            }
            else if (kullaniciRol == "mudur")
            {
                new FormMudurPanel().Show();
            }
            else if (kullaniciRol == "personel")
            {
                new FormKullaniciPanel().Show();
            }
            else
            {
                MessageBox.Show("Bilinmeyen kullanıcı rolü.");
            }


            this.Hide();

        }

        private void FormGiris_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }

        private void FormGiris_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}