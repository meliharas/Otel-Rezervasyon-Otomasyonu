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
    public partial class FormAna : Form
    {
        public FormAna()
        {
            InitializeComponent();
        }

        private void btnMusteri_Click(object sender, EventArgs e)
        {
            FormMusteri frm = new FormMusteri();
            frm.Show();
        }

        private void btnMusteriListe_Click(object sender, EventArgs e)
        {
            FormMusteriListe frm = new FormMusteriListe();
            frm.Show();
        }

        private void btnOda_Click(object sender, EventArgs e)
        {
            FormOda frm = new FormOda();
            frm.Show();
        }

        private void btnOdaListe_Click(object sender, EventArgs e)
        {
            FormOdaListe frm = new FormOdaListe();
            frm.Show();
        }

        private void btnRezervasyon_Click(object sender, EventArgs e)
        {
            FormRezervasyon frm = new FormRezervasyon();
            frm.Show();
        }

        private void btnRezervasyonListe_Click(object sender, EventArgs e)
        {
            
            FormRezervasyonListe frm = new FormRezervasyonListe();
            frm.Show();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
