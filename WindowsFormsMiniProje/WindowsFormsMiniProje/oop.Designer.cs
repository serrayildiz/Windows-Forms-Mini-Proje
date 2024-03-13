namespace EyupSultanKodluyorGrup2
{
    partial class oop
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
            this.lstListe = new System.Windows.Forms.ListBox();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(25, 23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(512, 64);
            this.button1.TabIndex = 0;
            this.button1.Text = "NESNE OLUŞTUR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(25, 93);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(512, 102);
            this.button2.TabIndex = 1;
            this.button2.Text = "Generic List";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lstListe
            // 
            this.lstListe.FormattingEnabled = true;
            this.lstListe.ItemHeight = 29;
            this.lstListe.Location = new System.Drawing.Point(25, 211);
            this.lstListe.Name = "lstListe";
            this.lstListe.Size = new System.Drawing.Size(348, 178);
            this.lstListe.TabIndex = 2;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(379, 211);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(158, 52);
            this.button3.TabIndex = 3;
            this.button3.Text = "Getir";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // oop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 426);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.lstListe);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.Name = "oop";
            this.Text = "oop";
            this.Load += new System.EventHandler(this.oop_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox lstListe;
        private System.Windows.Forms.Button button3;
    }
}