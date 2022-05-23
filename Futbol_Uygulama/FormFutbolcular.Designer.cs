namespace Futbol_Uygulama
{
    partial class FormFutbolcular
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
            this.btnFutbolcuListe = new System.Windows.Forms.Button();
            this.btnTakimaGore = new System.Windows.Forms.Button();
            this.txtTakimaGore = new System.Windows.Forms.TextBox();
            this.dgvFutbol = new System.Windows.Forms.DataGridView();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtFutbolcuID = new System.Windows.Forms.TextBox();
            this.txtFutbolcuAd = new System.Windows.Forms.TextBox();
            this.txtFutbolcuSoyad = new System.Windows.Forms.TextBox();
            this.txtFutbolcuYas = new System.Windows.Forms.TextBox();
            this.txtFutbolcuYetenek = new System.Windows.Forms.TextBox();
            this.txtFutbolcuDeger = new System.Windows.Forms.TextBox();
            this.cbxFutbolcuTakim = new System.Windows.Forms.ComboBox();
            this.cbxFutbolcuMevki = new System.Windows.Forms.ComboBox();
            this.btnTakimlarListe = new System.Windows.Forms.Button();
            this.btnTakimSayfasi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFutbol)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFutbolcuListe
            // 
            this.btnFutbolcuListe.BackColor = System.Drawing.Color.Yellow;
            this.btnFutbolcuListe.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnFutbolcuListe.Location = new System.Drawing.Point(602, 12);
            this.btnFutbolcuListe.Name = "btnFutbolcuListe";
            this.btnFutbolcuListe.Size = new System.Drawing.Size(145, 37);
            this.btnFutbolcuListe.TabIndex = 0;
            this.btnFutbolcuListe.Text = "Futbolcular Liste";
            this.btnFutbolcuListe.UseVisualStyleBackColor = false;
            this.btnFutbolcuListe.Click += new System.EventHandler(this.btnFutbolcuListe_Click);
            // 
            // btnTakimaGore
            // 
            this.btnTakimaGore.BackColor = System.Drawing.Color.Yellow;
            this.btnTakimaGore.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnTakimaGore.Location = new System.Drawing.Point(602, 55);
            this.btnTakimaGore.Name = "btnTakimaGore";
            this.btnTakimaGore.Size = new System.Drawing.Size(145, 37);
            this.btnTakimaGore.TabIndex = 1;
            this.btnTakimaGore.Text = "Takıma Göre";
            this.btnTakimaGore.UseVisualStyleBackColor = false;
            this.btnTakimaGore.Click += new System.EventHandler(this.btnTakimaGore_Click);
            // 
            // txtTakimaGore
            // 
            this.txtTakimaGore.Location = new System.Drawing.Point(496, 64);
            this.txtTakimaGore.Name = "txtTakimaGore";
            this.txtTakimaGore.Size = new System.Drawing.Size(100, 20);
            this.txtTakimaGore.TabIndex = 2;
            // 
            // dgvFutbol
            // 
            this.dgvFutbol.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFutbol.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFutbol.Location = new System.Drawing.Point(114, 255);
            this.dgvFutbol.Name = "dgvFutbol";
            this.dgvFutbol.Size = new System.Drawing.Size(612, 238);
            this.dgvFutbol.TabIndex = 3;
            this.dgvFutbol.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFutbolcular_CellDoubleClick);
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.Color.Yellow;
            this.btnEkle.Location = new System.Drawing.Point(12, 13);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(83, 36);
            this.btnEkle.TabIndex = 4;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.Color.Yellow;
            this.btnGuncelle.Location = new System.Drawing.Point(12, 56);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(83, 36);
            this.btnGuncelle.TabIndex = 5;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.Yellow;
            this.btnSil.Location = new System.Drawing.Point(12, 98);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(83, 36);
            this.btnSil.TabIndex = 6;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnTemizle
            // 
            this.btnTemizle.BackColor = System.Drawing.Color.Yellow;
            this.btnTemizle.Location = new System.Drawing.Point(12, 143);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(83, 36);
            this.btnTemizle.TabIndex = 8;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = false;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Yellow;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(184, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Futbolcu ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Yellow;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(234, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Ad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Yellow;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(211, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Soyad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Yellow;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(227, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "Yaş";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Yellow;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(213, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "Takım";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Yellow;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(215, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 16);
            this.label6.TabIndex = 14;
            this.label6.Text = "Mevki";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Yellow;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(201, 153);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 16);
            this.label7.TabIndex = 15;
            this.label7.Text = "Yetenek";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Yellow;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(213, 178);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 16);
            this.label8.TabIndex = 16;
            this.label8.Text = "Değer";
            // 
            // txtFutbolcuID
            // 
            this.txtFutbolcuID.Location = new System.Drawing.Point(275, 18);
            this.txtFutbolcuID.Name = "txtFutbolcuID";
            this.txtFutbolcuID.Size = new System.Drawing.Size(100, 20);
            this.txtFutbolcuID.TabIndex = 17;
            // 
            // txtFutbolcuAd
            // 
            this.txtFutbolcuAd.Location = new System.Drawing.Point(275, 41);
            this.txtFutbolcuAd.Name = "txtFutbolcuAd";
            this.txtFutbolcuAd.Size = new System.Drawing.Size(100, 20);
            this.txtFutbolcuAd.TabIndex = 18;
            // 
            // txtFutbolcuSoyad
            // 
            this.txtFutbolcuSoyad.Location = new System.Drawing.Point(275, 62);
            this.txtFutbolcuSoyad.Name = "txtFutbolcuSoyad";
            this.txtFutbolcuSoyad.Size = new System.Drawing.Size(100, 20);
            this.txtFutbolcuSoyad.TabIndex = 19;
            // 
            // txtFutbolcuYas
            // 
            this.txtFutbolcuYas.Location = new System.Drawing.Point(275, 85);
            this.txtFutbolcuYas.Name = "txtFutbolcuYas";
            this.txtFutbolcuYas.Size = new System.Drawing.Size(100, 20);
            this.txtFutbolcuYas.TabIndex = 20;
            // 
            // txtFutbolcuYetenek
            // 
            this.txtFutbolcuYetenek.Location = new System.Drawing.Point(275, 153);
            this.txtFutbolcuYetenek.Name = "txtFutbolcuYetenek";
            this.txtFutbolcuYetenek.Size = new System.Drawing.Size(100, 20);
            this.txtFutbolcuYetenek.TabIndex = 21;
            // 
            // txtFutbolcuDeger
            // 
            this.txtFutbolcuDeger.Location = new System.Drawing.Point(275, 177);
            this.txtFutbolcuDeger.Name = "txtFutbolcuDeger";
            this.txtFutbolcuDeger.Size = new System.Drawing.Size(100, 20);
            this.txtFutbolcuDeger.TabIndex = 22;
            // 
            // cbxFutbolcuTakim
            // 
            this.cbxFutbolcuTakim.FormattingEnabled = true;
            this.cbxFutbolcuTakim.Location = new System.Drawing.Point(275, 107);
            this.cbxFutbolcuTakim.Name = "cbxFutbolcuTakim";
            this.cbxFutbolcuTakim.Size = new System.Drawing.Size(100, 21);
            this.cbxFutbolcuTakim.TabIndex = 23;
            // 
            // cbxFutbolcuMevki
            // 
            this.cbxFutbolcuMevki.FormattingEnabled = true;
            this.cbxFutbolcuMevki.Location = new System.Drawing.Point(275, 129);
            this.cbxFutbolcuMevki.Name = "cbxFutbolcuMevki";
            this.cbxFutbolcuMevki.Size = new System.Drawing.Size(100, 21);
            this.cbxFutbolcuMevki.TabIndex = 24;
            // 
            // btnTakimlarListe
            // 
            this.btnTakimlarListe.BackColor = System.Drawing.Color.Yellow;
            this.btnTakimlarListe.Location = new System.Drawing.Point(602, 99);
            this.btnTakimlarListe.Name = "btnTakimlarListe";
            this.btnTakimlarListe.Size = new System.Drawing.Size(145, 35);
            this.btnTakimlarListe.TabIndex = 25;
            this.btnTakimlarListe.Text = "Takımlar Liste";
            this.btnTakimlarListe.UseVisualStyleBackColor = false;
            this.btnTakimlarListe.Click += new System.EventHandler(this.btnTakimlarListe_Click);
            // 
            // btnTakimSayfasi
            // 
            this.btnTakimSayfasi.BackColor = System.Drawing.Color.Yellow;
            this.btnTakimSayfasi.Location = new System.Drawing.Point(624, 143);
            this.btnTakimSayfasi.Name = "btnTakimSayfasi";
            this.btnTakimSayfasi.Size = new System.Drawing.Size(102, 49);
            this.btnTakimSayfasi.TabIndex = 26;
            this.btnTakimSayfasi.Text = "Takım Detay";
            this.btnTakimSayfasi.UseVisualStyleBackColor = false;
            this.btnTakimSayfasi.Click += new System.EventHandler(this.btnTakimSayfasi_Click);
            // 
            // FormFutbolcular
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(759, 514);
            this.Controls.Add(this.btnTakimSayfasi);
            this.Controls.Add(this.btnTakimlarListe);
            this.Controls.Add(this.cbxFutbolcuMevki);
            this.Controls.Add(this.cbxFutbolcuTakim);
            this.Controls.Add(this.txtFutbolcuDeger);
            this.Controls.Add(this.txtFutbolcuYetenek);
            this.Controls.Add(this.txtFutbolcuYas);
            this.Controls.Add(this.txtFutbolcuSoyad);
            this.Controls.Add(this.txtFutbolcuAd);
            this.Controls.Add(this.txtFutbolcuID);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.dgvFutbol);
            this.Controls.Add(this.txtTakimaGore);
            this.Controls.Add(this.btnTakimaGore);
            this.Controls.Add(this.btnFutbolcuListe);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "FormFutbolcular";
            this.Text = "Futbolcu Detay";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFutbol)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFutbolcuListe;
        private System.Windows.Forms.Button btnTakimaGore;
        private System.Windows.Forms.TextBox txtTakimaGore;
        private System.Windows.Forms.DataGridView dgvFutbol;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtFutbolcuID;
        private System.Windows.Forms.TextBox txtFutbolcuAd;
        private System.Windows.Forms.TextBox txtFutbolcuSoyad;
        private System.Windows.Forms.TextBox txtFutbolcuYas;
        private System.Windows.Forms.TextBox txtFutbolcuYetenek;
        private System.Windows.Forms.TextBox txtFutbolcuDeger;
        private System.Windows.Forms.ComboBox cbxFutbolcuTakim;
        private System.Windows.Forms.ComboBox cbxFutbolcuMevki;
        private System.Windows.Forms.Button btnTakimlarListe;
        private System.Windows.Forms.Button btnTakimSayfasi;
    }
}

