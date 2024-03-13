using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EyupSultanKodluyorGrup2
{
    public partial class FinalSorusu : Form
    {
        public class Urun
        {
            public string UrunAdi { get; set; }
            public int UrunAdedi { get; set; }
            public double UrunFiyati { get; set; }
        }


        private List<Urun> urunler = new List<Urun>();

        public FinalSorusu()
        {
            InitializeComponent();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            // Ürün bilgilerini textbox'lardan al
            string urunAdi = txtUrunAdi.Text;
            int urunAdedi;
            double urunFiyati;

            // Boş textbox kontrolü (isteğe bağlı)
            if (string.IsNullOrEmpty(urunAdi))
            {
                MessageBox.Show("Lütfen ürün adı giriniz.");
                return;
            }

            // Ürün adedinin sayısal formatta girildiğini kontrol et
            if (!int.TryParse(txtUrunAdedi.Text, out urunAdedi))
            {
                MessageBox.Show("Lütfen ürün adedini sayı olarak giriniz.");
                return;
            }

            // Ürün fiyatının sayısal formatta girildiğini kontrol et
            if (!double.TryParse(txtUrunFiyati.Text, out urunFiyati))
            {
                MessageBox.Show("Lütfen ürün fiyatını sayı olarak giriniz.");
                return;
            }

            // Yeni ürün nesnesi oluştur
            Urun urun = new Urun
            {
                UrunAdi = urunAdi,
                UrunAdedi = urunAdedi,
                UrunFiyati = urunFiyati
            };

            // Ürünü listeye ekle
            urunler.Add(urun);

            // Textbox'ları temizle veya bir başarı mesajı göster
            txtUrunAdi.Clear();
            txtUrunAdedi.Clear();
            txtUrunFiyati.Clear();
            MessageBox.Show("Ürün başarıyla kaydedildi!");
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            // Make sure lstUrunler refers to the ListBox on your form.
            lstListe.Items.Clear();

            foreach (Urun urun in urunler)
            {
                string urunBilgisi = $"{urun.UrunAdi} / {urun.UrunAdedi} adet - {urun.UrunFiyati * 1.2:C2}";
                lstListe.Items.Add(urunBilgisi);
            }
        }

        private void btnAktar_Click(object sender, EventArgs e)
        {
            // Verileri nereye aktaracağınıza karar verin (başka bir liste, dosya vb.)
            // Örnek: Listeyi string dizisine dönüştürme
            string[] urunAdlari = urunler.Select(urun => urun.UrunAdi).ToArray();

            // 'urunler.txt' adlı bir dosya oluştur ve ürün adlarını yaz
            using (StreamWriter sw = new StreamWriter("urunler.txt"))
            {
                foreach (string urunAdi in urunAdlari)
                {
                    sw.WriteLine(urunAdi);
                }
            }

            MessageBox.Show("Ürünler başarıyla 'urunler.txt' dosyasına aktarıldı!");
        }

        private void btnElemanSayisi_Click(object sender, EventArgs e)
        {
            // Listedeki ürünlerin sayısını göster
            int elemanSayisi = urunler.Count;
            MessageBox.Show($"Listede {elemanSayisi} adet ürün bulunmaktadır.");
        }

        private void FinalSorusu_Load(object sender, EventArgs e)
        {
            // Formu tam ekran modunda aç
            this.WindowState = FormWindowState.Maximized;
        }

        private void lstListe_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}