using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Futbol_BLL;
using Futbol_Model;

namespace Futbol_Uygulama
{
    public partial class FormFutbolcular : Form
    {
        public FormFutbolcular()
        {
            InitializeComponent();
        }
        BLL bll;
        private void Form1_Load(object sender, EventArgs e)
        {
            bll = new BLL();
            //FutbolcularinMevkileriListele();
            //FutbolcuListele();
            TakimListele();
            MevkileriListele();
        }

        private void FutbolcularinMevkileriListele()
        {
            dgvFutbol.DataSource = bll.TumFutbolcularınMevkileri();
        }

        private void MevkileriListele()
        {
            cbxFutbolcuMevki.DataSource = bll.TumMevkiler();
            cbxFutbolcuMevki.DisplayMember = "MevkiAd";
            cbxFutbolcuMevki.ValueMember = "MevkiID";
        }

        private void TakimListele()
        {
            cbxFutbolcuTakim.DataSource = bll.TumTakımlar();
            cbxFutbolcuTakim.DisplayMember = "TakimAd";
            cbxFutbolcuTakim.ValueMember = "TakimID";
        }

        private void btnFutbolcuListe_Click(object sender, EventArgs e)
        {
            FutbolcuListele();
        }

        private void FutbolcuListele()
        {
            dgvFutbol.DataSource = bll.TumFutbolcular();
        }

        private void btnTakimaGore_Click(object sender, EventArgs e)
        {
            dgvFutbol.DataSource = bll.TakimaAitFutbolcular(int.Parse(txtTakimaGore.Text));
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Futbolcu futbolcu = FutbolcuEkle();           
            bll.Ekle(futbolcu);
            FutbolcuListele();

        }

        private Futbolcu FutbolcuEkle()
        {
            Futbolcu futbolcu = new Futbolcu();

            futbolcu.FutbolcuAd = txtFutbolcuAd.Text;
            futbolcu.FutbolcuSoyad = txtFutbolcuSoyad.Text;
            futbolcu.FutbolcuYas = Convert.ToByte(txtFutbolcuYas.Text);
            futbolcu.FutbolcuYetenek = Convert.ToByte(txtFutbolcuYetenek.Text);
            futbolcu.FutbolcuDeger = Convert.ToDecimal(txtFutbolcuDeger.Text);
            futbolcu.TakimID = (int)cbxFutbolcuTakim.SelectedValue;

            return futbolcu;
        }
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Futbolcu futbolcu = FutbolcuEkle();
            futbolcu.FutbolcuID = int.Parse(txtFutbolcuID.Text);
            bll.Guncelle(futbolcu);
            FutbolcuListele();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            bll.Sil(Convert.ToInt32(txtFutbolcuID.Text));
            FutbolcuListele();

        }

        private void dgvFutbolcular_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtFutbolcuID.Text = dgvFutbol.CurrentRow.Cells[0].Value.ToString();
            txtFutbolcuAd.Text = dgvFutbol.CurrentRow.Cells[1].Value.ToString();
            txtFutbolcuSoyad.Text = dgvFutbol.CurrentRow.Cells[2].Value.ToString();
            txtFutbolcuYas.Text = dgvFutbol.CurrentRow.Cells[3].Value.ToString();
            txtFutbolcuYetenek.Text = dgvFutbol.CurrentRow.Cells[4].Value.ToString();
            txtFutbolcuDeger.Text = dgvFutbol.CurrentRow.Cells[5].Value.ToString();
            cbxFutbolcuTakim.Text = dgvFutbol.CurrentRow.Cells[6].Value.ToString();
            

        }

        private void btnTakimlarListe_Click(object sender, EventArgs e)
        {
            dgvFutbol.DataSource = bll.TumTakımlar();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {

            foreach (Control control in this.Controls)
            {
                if (control is TextBox)
                    ((TextBox)control).Text = "";
            }
        }

        private void btnTakimSayfasi_Click(object sender, EventArgs e)
        {
            FormTakimlar formTakimlar = new FormTakimlar();
            formTakimlar.Show();
        }
    }
}
