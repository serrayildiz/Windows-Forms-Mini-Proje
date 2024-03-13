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
    public partial class oop : Form
    {
        public oop()
        {
            InitializeComponent();
        }

        private void oop_Load(object sender, EventArgs e)
        {
            //string urunID = "1";
            //string urunAdi = "Hp Laptop";
            //string aciklama = "Güzel bir ürün";
            //int stokMiktari = 500;
            //int fiyat = 56000;

            //int productID = 2;
            //string productName = "Iphone Pro Max";
            //string description = "Güzel ürün";
            //int stockQuantity = 500;
            //double unitPrice = 56000;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Product sınıfımızdan bir nesne oluşturalım.

            Product p1 = new Product();
            p1.ProductID = 1;
            p1.ProductName = "HP Laptop";
            p1.UnitPrice = 45000.54;
            p1.StockQuantity = 500;
            p1.Description = "Çok güzel bir ürün.";
            p1.CategoryID = 101;


            //get
            string isim = p1.ProductName;

            //set
            p1.ProductName = "Iphone Pro Max";
            p1.CategoryID = 102;

            Product p2 = new Product()
            {
                CategoryID = 104,
                Description = "Güzel ürün",
                ProductName = "Casper Monitör",
                StockQuantity = 700,
                ProductID = 1001,
                UnitPrice = 3500.33
            };


            Product[] urunListesi = new Product[2];
            urunListesi[0] = p1;
            urunListesi[1] = p2;



        }

        List<Product> liste = new List<Product>();

        private void button2_Click(object sender, EventArgs e)
        {
            //Generic List oluşturalım.
            Product p1 = new Product()
            {
                CategoryID = 2,
                ProductID = 45,
                ProductName = "Samsung Smart TV",
                Description = "Güzel",
                StockQuantity = 100,
                UnitPrice = 167500.43
            };

            Product p2 = new Product()
            {
                CategoryID = 3,
                ProductID = 455,
                ProductName = "Smart TV",
                Description = "Güzel",
                StockQuantity = 100,
                UnitPrice = 167500.43
            };

            liste.Add(p1);
            liste.Add(p2);

            int elemanSayisi = liste.Count;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach (var item in liste)
            {
                lstListe.Items.Add($"{item.ProductName} / {item.UnitPrice}");
            }
        }
    }
}
