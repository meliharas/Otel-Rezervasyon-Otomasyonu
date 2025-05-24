using System;

namespace Otel_Rezervasyon
{
    public class Rezervasyon
    {
        public int MusteriID { get; set; }
        public int OdaID { get; set; }
        public DateTime GirisTarihi { get; set; }
        public DateTime CikisTarihi { get; set; }
        public decimal Ucret { get; set; }
        public decimal ToplamTutar { get; set; }

        public Rezervasyon(int musteriID, int odaID, DateTime giris, DateTime cikis, decimal ucret, decimal toplamTutar)
        {
            MusteriID = musteriID;
            OdaID = odaID;
            GirisTarihi = giris;
            CikisTarihi = cikis;
            Ucret = ucret;
            ToplamTutar = toplamTutar;
        }
    }
}
