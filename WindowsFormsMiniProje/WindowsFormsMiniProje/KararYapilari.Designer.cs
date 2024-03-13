namespace EyupSultanKodluyorGrup2
{
    partial class KararYapilari
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
            this.button2 = new System.Windows.Forms.Button();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.txtTutar = new System.Windows.Forms.TextBox();
            this.lblMesaj = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(24, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(706, 63);
            this.button1.TabIndex = 0;
            this.button1.Text = "IF VE YAPISI";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(24, 91);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(706, 63);
            this.button2.TabIndex = 0;
            this.button2.Text = "IF VEYA YAPISI";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnHesapla
            // 
            this.btnHesapla.Location = new System.Drawing.Point(328, 225);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(209, 51);
            this.btnHesapla.TabIndex = 1;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // txtTutar
            // 
            this.txtTutar.Location = new System.Drawing.Point(34, 184);
            this.txtTutar.Name = "txtTutar";
            this.txtTutar.Size = new System.Drawing.Size(503, 35);
            this.txtTutar.TabIndex = 2;
            // 
            // lblMesaj
            // 
            this.lblMesaj.Location = new System.Drawing.Point(40, 300);
            this.lblMesaj.Name = "lblMesaj";
            this.lblMesaj.Size = new System.Drawing.Size(497, 100);
            this.lblMesaj.TabIndex = 3;
            // 
            // KararYapilari
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 567);
            this.Controls.Add(this.lblMesaj);
            this.Controls.Add(this.txtTutar);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.Name = "KararYapilari";
            this.Text = "KararYapilari";
            this.Load += new System.EventHandler(this.KararYapilari_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.TextBox txtTutar;
        private System.Windows.Forms.Label lblMesaj;
    }
}