namespace Otel_Rezervasyon
{
    partial class FormMudurPanel
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
            this.btnMusteriListele = new System.Windows.Forms.Button();
            this.btnOdaListele = new System.Windows.Forms.Button();
            this.btnRezervasyonListele = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnMusteriListele
            // 
            this.btnMusteriListele.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnMusteriListele.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMusteriListele.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMusteriListele.Location = new System.Drawing.Point(83, 98);
            this.btnMusteriListele.Name = "btnMusteriListele";
            this.btnMusteriListele.Size = new System.Drawing.Size(160, 45);
            this.btnMusteriListele.TabIndex = 0;
            this.btnMusteriListele.Text = "Müşter Listele";
            this.btnMusteriListele.UseVisualStyleBackColor = false;
            this.btnMusteriListele.Click += new System.EventHandler(this.btnMusteriListele_Click);
            // 
            // btnOdaListele
            // 
            this.btnOdaListele.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnOdaListele.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOdaListele.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnOdaListele.Location = new System.Drawing.Point(83, 159);
            this.btnOdaListele.Name = "btnOdaListele";
            this.btnOdaListele.Size = new System.Drawing.Size(160, 45);
            this.btnOdaListele.TabIndex = 1;
            this.btnOdaListele.Text = "Oda Listele\n";
            this.btnOdaListele.UseVisualStyleBackColor = false;
            this.btnOdaListele.Click += new System.EventHandler(this.btnOdaListele_Click);
            // 
            // btnRezervasyonListele
            // 
            this.btnRezervasyonListele.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnRezervasyonListele.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRezervasyonListele.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRezervasyonListele.Location = new System.Drawing.Point(83, 225);
            this.btnRezervasyonListele.Name = "btnRezervasyonListele";
            this.btnRezervasyonListele.Size = new System.Drawing.Size(160, 61);
            this.btnRezervasyonListele.TabIndex = 2;
            this.btnRezervasyonListele.Text = "Rezervasyon Listele";
            this.btnRezervasyonListele.UseVisualStyleBackColor = false;
            this.btnRezervasyonListele.Click += new System.EventHandler(this.btnRezervasyonListele_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(77, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "Müdür Panel";
            // 
            // FormMudurPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 343);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRezervasyonListele);
            this.Controls.Add(this.btnOdaListele);
            this.Controls.Add(this.btnMusteriListele);
            this.Name = "FormMudurPanel";
            this.Text = "FormMudurPanel";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMudurPanel_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMusteriListele;
        private System.Windows.Forms.Button btnOdaListele;
        private System.Windows.Forms.Button btnRezervasyonListele;
        private System.Windows.Forms.Label label1;
    }
}