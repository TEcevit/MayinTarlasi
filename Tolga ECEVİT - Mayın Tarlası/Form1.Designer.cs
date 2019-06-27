namespace Tolga_ECEVİT___Mayın_Tarlası
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
            this.components = new System.ComponentModel.Container();
            this.lblMayinTarlasi = new System.Windows.Forms.Label();
            this.lblOyuncuAdi = new System.Windows.Forms.Label();
            this.txtOyuncuAdi = new System.Windows.Forms.TextBox();
            this.btnBasla = new System.Windows.Forms.Button();
            this.timerStart = new System.Windows.Forms.Timer(this.components);
            this.lblEksikKullaniciAdi = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblMayinTarlasi
            // 
            this.lblMayinTarlasi.AutoSize = true;
            this.lblMayinTarlasi.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMayinTarlasi.Location = new System.Drawing.Point(129, 9);
            this.lblMayinTarlasi.Name = "lblMayinTarlasi";
            this.lblMayinTarlasi.Size = new System.Drawing.Size(220, 37);
            this.lblMayinTarlasi.TabIndex = 0;
            this.lblMayinTarlasi.Text = "Mayın Tarlası";
            // 
            // lblOyuncuAdi
            // 
            this.lblOyuncuAdi.AutoSize = true;
            this.lblOyuncuAdi.Location = new System.Drawing.Point(62, 70);
            this.lblOyuncuAdi.Name = "lblOyuncuAdi";
            this.lblOyuncuAdi.Size = new System.Drawing.Size(68, 13);
            this.lblOyuncuAdi.TabIndex = 1;
            this.lblOyuncuAdi.Text = "Oyuncu Adı :";
            // 
            // txtOyuncuAdi
            // 
            this.txtOyuncuAdi.Location = new System.Drawing.Point(136, 63);
            this.txtOyuncuAdi.Name = "txtOyuncuAdi";
            this.txtOyuncuAdi.Size = new System.Drawing.Size(213, 20);
            this.txtOyuncuAdi.TabIndex = 2;
            // 
            // btnBasla
            // 
            this.btnBasla.Location = new System.Drawing.Point(136, 107);
            this.btnBasla.Name = "btnBasla";
            this.btnBasla.Size = new System.Drawing.Size(213, 23);
            this.btnBasla.TabIndex = 3;
            this.btnBasla.Text = "BAŞLA";
            this.btnBasla.UseVisualStyleBackColor = true;
            this.btnBasla.Click += new System.EventHandler(this.btnBasla_Click);
            // 
            // timerStart
            // 
            this.timerStart.Interval = 10;
            this.timerStart.Tick += new System.EventHandler(this.timerStart_Tick);
            // 
            // lblEksikKullaniciAdi
            // 
            this.lblEksikKullaniciAdi.AutoSize = true;
            this.lblEksikKullaniciAdi.Location = new System.Drawing.Point(133, 143);
            this.lblEksikKullaniciAdi.Name = "lblEksikKullaniciAdi";
            this.lblEksikKullaniciAdi.Size = new System.Drawing.Size(0, 13);
            this.lblEksikKullaniciAdi.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(562, 430);
            this.Controls.Add(this.lblEksikKullaniciAdi);
            this.Controls.Add(this.btnBasla);
            this.Controls.Add(this.txtOyuncuAdi);
            this.Controls.Add(this.lblOyuncuAdi);
            this.Controls.Add(this.lblMayinTarlasi);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMayinTarlasi;
        private System.Windows.Forms.Label lblOyuncuAdi;
        private System.Windows.Forms.Button btnBasla;
        private System.Windows.Forms.Timer timerStart;
        private System.Windows.Forms.Label lblEksikKullaniciAdi;
        public System.Windows.Forms.TextBox txtOyuncuAdi;
    }
}

