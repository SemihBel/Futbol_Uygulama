using Futbol_BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Futbol_Model;

namespace Futbol_Uygulama
{
    public partial class FormTakimlar : Form
    {
        public FormTakimlar()
        {
            InitializeComponent();
        }
        BLL bll;
        private void FormTakimlar_Load(object sender, EventArgs e)
        {
            bll = new BLL();
            TakimListele();
        }

        private void btnFutbolcuDetay_Click(object sender, EventArgs e)
        {
            FormFutbolcular formFutbolcular = new FormFutbolcular();
            formFutbolcular.Show();
        }
        private void TakimListele()
        {
            dgvTakim.DataSource = bll.TumTakımlar();
        }
        private Takim TakimEkle()
        {
            Takim takim = new Takim();

            takim.TakimAd = txtTakimAdi.Text;
            takim.TakimKupa =Convert.ToByte(txtKupaSayisi.Text);
            

            return takim;
        }

        private void btnTakimEkle_Click(object sender, EventArgs e)
        {
            Takim takim = TakimEkle();
            bll.TakimEkle(takim);
            TakimListele();

        }

        private void btnTakimGuncelle_Click(object sender, EventArgs e)
        {
            Takim takim = TakimEkle();
            takim.TakimID= int.Parse(txtTakimID.Text);
            bll.TakimGuncelle(takim);
            TakimListele();
        }

        private void btnTakimSil_Click(object sender, EventArgs e)
        {
            bll.TakimSil(Convert.ToInt32(txtTakimID.Text));
            TakimListele();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            foreach (Control control in this.Controls)
            {
                if (control is TextBox)
                    ((TextBox)control).Text = "";
            }
        }

        private void dgvTakim_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtTakimID.Text = dgvTakim.CurrentRow.Cells[0].Value.ToString();
            txtTakimAdi.Text = dgvTakim.CurrentRow.Cells[1].Value.ToString();
            txtKupaSayisi.Text = dgvTakim.CurrentRow.Cells[2].Value.ToString();
        }
    }
}
