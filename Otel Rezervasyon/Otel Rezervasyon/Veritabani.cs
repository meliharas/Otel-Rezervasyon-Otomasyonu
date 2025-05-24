using System.Data.SqlClient;

namespace Otel_Rezervasyon
{
    static class Veritabani
    {
        public static SqlConnection Baglanti()
        {
            return new SqlConnection("Data Source=MELIH\\SQLEXPRESS;Initial Catalog=OtelRezervasyon;Integrated Security=True;");
        }
    }
}
