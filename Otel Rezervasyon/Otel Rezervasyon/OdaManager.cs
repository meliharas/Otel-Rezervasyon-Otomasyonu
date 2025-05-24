using System;
using System.Data.SqlClient;
using Otel_Rezervasyon;
namespace Otel_Rezervasyon
{
    public class OdaManager : BaseManager, IOdaIslemleri
    {
        public static int ToplamOda = 0;

        public OdaManager()
        {
            ToplamOda++;
        }

        public override void Log(string mesaj)
        {
            Console.WriteLine("LOG: " + mesaj);
        }

        public void OdaEkle(Oda o)
        {
            Log("Oda eklendi: " + o.OdaNo);

            using (SqlConnection baglanti = Veritabani.Baglanti())
            {
                baglanti.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Oda (OdaNumarasi, Kat, Tip, Durum) VALUES (@no, @kat, @tip, @durum)", baglanti);
             
                cmd.Parameters.AddWithValue("@no", o.OdaNo);
                cmd.Parameters.AddWithValue("@kat", o.Kat);
                cmd.Parameters.AddWithValue("@tip", o.Tip);
                cmd.Parameters.AddWithValue("@durum", o.Durum);
                cmd.ExecuteNonQuery();
            }
        }

        public void OdaSil() => Log("Oda silindi.");
        public void OdaGuncelle() => Log("Oda güncellendi.");
        public void OdaListele() => Log("Oda listelendi.");
        public void OdaAra(int odaNo) => Log("Oda arandi: " + odaNo);
    }
}
