using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Otel_Rezervasyon
{
    public partial class FormMudurPanel : Form
    {
        public FormMudurPanel()
        {
            InitializeComponent();
        }

        private void btnMusteriListele_Click(object sender, EventArgs e)
        {
            FormMusteriListe musteriListe = new FormMusteriListe();
            musteriListe.Show();
        }
        private void btnOdaListele_Click(object sender, EventArgs e)
        {
            FormOdaListe odaListe = new FormOdaListe();
            odaListe.Show();
        }
        private void btnRezervasyonListele_Click(object sender, EventArgs e)
        {
            FormRezervasyonListe rezervasyonListe = new FormRezervasyonListe();
            rezervasyonListe.Show();
        }

        private void FormMudurPanel_FormClosing(object sender, FormClosingEventArgs e)
        {
            new FormGiris().Show();
        }
    }
}
