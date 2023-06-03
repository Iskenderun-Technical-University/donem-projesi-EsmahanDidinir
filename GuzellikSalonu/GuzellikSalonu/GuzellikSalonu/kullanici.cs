using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace GuzellikSalonu
{
     class kullanici
    {
        SqlConnection baglanti = new SqlConnection("Data Source =/localhost/; Initial Catalog = db_salon; Integrated Security = True");
        SqlCommand komut;
        SqlDataReader read;
        randevu1 yeni = new randevu1();

        public SqlDataReader kullanicigiris(TextBox kullanici_adi, TextBox sifre)
        {
            baglanti.Open();
            komut = new SqlCommand();
            komut.Connection = baglanti;
            komut.CommandText = "Select * from kayit where kullanici_adi='" + kullanici_adi.Text + "'";
            read = komut.ExecuteReader();
            if(read.Read()==true)
            {
                if (sifre.Text == read["sifre"].ToString())
                {
                    MessageBox.Show("GİRİŞ BAŞARILI");
                    yeni.ShowDialog();
                   
                }
                else
                {
                    MessageBox.Show("ŞİFRE HATALI", "Hata1");

                }
            }
            else
            {
                MessageBox.Show("Bilgileri Kontrol Edin", "Hata2");
            }
            baglanti.Close();
            return read;

        }
       
    }
}
