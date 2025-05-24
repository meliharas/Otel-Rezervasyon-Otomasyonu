namespace Otel_Rezervasyon
{
    partial class FormRezervasyon
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbMusteri = new System.Windows.Forms.ComboBox();
            this.cmbOda = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.dtpGiris = new System.Windows.Forms.DateTimePicker();
            this.dtpCikis = new System.Windows.Forms.DateTimePicker();
            this.txtUcret = new System.Windows.Forms.TextBox();
            this.txtToplam = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Müşteri Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Oda Numarası:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Giriş Tarihi:";
            // 
            // cmbMusteri
            // 
            this.cmbMusteri.FormattingEnabled = true;
            this.cmbMusteri.Location = new System.Drawing.Point(163, 43);
            this.cmbMusteri.Name = "cmbMusteri";
            this.cmbMusteri.Size = new System.Drawing.Size(190, 24);
            this.cmbMusteri.TabIndex = 3;
            // 
            // cmbOda
            // 
            this.cmbOda.FormattingEnabled = true;
            this.cmbOda.Location = new System.Drawing.Point(163, 84);
            this.cmbOda.Name = "cmbOda";
            this.cmbOda.Size = new System.Drawing.Size(190, 24);
            this.cmbOda.TabIndex = 4;
            this.cmbOda.SelectedIndexChanged += new System.EventHandler(this.cmbOda_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Çıkış Tarihi:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Günlük Ücret:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 234);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 16);
            this.label6.TabIndex = 7;
            this.label6.Text = "Toplam Ücret:";
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(163, 285);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(114, 25);
            this.btnKaydet.TabIndex = 8;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // dtpGiris
            // 
            this.dtpGiris.Location = new System.Drawing.Point(163, 121);
            this.dtpGiris.Name = "dtpGiris";
            this.dtpGiris.Size = new System.Drawing.Size(192, 22);
            this.dtpGiris.TabIndex = 9;
            this.dtpGiris.ValueChanged += new System.EventHandler(this.dtpGiris_ValueChanged);
            // 
            // dtpCikis
            // 
            this.dtpCikis.Location = new System.Drawing.Point(163, 161);
            this.dtpCikis.Name = "dtpCikis";
            this.dtpCikis.Size = new System.Drawing.Size(192, 22);
            this.dtpCikis.TabIndex = 10;
            this.dtpCikis.ValueChanged += new System.EventHandler(this.dtpCikis_ValueChanged);
            // 
            // txtUcret
            // 
            this.txtUcret.Location = new System.Drawing.Point(163, 198);
            this.txtUcret.Name = "txtUcret";
            this.txtUcret.ReadOnly = true;
            this.txtUcret.Size = new System.Drawing.Size(192, 22);
            this.txtUcret.TabIndex = 11;
            // 
            // txtToplam
            // 
            this.txtToplam.Location = new System.Drawing.Point(163, 234);
            this.txtToplam.Name = "txtToplam";
            this.txtToplam.ReadOnly = true;
            this.txtToplam.Size = new System.Drawing.Size(192, 22);
            this.txtToplam.TabIndex = 12;
            // 
            // FormRezervasyon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 351);
            this.Controls.Add(this.txtToplam);
            this.Controls.Add(this.txtUcret);
            this.Controls.Add(this.dtpCikis);
            this.Controls.Add(this.dtpGiris);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbOda);
            this.Controls.Add(this.cmbMusteri);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormRezervasyon";
            this.Text = "FormRezervasyon";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbMusteri;
        private System.Windows.Forms.ComboBox cmbOda;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.DateTimePicker dtpGiris;
        private System.Windows.Forms.DateTimePicker dtpCikis;
        private System.Windows.Forms.TextBox txtUcret;
        private System.Windows.Forms.TextBox txtToplam;
    }
}