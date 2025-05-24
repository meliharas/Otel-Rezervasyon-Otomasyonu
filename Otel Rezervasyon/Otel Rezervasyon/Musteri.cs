namespace Otel_Rezervasyon
{
    public class Musteri
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string TC { get; set; }
        public string Telefon { get; set; }
        public string Email { get; set; }

        public Musteri(string ad, string soyad, string tc, string telefon, string email)
        {
            Ad = ad;
            Soyad = soyad;
            TC = tc;
            Telefon = telefon;
            Email = email;
        }
    }
}
