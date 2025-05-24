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
    public partial class FormAdminPanel : Form
    {
        public FormAdminPanel()
        {
            InitializeComponent();
        }
        private void btnMusteri_Click(object sender, EventArgs e)
        {
            new FormMusteri().Show();
        }

        private void btnOda_Click(object sender, EventArgs e)
        {
            new FormOda().Show();
        }

        private void btnRezervasyon_Click(object sender, EventArgs e)
        {
            new FormRezervasyon().Show();
        }

        private void btnTarife_Click(object sender, EventArgs e)
        {
            new FormTarife().Show();
        }

        

        private void FormAdminPanel_Load(object sender, EventArgs e)
        {

        }

        private void btnKullanici_Click(object sender, EventArgs e)
        {

        }

        private void FormAdminPanel_FormClosing(object sender, FormClosingEventArgs e)
        {
            new FormGiris().Show();
          
        }
    }
}
