using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Otel_Rezervasyon
{
    public class RezervasyonManager : BaseManager, IRezervasyonIslemleri
    {
        public static int ToplamRezervasyon = 0;

        public RezervasyonManager()
        {
            ToplamRezervasyon++;
        }

        public override void Log(string mesaj)
        {
            Console.WriteLine("LOG: " + mesaj);
        }

        public void RezervasyonYap(Rezervasyon r)
        {
            Log("Rezervasyon eklendi");

            using (SqlConnection baglanti = Veritabani.Baglanti())
            {
                baglanti.Open();

                SqlCommand cmd = new SqlCommand(@"INSERT INTO Rezervasyon 
                    (MusteriID, OdaID, GirisTarihi, CikisTarihi, Ucret, ToplamTutar) 
                    VALUES (@mid, @oid, @giris, @cikis, @ucret, @toplam)", baglanti);

                cmd.Parameters.AddWithValue("@mid", r.MusteriID);
                cmd.Parameters.AddWithValue("@oid", r.OdaID);
                cmd.Parameters.AddWithValue("@giris", r.GirisTarihi);
                cmd.Parameters.AddWithValue("@cikis", r.CikisTarihi);
                cmd.Parameters.AddWithValue("@ucret", r.Ucret);
                cmd.Parameters.AddWithValue("@toplam", r.ToplamTutar);
                cmd.ExecuteNonQuery();

                SqlCommand guncelle = new SqlCommand("UPDATE Oda SET Durum='Dolu' WHERE OdaID=@id", baglanti);
                guncelle.Parameters.AddWithValue("@id", r.OdaID);
                guncelle.ExecuteNonQuery();
            }
        }

        public void RezervasyonIptal(int rezervasyonID)
        {
            Log("Rezervasyon iptal edildi: " + rezervasyonID);
        }

        public void RezervasyonListele(DataGridView dgv)
        {
            using (SqlConnection baglanti = Veritabani.Baglanti())
            {
                baglanti.Open();

                SqlDataAdapter da = new SqlDataAdapter(@"
                    SELECT 
                        R.RezervasyonID, 
                        M.Ad + ' ' + M.Soyad AS Musteri,
                        O.OdaNumarasi,
                        R.GirisTarihi, 
                        R.CikisTarihi, 
                        R.Ucret, 
                        R.ToplamTutar
                    FROM Rezervasyon R
                    JOIN Musteri M ON R.MusteriID = M.MusteriID
                    JOIN Oda O ON R.OdaID = O.OdaID
                ", baglanti);

                DataTable dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;
            }
        }
    }
}
