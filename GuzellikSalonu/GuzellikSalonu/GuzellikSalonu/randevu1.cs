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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace GuzellikSalonu
{
    public partial class randevu1 : Form
    {
        public randevu1()
        {
            InitializeComponent();
        }
        SqlConnection baglanti;

        private void randevu1_Load(object sender, EventArgs e)
        {
            baglanti = new SqlConnection("Data Source = /localhost/; Initial Catalog = db_salon; Integrated Security = True");
            DataTable tablo = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From islem", baglanti);
            da.Fill(tablo);
            comboBox1.ValueMember = "islem";
            comboBox1.DisplayMember = "islem_adi";
            comboBox1.DataSource = tablo;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand komut;
            SqlConnection baglanti = new SqlConnection("Data Source=/localhost/;Initial Catalog=db_salon;Integrated Security=True");
            string sorgu = "INSERT INTO randevu(islem,personel,tarih,saat)VALUES(@islem,@personel,@tarih,@saat)";
            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@islem", comboBox1.Text);
            komut.Parameters.AddWithValue("@personel", comboBox2.Text);
            komut.Parameters.AddWithValue("@tarih", dateTimePicker1.Value.Date);
            komut.Parameters.AddWithValue("@saat", maskedTextBox1.Text);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Randevunuz Oluştu.");
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex != -1)
            {
                DataTable personel_tab = new DataTable();
                SqlDataAdapter p_da = new SqlDataAdapter("Select * from personel where islemi=" + comboBox1.SelectedValue, baglanti);
                p_da.Fill(personel_tab);
                comboBox2.ValueMember = "personel_id";
                comboBox2.DisplayMember = "personel_adi";
                comboBox2.DataSource = personel_tab;


            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            randevu2 r2 = new randevu2();
            r2.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }
    }
}
