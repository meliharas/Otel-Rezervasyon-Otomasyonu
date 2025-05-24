namespace Otel_Rezervasyon
{
    partial class FormAdminPanel
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
            this.btnMüsterİ = new System.Windows.Forms.Button();
            this.btnOda = new System.Windows.Forms.Button();
            this.btnRezervasyon = new System.Windows.Forms.Button();
            this.btnTarife = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnMüsterİ
            // 
            this.btnMüsterİ.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnMüsterİ.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMüsterİ.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMüsterİ.Location = new System.Drawing.Point(90, 84);
            this.btnMüsterİ.Name = "btnMüsterİ";
            this.btnMüsterİ.Size = new System.Drawing.Size(150, 45);
            this.btnMüsterİ.TabIndex = 0;
            this.btnMüsterİ.Text = "Müşteri İşlemlerİ";
            this.btnMüsterİ.UseVisualStyleBackColor = false;
            this.btnMüsterİ.Click += new System.EventHandler(this.btnMusteri_Click);
            // 
            // btnOda
            // 
            this.btnOda.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnOda.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOda.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnOda.Location = new System.Drawing.Point(90, 135);
            this.btnOda.Name = "btnOda";
            this.btnOda.Size = new System.Drawing.Size(150, 45);
            this.btnOda.TabIndex = 1;
            this.btnOda.Text = "Oda İşlemleri";
            this.btnOda.UseVisualStyleBackColor = false;
            this.btnOda.Click += new System.EventHandler(this.btnOda_Click);
            // 
            // btnRezervasyon
            // 
            this.btnRezervasyon.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnRezervasyon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRezervasyon.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRezervasyon.Location = new System.Drawing.Point(90, 186);
            this.btnRezervasyon.Name = "btnRezervasyon";
            this.btnRezervasyon.Size = new System.Drawing.Size(150, 45);
            this.btnRezervasyon.TabIndex = 2;
            this.btnRezervasyon.Text = "Rezervasyon İşlemleri";
            this.btnRezervasyon.UseVisualStyleBackColor = false;
            this.btnRezervasyon.Click += new System.EventHandler(this.btnRezervasyon_Click);
            // 
            // btnTarife
            // 
            this.btnTarife.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnTarife.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTarife.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTarife.Location = new System.Drawing.Point(90, 237);
            this.btnTarife.Name = "btnTarife";
            this.btnTarife.Size = new System.Drawing.Size(150, 45);
            this.btnTarife.TabIndex = 3;
            this.btnTarife.Text = "Tarife Belirle";
            this.btnTarife.UseVisualStyleBackColor = false;
            this.btnTarife.Click += new System.EventHandler(this.btnTarife_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(84, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 32);
            this.label1.TabIndex = 4;
            this.label1.Text = "Admin Panel";
            // 
            // FormAdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 331);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTarife);
            this.Controls.Add(this.btnRezervasyon);
            this.Controls.Add(this.btnOda);
            this.Controls.Add(this.btnMüsterİ);
            this.Name = "FormAdminPanel";
            this.Text = "FormAdminPanel";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormAdminPanel_FormClosing);
            this.Load += new System.EventHandler(this.FormAdminPanel_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMüsterİ;
        private System.Windows.Forms.Button btnOda;
        private System.Windows.Forms.Button btnRezervasyon;
        private System.Windows.Forms.Button btnTarife;
        private System.Windows.Forms.Label label1;
    }
}