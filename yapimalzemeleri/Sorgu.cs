using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yapimalzemeleri
{
    public class kayıtsorgu
    {
        SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-4A657RK\\SQLEXPRESS;Initial Catalog=yapimalzemeleri;Integrated Security=True");
       
        private string tc;
        public void sorgula(string _tc) //parametre gönderiyoruz
        {
            SqlCommand  komut = new SqlCommand("Select * from KullaniciTable where KullaniciTc='" + _tc + "'", baglan);
            baglan.Open();
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                tc = read[4].ToString();//4. satırdan kontrol sağlıyor.
            }
            komut.Dispose();
            read.Close();
            baglan.Close();
        }
        public string TCkm() {return tc;}

    }
}
