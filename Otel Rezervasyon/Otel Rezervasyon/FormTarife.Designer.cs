namespace Otel_Rezervasyon
{
    partial class FormTarife
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
            this.lblTip = new System.Windows.Forms.Label();
            this.lblUcret = new System.Windows.Forms.Label();
            this.cmbTip = new System.Windows.Forms.ComboBox();
            this.txtUcret = new System.Windows.Forms.TextBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTip
            // 
            this.lblTip.AutoSize = true;
            this.lblTip.Location = new System.Drawing.Point(104, 65);
            this.lblTip.Name = "lblTip";
            this.lblTip.Size = new System.Drawing.Size(62, 16);
            this.lblTip.TabIndex = 0;
            this.lblTip.Text = "Oda Tipi:";
            // 
            // lblUcret
            // 
            this.lblUcret.AutoSize = true;
            this.lblUcret.Location = new System.Drawing.Point(104, 132);
            this.lblUcret.Name = "lblUcret";
            this.lblUcret.Size = new System.Drawing.Size(42, 16);
            this.lblUcret.TabIndex = 1;
            this.lblUcret.Text = "Ücret:";
            // 
            // cmbTip
            // 
            this.cmbTip.FormattingEnabled = true;
            this.cmbTip.Items.AddRange(new object[] {
            "Tek Kişilik",
            "Çift Kişilik",
            "Suit"});
            this.cmbTip.Location = new System.Drawing.Point(239, 65);
            this.cmbTip.Name = "cmbTip";
            this.cmbTip.Size = new System.Drawing.Size(151, 24);
            this.cmbTip.TabIndex = 2;
            // 
            // txtUcret
            // 
            this.txtUcret.Location = new System.Drawing.Point(239, 132);
            this.txtUcret.Name = "txtUcret";
            this.txtUcret.Size = new System.Drawing.Size(151, 22);
            this.txtUcret.TabIndex = 3;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(260, 213);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(117, 37);
            this.btnKaydet.TabIndex = 4;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // FormTarife
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.txtUcret);
            this.Controls.Add(this.cmbTip);
            this.Controls.Add(this.lblUcret);
            this.Controls.Add(this.lblTip);
            this.Name = "FormTarife";
            this.Text = "FormTarife";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTip;
        private System.Windows.Forms.Label lblUcret;
        private System.Windows.Forms.ComboBox cmbTip;
        private System.Windows.Forms.TextBox txtUcret;
        private System.Windows.Forms.Button btnKaydet;
    }
}