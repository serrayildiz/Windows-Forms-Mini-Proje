using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EyupSultanKodluyorGrup2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //tek satırlık açıklama 

            /*
             
            bu şekilde
            çoklu
            yorum
            yapabiliriz.

             */

            /*
             Değişkenler (Variables)
            Bilgisayar belleğinde verilerin tutulmasını sağlayan yapılardır.
             */

            byte a = 5;
            byte b = 255;
            byte c = 34;

            short urunAdedi = 32000;
            int sayi = 5600;

            float ondalikSayi1 = 240.54f;
            double ondalikSayi2 = 544.43; //(d)
            decimal ondalikSayi3 = 600.54m;

            char karakter = 'a';
            string metin = "Eyüp Sultan Kodluyor Projesi";

            int toplam = 4343 + 22;
            byte mod = 56 % 4;

            int number1, number2;
            number1 = 4533;
            number2 = 2324;

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            //set işlemi yapıyoruz.
            //txtUrunAdi.Text = "Hp Laptop";

            //get işlemi yapıyoruz:
            string urunAdi = txtUrunAdi.Text;

            //Convert (Tür Dönüşümü)

            //int deger= Convert.ToInt32("12348448");

            //string to int
            int stokMiktari = Convert.ToInt32(txtStokMiktari.Text);

            //lblMesaj.Text = urunAdi + " adlı üründen stokta " + stokMiktari + " adet bulunmaktadır.";

            lblMesaj.Text = $"{urunAdi} adlı üründen stokta {stokMiktari} adet bulunmaktadır.";

        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            int stockMiktari = Convert.ToInt32(txtStokMiktari.Text);

            //int to string 

            lblMesaj.Text = stockMiktari.ToString();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            double fiyat = Convert.ToDouble(txtFiyat.Text);

            //double yeniFiyat=fiyat + (fiyat * 0.20);
            //fiyat=fiyat + (fiyat * 0.20);
            fiyat += fiyat * 0.20;

            lblMesaj.Text = fiyat.ToString();
        }
    }
}
