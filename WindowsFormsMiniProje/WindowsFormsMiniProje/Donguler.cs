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
    public partial class Donguler : Form
    {
        public Donguler()
        {
            InitializeComponent();
        }

        private void Donguler_Load(object sender, EventArgs e)
        {
            /*
             DÖNGÜLER
            while, do while, for, foreach
             */

            //FOR

            //for (int i = 0; i < 5; i++)
            //{

            //}



            //FOREACH
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            //listboxa ekleme yapmak için

            //lstListe.Items.Add("Caner");
            //lstListe.Items.Add(true);
            //lstListe.Items.Add(45.5444);


            //for (int i = 1; i <= 100; i++)
            //{
            //    lstListe.Items.Add("Caner");
            //}

            for (int sayac = 1; sayac <= 100; sayac++)
            {
                lstListe.Items.Add($"{sayac}. Caner");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string[] ilListesi = new string[] { "İstanbul", "Ankara", "İzmir", "Mersin" };


            foreach (var item in ilListesi)
            {
                lstListe.Items.Add(item);
            }
        }
    }
}
