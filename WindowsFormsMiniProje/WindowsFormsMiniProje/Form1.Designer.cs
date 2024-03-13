namespace EyupSultanKodluyorGrup2
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.txtUrunAdi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.txtStokMiktari = new System.Windows.Forms.TextBox();
            this.lblMesaj = new System.Windows.Forms.Label();
            this.btnStock = new System.Windows.Forms.Button();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.txtFiyat = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(27, 62);
            this.button1.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(238, 51);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtUrunAdi
            // 
            this.txtUrunAdi.Location = new System.Drawing.Point(28, 141);
            this.txtUrunAdi.Name = "txtUrunAdi";
            this.txtUrunAdi.Size = new System.Drawing.Size(429, 35);
            this.txtUrunAdi.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "C# Introduction";
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(228, 274);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(229, 52);
            this.btnKaydet.TabIndex = 3;
            this.btnKaydet.Text = "KAYDET";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // txtStokMiktari
            // 
            this.txtStokMiktari.Location = new System.Drawing.Point(27, 182);
            this.txtStokMiktari.Name = "txtStokMiktari";
            this.txtStokMiktari.Size = new System.Drawing.Size(429, 35);
            this.txtStokMiktari.TabIndex = 1;
            // 
            // lblMesaj
            // 
            this.lblMesaj.Location = new System.Drawing.Point(22, 411);
            this.lblMesaj.Name = "lblMesaj";
            this.lblMesaj.Size = new System.Drawing.Size(423, 75);
            this.lblMesaj.TabIndex = 4;
            // 
            // btnStock
            // 
            this.btnStock.Location = new System.Drawing.Point(29, 274);
            this.btnStock.Name = "btnStock";
            this.btnStock.Size = new System.Drawing.Size(193, 52);
            this.btnStock.TabIndex = 5;
            this.btnStock.Text = "Stok Miktarı";
            this.btnStock.UseVisualStyleBackColor = true;
            this.btnStock.Click += new System.EventHandler(this.btnStock_Click);
            // 
            // btnHesapla
            // 
            this.btnHesapla.Location = new System.Drawing.Point(29, 332);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(193, 70);
            this.btnHesapla.TabIndex = 6;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // txtFiyat
            // 
            this.txtFiyat.Location = new System.Drawing.Point(27, 223);
            this.txtFiyat.Name = "txtFiyat";
            this.txtFiyat.Size = new System.Drawing.Size(429, 35);
            this.txtFiyat.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 523);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.btnStock);
            this.Controls.Add(this.lblMesaj);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFiyat);
            this.Controls.Add(this.txtStokMiktari);
            this.Controls.Add(this.txtUrunAdi);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtUrunAdi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.TextBox txtStokMiktari;
        private System.Windows.Forms.Label lblMesaj;
        private System.Windows.Forms.Button btnStock;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.TextBox txtFiyat;
    }
}

