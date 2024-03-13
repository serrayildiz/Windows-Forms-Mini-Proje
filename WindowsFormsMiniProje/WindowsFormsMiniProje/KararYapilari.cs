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
    public partial class KararYapilari : Form
    {
        public KararYapilari()
        {
            InitializeComponent();
        }

        private void KararYapilari_Load(object sender, EventArgs e)
        {
            /*
             IF KARAR YAPILARI

            Karşılaştırma Operatörleri:<,>,<=,>=,==,!=
            Mantıksal Operatörler: &,&& (ve), |, || (veya)
             */

            int sayi = 1500;

            if (sayi >= 600)
            {
                //kosul sağlandığında çalışır.
                //true bloğu
            }
            else
            {
                //kosul sağlanmazsa çalışır
                //false bloğu
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*
             Ahmet'in sınıfını geçebilmesi için not ortalamasının 70 puana eşit veya üzerinde ve (aynı zamanda) devamsızlık durumunun da 10 günün altında olması gerekmektedir. 
             */

            byte devamsizlikDurumu = 10;
            byte notOrtalamasi = 75;


            if (notOrtalamasi >= 70 && devamsizlikDurumu < 10)
            {
                MessageBox.Show("Sınıfınızı geçtiniz.");
            }
            else
            {
                MessageBox.Show("KALDINIZ.");
            }

            /*
             &,&& VE Operatörü Kullanılıyorsa:

            true, true > true
            true, false > false
            false, true > false
            false, false > false
             */


        }

        private void button2_Click(object sender, EventArgs e)
        {
            /*
             Ahmet'in sınıfını geçebilmesi için not ortalamasının 70 puana eşit veya üzerinde yada devamsızlık durumunun da 10 günün altında olması gerekmektedir. 
             */

            byte devamsizlikDurumu = 10;
            byte notOrtalamasi = 75;

            if (notOrtalamasi >= 70 || devamsizlikDurumu < 10)
            {

            }
            else
            {

            }
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            /*
             Müşteri tutarı;

            500 tl ile 1000 tl arasında ise %20,
            1000 tl ile 2000 tl arasında ise %25,
            2000 tl ile 3500 tl arasında ise %30,
            3500 tl ile 5000 tl arasında ise %40,
            5000 tl den fazla ise %45 indirim uygulanacaktır. 

            İndirimli tutarı ve indirim oranını yazdırınız.
             */

            double tutar = Convert.ToDouble(txtTutar.Text);
            double indirimOrani;

            if (tutar >= 500 && tutar <= 1000)
            {
                //tutar = tutar - (tutar * 0.20);
                tutar -= tutar * 0.20;
                indirimOrani = 0.20;
            }
            else if (tutar > 1000 && tutar <= 2000)
            {
                tutar -= tutar * 0.25;
                indirimOrani = 0.25;
            }
            else if (tutar > 2000 && tutar <= 3500)
            {
                tutar -= tutar * 0.30;
                indirimOrani = 0.30;
            }
            else if (tutar > 3500 && tutar <= 5000)
            {
                tutar -= tutar * 0.40;
                indirimOrani = 0.40;
            }
            else if (tutar > 5000)
            {
                tutar -= tutar * 0.45;
                indirimOrani = 0.45;
            }
            else
            {
                indirimOrani = 0;
                
            }

            if (indirimOrani==0)
            {
                lblMesaj.Text = "İndirim Kazanamadınız.";
            }
            else
            {
                lblMesaj.Text = $"İndirimli Tutar: {tutar}\nİndirim Oranı: {indirimOrani}";
            }

        }
    }
}
