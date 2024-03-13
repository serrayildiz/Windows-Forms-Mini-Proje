namespace EyupSultanKodluyorGrup2
{
    partial class FinalSorusu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FinalSorusu));
            this.lstListe = new System.Windows.Forms.ListBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnElemanSayisi = new System.Windows.Forms.Button();
            this.btnAktar = new System.Windows.Forms.Button();
            this.btnListele = new System.Windows.Forms.Button();
            this.txtUrunFiyati = new System.Windows.Forms.TextBox();
            this.txtUrunAdedi = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.txtUrunAdi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstListe
            // 
            this.lstListe.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.lstListe.FormattingEnabled = true;
            this.lstListe.ItemHeight = 38;
            this.lstListe.Location = new System.Drawing.Point(20, 280);
            this.lstListe.Name = "lstListe";
            this.lstListe.Size = new System.Drawing.Size(413, 346);
            this.lstListe.TabIndex = 29;
            this.lstListe.SelectedIndexChanged += new System.EventHandler(this.lstListe_SelectedIndexChanged);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.btnKaydet.Location = new System.Drawing.Point(18, 208);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(221, 57);
            this.btnKaydet.TabIndex = 25;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnElemanSayisi
            // 
            this.btnElemanSayisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.btnElemanSayisi.Location = new System.Drawing.Point(439, 591);
            this.btnElemanSayisi.Name = "btnElemanSayisi";
            this.btnElemanSayisi.Size = new System.Drawing.Size(568, 57);
            this.btnElemanSayisi.TabIndex = 26;
            this.btnElemanSayisi.Text = "Dizinin Eleman Sayısını Göster";
            this.btnElemanSayisi.UseVisualStyleBackColor = true;
            this.btnElemanSayisi.Click += new System.EventHandler(this.btnElemanSayisi_Click);
            // 
            // btnAktar
            // 
            this.btnAktar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.btnAktar.Location = new System.Drawing.Point(439, 297);
            this.btnAktar.Name = "btnAktar";
            this.btnAktar.Size = new System.Drawing.Size(568, 57);
            this.btnAktar.TabIndex = 27;
            this.btnAktar.Text = "Diziye Aktar";
            this.btnAktar.UseVisualStyleBackColor = true;
            this.btnAktar.Click += new System.EventHandler(this.btnAktar_Click);
            // 
            // btnListele
            // 
            this.btnListele.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.btnListele.Location = new System.Drawing.Point(245, 208);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(188, 57);
            this.btnListele.TabIndex = 28;
            this.btnListele.Text = "Listele";
            this.btnListele.UseVisualStyleBackColor = true;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // txtUrunFiyati
            // 
            this.txtUrunFiyati.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.txtUrunFiyati.Location = new System.Drawing.Point(20, 170);
            this.txtUrunFiyati.Name = "txtUrunFiyati";
            this.txtUrunFiyati.Size = new System.Drawing.Size(413, 44);
            this.txtUrunFiyati.TabIndex = 20;
            // 
            // txtUrunAdedi
            // 
            this.txtUrunAdedi.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.txtUrunAdedi.Location = new System.Drawing.Point(20, 106);
            this.txtUrunAdedi.Name = "txtUrunAdedi";
            this.txtUrunAdedi.Size = new System.Drawing.Size(413, 44);
            this.txtUrunAdedi.TabIndex = 21;
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.textBox5.Location = new System.Drawing.Point(439, 358);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(568, 227);
            this.textBox5.TabIndex = 22;
            this.textBox5.Text = resources.GetString("textBox5.Text");
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.textBox4.Location = new System.Drawing.Point(439, 38);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(568, 253);
            this.textBox4.TabIndex = 23;
            this.textBox4.Text = resources.GetString("textBox4.Text");
            // 
            // txtUrunAdi
            // 
            this.txtUrunAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.txtUrunAdi.Location = new System.Drawing.Point(20, 42);
            this.txtUrunAdi.Name = "txtUrunAdi";
            this.txtUrunAdi.Size = new System.Drawing.Size(413, 44);
            this.txtUrunAdi.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.label3.Location = new System.Drawing.Point(15, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(305, 38);
            this.label3.TabIndex = 17;
            this.label3.Text = "Ürün Fiyatı / Double";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.label2.Location = new System.Drawing.Point(15, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 38);
            this.label2.TabIndex = 18;
            this.label2.Text = "Ürün Adedi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.label1.Location = new System.Drawing.Point(15, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 38);
            this.label1.TabIndex = 19;
            this.label1.Text = "Ürün Adı";
            // 
            // FinalSorusu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(22F, 42F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 652);
            this.Controls.Add(this.lstListe);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.btnElemanSayisi);
            this.Controls.Add(this.btnAktar);
            this.Controls.Add(this.btnListele);
            this.Controls.Add(this.txtUrunFiyati);
            this.Controls.Add(this.txtUrunAdedi);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.txtUrunAdi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.Margin = new System.Windows.Forms.Padding(7);
            this.Name = "FinalSorusu";
            this.Text = "FinalSorusu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstListe;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnElemanSayisi;
        private System.Windows.Forms.Button btnAktar;
        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.TextBox txtUrunFiyati;
        private System.Windows.Forms.TextBox txtUrunAdedi;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox txtUrunAdi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}