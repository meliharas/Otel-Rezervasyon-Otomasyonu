namespace Otel_Rezervasyon
{
    public interface IOdaIslemleri
    {
        void OdaEkle(Oda o);  
        void OdaSil();
        void OdaGuncelle();
        void OdaListele();
        void OdaAra(int odaNo);
    }
}
