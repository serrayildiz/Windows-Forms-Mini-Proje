using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EyupSultanKodluyorGrup2
{
    public partial class Diziler : Form
    {
        public Diziler()
        {
            InitializeComponent();
        }

        private void Diziler_Load(object sender, EventArgs e)
        {
            /*
             Diziler (Arrays)
            Dizi içerisinde aynı tipten birden fazla değeri tutabilen ve index(indis) numaraları üzerinden bu değerlere ulaşabildiğimiz bir veri yapısıdır. Dizinin içinde bulunan değerlere o dizinin elemanları denir.
             */


            //string ad1 = "Ahmet";
            //string soyad1 = "Aksakal";

            //string ad2 = "Kardelen";
            //string soyad2 = "Tugay";


            //Dizi Oluşturma:

            string[] liste = new string[4];
            //0, 1, 2, 3

            int[] sayiDizisi = new int[] { 123, 567, 40, 34 };

            //dizinin eleman sayısını Length propertysi geriye döner.
            int elemanSayisi = sayiDizisi.Length;

            //Dizinin Elemanlarına Değer Atama
            liste[0] = "Caner Mollaoğlu";
            liste[1] = "Ahmet Aksakal";
            liste[2] = "Kardelen Tugay";
            liste[3] = "Kuzey Mollaoğlu";
            //liste[4] = "Mesut Gelgit"; Index was outside the bounds of the array.'

            //Diziden Değer Okuma:

            string deger = liste[2];

        }

        //global değisken
        string[] ogrenciListesi = new string[1];

        int sayac = 0;
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            string ogrenciAdiSoyadi = txtOgrenciAdi.Text;

            ogrenciListesi[sayac] = ogrenciAdiSoyadi;
            //sayac = sayac + 1;
            sayac++; //sayacı 1 artırır.

            //Burada her bir öğrenci eklendiğinde diziye yeni bir boş alan (çekmece) ekliyoruz.
            Array.Resize(ref ogrenciListesi, ogrenciListesi.Length+1);
        }
    }
}
