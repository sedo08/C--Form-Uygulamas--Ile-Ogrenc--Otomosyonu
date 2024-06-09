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


namespace Ogrenci_Kart
{
    public partial class Form1 : Form
    {
        SqlConnection baglanti;
        SqlCommand komut;
        SqlDataAdapter da;
        public Form1()
        {
            InitializeComponent();
            this.IsMdiContainer = true;  //bu form açmak için verilen izin
        }

        void OgrenciGetir()
        {
            baglanti = new SqlConnection("server=SEDATKUBA\\SQLEXPRESS;Initial Catalog=Okul; Integrated security=SSPI");// KENDİ BİLGİSAYARINIZA AİT SERVER ADINI GİRMEYİ UNUTMAYIN (SE)
            baglanti.Open();
            da = new SqlDataAdapter("SELECT * FROM Ogrencii", baglanti);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }   

        private void Form1_Load(object sender, EventArgs e)
        {
            OgrenciGetir();
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            tbxıd.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            tbxNo.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            tbxAd.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            tbxSoyad.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            tbxProgram.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            tbxDurum.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            tbxKayıt.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            tbxTc.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            string sorgu = "INSERT INTO ogrencii(Numara,Ad,Soyad,Prg,Durum,KayitYili,TCKNo) VALUES (@Numara,@Ad,@Soyad,@Prg,@Durum,@KayitYili,@TCKNo)";
            komut = new SqlCommand(sorgu,baglanti);
            komut.Parameters.AddWithValue("@Numara", tbxNo.Text);
            komut.Parameters.AddWithValue("@Ad", tbxAd.Text);
            komut.Parameters.AddWithValue("@Soyad", tbxSoyad.Text);
            komut.Parameters.AddWithValue("@Prg", tbxProgram.Text);
            komut.Parameters.AddWithValue("@Durum", tbxDurum.Text);
            komut.Parameters.AddWithValue("@KayitYili", tbxKayıt.Text);
            komut.Parameters.AddWithValue("@TCKNo", tbxTc.Text);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            OgrenciGetir();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            string sorgu = "DELETE FROM ogrencii WHERE Id=@Id";
            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@ıd",Convert.ToInt32(tbxıd.Text));
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            OgrenciGetir();


        }

        private void btnformac_Click(object sender, EventArgs e)
        {
            Form2 form2= new Form2(); //açılacak olan formun kodu 
            //form2.MdiParent = this;   // bu   foorm parent olarak veriyoruz
            form2.Show(); //form iki bu kodla açılıyor
        }

        private void btnınsert_Click(object sender, EventArgs e)
        {
            string sorgu = "UPDATE  ogrencii SET  Numara=@Numara,Ad=@Ad,Soyad=@Soyad,Prg=@Prg,Durum=@Durum,KayitYili=@KayitYili,TCKNo=@TCKNo WHERE Id=@Id";
            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@Id",Convert.ToInt32(tbxıd.Text));
            komut.Parameters.AddWithValue("@Numara",tbxNo.Text);
            komut.Parameters.AddWithValue("@Ad", tbxAd.Text);
            komut.Parameters.AddWithValue("@Soyad",tbxSoyad.Text);
            komut.Parameters.AddWithValue("@Prg",tbxProgram.Text);
            komut.Parameters.AddWithValue("@Durum",tbxDurum.Text);
            komut.Parameters.AddWithValue("@KayitYili", tbxKayıt.Text);
            komut.Parameters.AddWithValue("@TCKNo", tbxTc.Text);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            OgrenciGetir();



        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            using (SqlConnection baglanti = new SqlConnection("server=SEDATKUBA\\SQLEXPRESS;Initial Catalog=Okul;Integrated Security=SSPI"))
            {
                SqlCommand komut = new SqlCommand("SELECT * FROM ogrencii", baglanti);
                baglanti.Open();

                using (SqlDataReader dr = komut.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        string ogrenciBilgisi = dr["Numara"].ToString() + " - " + dr["Ad"].ToString() + " " + dr["Soyad"].ToString();
                        listBox1.Items.Add(ogrenciBilgisi);
                    }

                }
            }
        }

    }
}
