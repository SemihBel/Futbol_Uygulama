
namespace Futbol_Uygulama
{
    partial class FormTakimlar
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
            this.btnTakimEkle = new System.Windows.Forms.Button();
            this.btnTakimSil = new System.Windows.Forms.Button();
            this.btnTakimGuncelle = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.btnFutbolcuDetay = new System.Windows.Forms.Button();
            this.dgvTakim = new System.Windows.Forms.DataGridView();
            this.lblTakimAdi = new System.Windows.Forms.Label();
            this.lblKupaSayisi = new System.Windows.Forms.Label();
            this.lblTakimID = new System.Windows.Forms.Label();
            this.txtTakimID = new System.Windows.Forms.TextBox();
            this.txtTakimAdi = new System.Windows.Forms.TextBox();
            this.txtKupaSayisi = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTakim)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTakimEkle
            // 
            this.btnTakimEkle.BackColor = System.Drawing.Color.DarkOrange;
            this.btnTakimEkle.Location = new System.Drawing.Point(22, 21);
            this.btnTakimEkle.Name = "btnTakimEkle";
            this.btnTakimEkle.Size = new System.Drawing.Size(88, 35);
            this.btnTakimEkle.TabIndex = 0;
            this.btnTakimEkle.Text = "Ekle";
            this.btnTakimEkle.UseVisualStyleBackColor = false;
            this.btnTakimEkle.Click += new System.EventHandler(this.btnTakimEkle_Click);
            // 
            // btnTakimSil
            // 
            this.btnTakimSil.BackColor = System.Drawing.Color.DarkOrange;
            this.btnTakimSil.Location = new System.Drawing.Point(22, 124);
            this.btnTakimSil.Name = "btnTakimSil";
            this.btnTakimSil.Size = new System.Drawing.Size(88, 35);
            this.btnTakimSil.TabIndex = 1;
            this.btnTakimSil.Text = "Sil";
            this.btnTakimSil.UseVisualStyleBackColor = false;
            this.btnTakimSil.Click += new System.EventHandler(this.btnTakimSil_Click);
            // 
            // btnTakimGuncelle
            // 
            this.btnTakimGuncelle.BackColor = System.Drawing.Color.DarkOrange;
            this.btnTakimGuncelle.Location = new System.Drawing.Point(22, 71);
            this.btnTakimGuncelle.Name = "btnTakimGuncelle";
            this.btnTakimGuncelle.Size = new System.Drawing.Size(88, 35);
            this.btnTakimGuncelle.TabIndex = 2;
            this.btnTakimGuncelle.Text = "Güncelle";
            this.btnTakimGuncelle.UseVisualStyleBackColor = false;
            this.btnTakimGuncelle.Click += new System.EventHandler(this.btnTakimGuncelle_Click);
            // 
            // btnTemizle
            // 
            this.btnTemizle.BackColor = System.Drawing.Color.DarkOrange;
            this.btnTemizle.Location = new System.Drawing.Point(22, 176);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(88, 35);
            this.btnTemizle.TabIndex = 3;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = false;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // btnFutbolcuDetay
            // 
            this.btnFutbolcuDetay.BackColor = System.Drawing.Color.DarkOrange;
            this.btnFutbolcuDetay.Location = new System.Drawing.Point(567, 21);
            this.btnFutbolcuDetay.Name = "btnFutbolcuDetay";
            this.btnFutbolcuDetay.Size = new System.Drawing.Size(88, 35);
            this.btnFutbolcuDetay.TabIndex = 4;
            this.btnFutbolcuDetay.Text = "Futbolcu Detay";
            this.btnFutbolcuDetay.UseVisualStyleBackColor = false;
            this.btnFutbolcuDetay.Click += new System.EventHandler(this.btnFutbolcuDetay_Click);
            // 
            // dgvTakim
            // 
            this.dgvTakim.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTakim.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTakim.Location = new System.Drawing.Point(164, 112);
            this.dgvTakim.Name = "dgvTakim";
            this.dgvTakim.Size = new System.Drawing.Size(491, 224);
            this.dgvTakim.TabIndex = 5;
            this.dgvTakim.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTakim_CellDoubleClick);
            // 
            // lblTakimAdi
            // 
            this.lblTakimAdi.AutoSize = true;
            this.lblTakimAdi.BackColor = System.Drawing.Color.OrangeRed;
            this.lblTakimAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTakimAdi.Location = new System.Drawing.Point(223, 53);
            this.lblTakimAdi.Name = "lblTakimAdi";
            this.lblTakimAdi.Size = new System.Drawing.Size(61, 15);
            this.lblTakimAdi.TabIndex = 6;
            this.lblTakimAdi.Text = "Takım Adı";
            // 
            // lblKupaSayisi
            // 
            this.lblKupaSayisi.AutoSize = true;
            this.lblKupaSayisi.BackColor = System.Drawing.Color.OrangeRed;
            this.lblKupaSayisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKupaSayisi.Location = new System.Drawing.Point(213, 82);
            this.lblKupaSayisi.Name = "lblKupaSayisi";
            this.lblKupaSayisi.Size = new System.Drawing.Size(71, 15);
            this.lblKupaSayisi.TabIndex = 7;
            this.lblKupaSayisi.Text = "Kupa Sayısı";
            // 
            // lblTakimID
            // 
            this.lblTakimID.AutoSize = true;
            this.lblTakimID.BackColor = System.Drawing.Color.OrangeRed;
            this.lblTakimID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTakimID.Location = new System.Drawing.Point(228, 21);
            this.lblTakimID.Name = "lblTakimID";
            this.lblTakimID.Size = new System.Drawing.Size(56, 15);
            this.lblTakimID.TabIndex = 8;
            this.lblTakimID.Text = "Takım ID";
            // 
            // txtTakimID
            // 
            this.txtTakimID.Location = new System.Drawing.Point(290, 18);
            this.txtTakimID.Name = "txtTakimID";
            this.txtTakimID.Size = new System.Drawing.Size(100, 20);
            this.txtTakimID.TabIndex = 9;
            // 
            // txtTakimAdi
            // 
            this.txtTakimAdi.Location = new System.Drawing.Point(290, 50);
            this.txtTakimAdi.Name = "txtTakimAdi";
            this.txtTakimAdi.Size = new System.Drawing.Size(100, 20);
            this.txtTakimAdi.TabIndex = 10;
            // 
            // txtKupaSayisi
            // 
            this.txtKupaSayisi.Location = new System.Drawing.Point(290, 79);
            this.txtKupaSayisi.Name = "txtKupaSayisi";
            this.txtKupaSayisi.Size = new System.Drawing.Size(100, 20);
            this.txtKupaSayisi.TabIndex = 11;
            // 
            // FormTakimlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 363);
            this.Controls.Add(this.txtKupaSayisi);
            this.Controls.Add(this.txtTakimAdi);
            this.Controls.Add(this.txtTakimID);
            this.Controls.Add(this.lblTakimID);
            this.Controls.Add(this.lblKupaSayisi);
            this.Controls.Add(this.lblTakimAdi);
            this.Controls.Add(this.dgvTakim);
            this.Controls.Add(this.btnFutbolcuDetay);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.btnTakimGuncelle);
            this.Controls.Add(this.btnTakimSil);
            this.Controls.Add(this.btnTakimEkle);
            this.Name = "FormTakimlar";
            this.Text = "Takım Detay";
            this.Load += new System.EventHandler(this.FormTakimlar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTakim)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTakimEkle;
        private System.Windows.Forms.Button btnTakimSil;
        private System.Windows.Forms.Button btnTakimGuncelle;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Button btnFutbolcuDetay;
        private System.Windows.Forms.DataGridView dgvTakim;
        private System.Windows.Forms.Label lblTakimAdi;
        private System.Windows.Forms.Label lblKupaSayisi;
        private System.Windows.Forms.Label lblTakimID;
        private System.Windows.Forms.TextBox txtTakimID;
        private System.Windows.Forms.TextBox txtTakimAdi;
        private System.Windows.Forms.TextBox txtKupaSayisi;
    }
}