
using System;
using System.Collections.Generic;
using Otel_Rezervasyon;
using System.Data.SqlClient;

public class MusteriManager : BaseManager
{
    public static int ToplamMusteri = 0;


    public void MusteriEkle(Musteri m)
    {
        // Burada ister veritabanýna baðlan, ister listeye ekle, ister logla
        Log("Yeni musteri eklendi: " + m.Ad + " " + m.Soyad); 


        // Veritabaný baðlantýsý örneði
        using (SqlConnection baglanti = Veritabani.Baglanti())
        {
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO Musteri (Ad, Soyad, TC, Telefon, Email) VALUES (@ad, @soyad, @tc, @tel, @email)", baglanti);

            cmd.Parameters.AddWithValue("@ad", m.Ad);
            cmd.Parameters.AddWithValue("@soyad", m.Soyad);
            cmd.Parameters.AddWithValue("@tc", m.TC);
            cmd.Parameters.AddWithValue("@tel", m.Telefon);
            cmd.Parameters.AddWithValue("@email", m.Email);
            cmd.ExecuteNonQuery();

        }
    }

    public MusteriManager()
    {
        ToplamMusteri++;
    }

    public override void Log(string mesaj)
    {
        Console.WriteLine("LOG: " + mesaj);
    }

    public void Ekle()
    {
        Log("Musteri eklendi.");
    }

    public void Listele()
    {
        Log("Musteriler listelendi.");
    }

    // Method Overloading
    public void Ara(string kriter)
    {
        Log("Kriterle arama yapildi: " + kriter);
    }

    public void Ara(string ad, string tc)
    {
        Log($"Ad ve TC ile arama yapildi: {ad} - {tc}");
    }
}
