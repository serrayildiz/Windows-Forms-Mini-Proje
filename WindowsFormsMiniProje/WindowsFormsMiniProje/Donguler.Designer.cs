namespace EyupSultanKodluyorGrup2
{
    partial class Donguler
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
            this.lstListe = new System.Windows.Forms.ListBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstListe
            // 
            this.lstListe.FormattingEnabled = true;
            this.lstListe.ItemHeight = 29;
            this.lstListe.Location = new System.Drawing.Point(12, 12);
            this.lstListe.Name = "lstListe";
            this.lstListe.Size = new System.Drawing.Size(237, 323);
            this.lstListe.TabIndex = 0;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(266, 12);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(211, 49);
            this.btnEkle.TabIndex = 1;
            this.btnEkle.Text = "FOR";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(266, 67);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(211, 51);
            this.button1.TabIndex = 2;
            this.button1.Text = "FOREACH";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Donguler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 387);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.lstListe);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.Name = "Donguler";
            this.Text = "Donguler";
            this.Load += new System.EventHandler(this.Donguler_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstListe;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button button1;
    }
}