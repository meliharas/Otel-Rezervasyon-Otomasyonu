using System.Windows.Forms;

namespace Otel_Rezervasyon
{
    public interface IRezervasyonIslemleri
    {
        void RezervasyonYap(Rezervasyon r);
        void RezervasyonIptal(int rezervasyonID);
        void RezervasyonListele(DataGridView dgv);

    }
}
