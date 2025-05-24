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
    public partial class FormKullaniciPanel : Form
    {
        public FormKullaniciPanel()
        {
            InitializeComponent();
        }

        private void btnMusteriEkle_Click(object sender, EventArgs e)
        {
            new FormMusteri().Show();
        }
        private void btnRezervasyonEkle_Click(object sender, EventArgs e)
        {
            new FormRezervasyon().Show();
        }

        private void FormKullaniciPanel_FormClosing(object sender, FormClosingEventArgs e)
        {
            new FormGiris().Show();
        }
    }
}
