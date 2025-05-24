namespace Otel_Rezervasyon
{
    public class Oda
    {
        private string odaNo;
        private string kat;
        private string tip;
        private string durum;

        public string OdaNo { get => odaNo; set => odaNo = value; }
        public string Kat { get => kat; set => kat = value; }
        public string Tip { get => tip; set => tip = value; }
        public string Durum { get => durum; set => durum = value; }

        public Oda(string odaNo, string kat, string tip, string durum)
        {
            this.odaNo = odaNo;
            this.kat = kat;
            this.tip = tip;
            this.durum = durum;
        }
    }
}
