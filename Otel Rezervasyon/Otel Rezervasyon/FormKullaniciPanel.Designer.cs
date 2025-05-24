namespace Otel_Rezervasyon
{
    partial class FormKullaniciPanel
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
            this.btnRezervasyonEkle = new System.Windows.Forms.Button();
            this.btnMusteriEkle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnRezervasyonEkle
            // 
            this.btnRezervasyonEkle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnRezervasyonEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRezervasyonEkle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRezervasyonEkle.Location = new System.Drawing.Point(61, 110);
            this.btnRezervasyonEkle.Name = "btnRezervasyonEkle";
            this.btnRezervasyonEkle.Size = new System.Drawing.Size(170, 63);
            this.btnRezervasyonEkle.TabIndex = 0;
            this.btnRezervasyonEkle.Text = "Rezervasyon Ekle";
            this.btnRezervasyonEkle.UseVisualStyleBackColor = false;
            this.btnRezervasyonEkle.Click += new System.EventHandler(this.btnRezervasyonEkle_Click);
            // 
            // btnMusteriEkle
            // 
            this.btnMusteriEkle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnMusteriEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMusteriEkle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMusteriEkle.Location = new System.Drawing.Point(61, 179);
            this.btnMusteriEkle.Name = "btnMusteriEkle";
            this.btnMusteriEkle.Size = new System.Drawing.Size(168, 63);
            this.btnMusteriEkle.TabIndex = 1;
            this.btnMusteriEkle.Text = "Müşteri Ekle";
            this.btnMusteriEkle.UseVisualStyleBackColor = false;
            this.btnMusteriEkle.Click += new System.EventHandler(this.btnMusteriEkle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(45, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Personel Panel";
            // 
            // FormKullaniciPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 322);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnMusteriEkle);
            this.Controls.Add(this.btnRezervasyonEkle);
            this.Name = "FormKullaniciPanel";
            this.Text = "FormKullaniciPanel";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormKullaniciPanel_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRezervasyonEkle;
        private System.Windows.Forms.Button btnMusteriEkle;
        private System.Windows.Forms.Label label1;
    }
}