namespace Otel_Rezervasyon
{
    partial class FormAna
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
            this.btnMusteri = new System.Windows.Forms.Button();
            this.btnRezervasyon = new System.Windows.Forms.Button();
            this.btnOda = new System.Windows.Forms.Button();
            this.btnCikis = new System.Windows.Forms.Button();
            this.FormMusteriListe = new System.Windows.Forms.Button();
            this.FormOdaListe = new System.Windows.Forms.Button();
            this.btnRezervasyonListe = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMusteri
            // 
            this.btnMusteri.Location = new System.Drawing.Point(84, 32);
            this.btnMusteri.Name = "btnMusteri";
            this.btnMusteri.Size = new System.Drawing.Size(145, 47);
            this.btnMusteri.TabIndex = 0;
            this.btnMusteri.Text = "Müşteri Ekle";
            this.btnMusteri.UseVisualStyleBackColor = true;
            this.btnMusteri.Click += new System.EventHandler(this.btnMusteri_Click);
            // 
            // btnRezervasyon
            // 
            this.btnRezervasyon.Location = new System.Drawing.Point(84, 244);
            this.btnRezervasyon.Name = "btnRezervasyon";
            this.btnRezervasyon.Size = new System.Drawing.Size(145, 47);
            this.btnRezervasyon.TabIndex = 2;
            this.btnRezervasyon.Text = "Rezervasyon Ekle";
            this.btnRezervasyon.UseVisualStyleBackColor = true;
            this.btnRezervasyon.Click += new System.EventHandler(this.btnRezervasyon_Click);
            // 
            // btnOda
            // 
            this.btnOda.Location = new System.Drawing.Point(84, 138);
            this.btnOda.Name = "btnOda";
            this.btnOda.Size = new System.Drawing.Size(145, 47);
            this.btnOda.TabIndex = 1;
            this.btnOda.Text = "Oda Ekle";
            this.btnOda.UseVisualStyleBackColor = true;
            this.btnOda.Click += new System.EventHandler(this.btnOda_Click);
            // 
            // btnCikis
            // 
            this.btnCikis.Location = new System.Drawing.Point(84, 350);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(145, 47);
            this.btnCikis.TabIndex = 3;
            this.btnCikis.Text = "Çıkış";
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // FormMusteriListe
            // 
            this.FormMusteriListe.Location = new System.Drawing.Point(84, 85);
            this.FormMusteriListe.Name = "FormMusteriListe";
            this.FormMusteriListe.Size = new System.Drawing.Size(145, 47);
            this.FormMusteriListe.TabIndex = 4;
            this.FormMusteriListe.Text = "Müşteri Listele";
            this.FormMusteriListe.UseVisualStyleBackColor = true;
            this.FormMusteriListe.Click += new System.EventHandler(this.btnMusteriListe_Click);
            // 
            // FormOdaListe
            // 
            this.FormOdaListe.Location = new System.Drawing.Point(84, 191);
            this.FormOdaListe.Name = "FormOdaListe";
            this.FormOdaListe.Size = new System.Drawing.Size(145, 47);
            this.FormOdaListe.TabIndex = 5;
            this.FormOdaListe.Text = "Oda Listele";
            this.FormOdaListe.UseVisualStyleBackColor = true;
            this.FormOdaListe.Click += new System.EventHandler(this.btnOdaListe_Click);
            // 
            // btnRezervasyonListe
            // 
            this.btnRezervasyonListe.Location = new System.Drawing.Point(84, 297);
            this.btnRezervasyonListe.Name = "btnRezervasyonListe";
            this.btnRezervasyonListe.Size = new System.Drawing.Size(145, 47);
            this.btnRezervasyonListe.TabIndex = 6;
            this.btnRezervasyonListe.Text = "Rezervasyon Listele";
            this.btnRezervasyonListe.UseVisualStyleBackColor = true;
            this.btnRezervasyonListe.Click += new System.EventHandler(this.btnRezervasyonListe_Click);
            // 
            // FormAna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(325, 437);
            this.Controls.Add(this.btnRezervasyonListe);
            this.Controls.Add(this.FormOdaListe);
            this.Controls.Add(this.FormMusteriListe);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.btnRezervasyon);
            this.Controls.Add(this.btnOda);
            this.Controls.Add(this.btnMusteri);
            this.Name = "FormAna";
            this.Text = "FormAna";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMusteri;
        private System.Windows.Forms.Button btnRezervasyon;
        private System.Windows.Forms.Button btnOda;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Button FormMusteriListe;
        private System.Windows.Forms.Button FormOdaListe;
        private System.Windows.Forms.Button btnRezervasyonListe;
    }
}