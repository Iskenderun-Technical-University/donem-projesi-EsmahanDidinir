using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace GuzellikSalonu
{
    public partial class kayit : Form
    {
        SqlConnection baglanti;
        SqlCommand komut;
        SqlDataAdapter da;

        public kayit()
        {
            InitializeComponent();
        }
        


        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void kayit_Load(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)

        {
            SqlConnection baglanti = new SqlConnection("Data Source=/localhost/;Initial Catalog=db_salon;Integrated Security=True");
            string sorgu = "INSERT INTO kayit(ad,numara,kullanici_adi,sifre)VALUES(@ad,@numara,@kullanici_adi,@sifre)";
            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@ad", textBox1.Text);
            komut.Parameters.AddWithValue("@numara", textBox2.Text);
            komut.Parameters.AddWithValue("@kullanici_adi", textBox3.Text);
            komut.Parameters.AddWithValue("@sifre", textBox4.Text);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("ÜYE EKLENDİ");
        }
    }
}
