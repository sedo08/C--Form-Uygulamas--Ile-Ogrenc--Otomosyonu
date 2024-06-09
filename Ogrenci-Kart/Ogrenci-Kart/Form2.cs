using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ogrenci_Kart
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        float finalyuzde, vizeyuzde, raporyuzde, tabloyuzde;
        float final, vize, rapor, tablo;

        private void btnoto_Click(object sender, EventArgs e)
        {
            finalorttbx.Text = "40";
            vizeorttbx.Text = "24";
            rapororttbx.Text = "18";
            tabloorttbx.Text = "18";
        }

        float finalsonuc, vizesonuc, raporsonuc, tablosonuc;

        private void Form2_Load(object sender, EventArgs e)
        {
            btnDersGoster.Visible = false;
            lblNotGiriniz.Visible= false;

        }

        float sonuc;

        private void button1_Click(object sender, EventArgs e)
        {
            if(rapororttbx.Text == "" || raportxtbox.Text== "")
            {
                rapororttbx.Text = "0";
                raportxtbox.Text = "0";
            }

            if (tabloorttbx.Text== "" || tablotxtboox.Text == "")
            {
                tabloorttbx.Text = "0";
                tablotxtboox.Text = "0";
            }

            lblfinaltxt.Text = "Final Etki Oranınız: " + finalorttbx.Text;
            lblvizetxt.Text = "Vize Etki Oranız: " +  vizeorttbx.Text;
            lblraportxt.Text = "Rapor Etki Oranız: " +  rapororttbx.Text;
            lbltablotxt.Text = "Tablo Etki Oranınız: " + tabloorttbx.Text;

            finalyuzde= Convert.ToInt32(finalorttbx.Text);
            vizeyuzde = Convert.ToInt32(vizeorttbx.Text);
            raporyuzde = Convert.ToInt32(rapororttbx.Text);
            tabloyuzde = Convert.ToInt32(tabloorttbx.Text);

            final = Convert.ToInt32(finaltxtbox.Text);
            vize = Convert.ToInt32(vizetxtbox.Text);
            rapor = Convert.ToInt32(raportxtbox.Text);
            tablo = Convert.ToInt32(tablotxtboox.Text);

            finalsonuc = finalyuzde * final / 100;
            vizesonuc = vizeyuzde * vize / 100;
            raporsonuc = raporyuzde * rapor / 100;
            tablosonuc = tabloyuzde * tablo / 100;


            sonuc = finalsonuc + vizesonuc + raporsonuc + tablosonuc;


            finalvizeraportablo.Text = "Final Ortalaması:" + finalsonuc + "  vize Ortalamanız:"   + vizesonuc + "  Rapor Ortalamanız:" + raporsonuc + "  Tablo Ortalamanız:" + tablosonuc;

            lblsonuc.Text ="Ortalamanız :" + sonuc;


        }




        // değerleri burdan itibaren oluşturuyorm (SK)
        int ders;



        string dersler;



        int sayac = 1;

        private void listbox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void btnkacdersvar_Click(object sender, EventArgs e) // 2. formda yapılan not hesaplama kısmı bu taraftan itibaren yapılıyor dikat edelim (Sedat Kuba)
        {
            ders = Convert.ToInt32(kacderstbx.Text);
            lblkacdersvar.Text = ders.ToString()+ " Dersiniz Var :)";

        }


        private void btnderskayıt_Click(object sender, EventArgs e)
        {
            if(kacderstbx.Text=="")
            {
                MessageBox.Show("Lütfen Öncelikle Kaç Dersinizin Olduğunu Belirtiniz.","HATA", MessageBoxButtons.OK,MessageBoxIcon.Stop);



            }
            else
            {

                btnDersGoster.Visible = true;
                btnderskayıt.Visible = false;
                lblNotGiriniz.Visible = true;
                LBLDERSGİRİNİZ.Visible = false;

                lblDersEsitleme.Text = sayac.ToString();

                if (derskayıttbx.Text =="")
                {
                    derskayıttbx.Text = "---";
                    
                }


                dersler = Convert.ToString(derskayıttbx.Text);

            }



        }


        private void temizle()
        {
            finalorttbx.Clear();
            vizeorttbx.Clear();
            rapororttbx.Clear();
            tabloorttbx.Clear();

            finaltxtbox.Clear();
            vizetxtbox.Clear();
            raportxtbox.Clear();
            tablotxtboox.Clear();

            derskayıttbx.Clear();

        }



        private void button2_Click(object sender, EventArgs e)
        {


            btnDersGoster.Visible = false;
            btnderskayıt.Visible = true;
            lblNotGiriniz.Visible = false;
            LBLDERSGİRİNİZ.Visible = true;


            if (kacderstbx.Text == lblDersEsitleme.Text)
            {
                btnDersGoster.Visible = false;
                btnderskayıt.Visible = false;
                lblNotGiriniz.Visible = false;
                LBLDERSGİRİNİZ.Visible = false;


            }

            sayac++;
            LBLDERSGİRİNİZ.Text= sayac + " . Dersi Giriniz";
            lblNotGiriniz.Text = sayac + " . Notu Giriniz";



            listBox1.Items.Add(dersler +" " + sonuc);
            listbox2.Items.Add(sonuc);

            MessageBox.Show("Kayıt Ekleme İşleminiz Başarıyla Gerçekleştirildi");

            temizle();
        }


        String dersguncelle;
        private void btnGuncelle_Click(object sender, EventArgs e)
        {

            dersguncelle =Convert.ToString(Guncelletbx.Text);

            if (listBox1.SelectedIndex==-1)
            {

                MessageBox.Show("Lütfen Öncelikle Kayıt seçiniz.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
                listBox1.Items.Add(dersguncelle + " " + sonuc);
            }
        }



        private void btnSil_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1)
            {

                MessageBox.Show("Lütfen Öncelikle Kayıt seçiniz.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
            }
        }



        private void btnTopla_Click(object sender, EventArgs e)
        {
            double toplam = 0;
            double ortalama;

            for (int i = 0; i<listbox2.Items.Count; i++)
            {
                toplam = Convert.ToDouble(listbox2.Items[i]);
            }

            ortalama = toplam / listbox2.Items.Count;


            lbltopla.Text= "Toplam: " + toplam + " /  Ortalama: " + ortalama;
            lblortalama.Text= "Toplam Ders Sayı: "+ listbox2.Items.Count.ToString();
        }


        private void btnTemizle_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listbox2.Items.Clear();

        }

    }
}
