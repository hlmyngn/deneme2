using Gural.Staj.Egitim.MySql.BL;
using Gural.Staj.Egitim.MySql.DAL;
using Gural.Staj.Egitim.MySql.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gural.Staj.Egitim.MySql.UI
{
    public partial class OgrenciForm : Form
    {
        Ogrenci secilenOgrenci = null;
        public OgrenciForm()
        {
            InitializeComponent();
            OgrencileriGetir();
        }

        public void  Ekle()
        {
            Ogrenci ogrenci = new Ogrenci();
            
            ogrenci.Adi = txtAdi.Text.Trim();
            ogrenci.Soyadi = txtSoyadi.Text.Trim();
            OgrenciBL.OgrenciEkle(ogrenci);

            OgrencileriGetir();
        }   
        public void OgrencileriGetir()
        {
            List<Ogrenci> ogrenciler = OgrenciBL.OgrencileriGetir();
            dgvOgrenciler.DataSource = ogrenciler;
    
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ekle();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (secilenOgrenci != null)
            {
                secilenOgrenci.Adi = txtAdi.Text.Trim();
                secilenOgrenci.Soyadi = txtSoyadi.Text.Trim();
                OgrenciBL.OgrenciEkle(secilenOgrenci);
            }

            OgrencileriGetir();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if(secilenOgrenci != null)
            OgrenciBL.OgrenciSil(secilenOgrenci);
            OgrencileriGetir();
        }

        private void dgvOgrenciler_MouseClick(object sender, MouseEventArgs e)
        {
            secilenOgrenci = dgvOgrenciler.SelectedRows[0].DataBoundItem as Ogrenci;
        }

        private void dgvOgrenciler_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            secilenOgrenci = dgvOgrenciler.SelectedRows[0].DataBoundItem as Ogrenci;

            if (secilenOgrenci != null)
            {
                txtAdi.Text = secilenOgrenci.Adi;
                txtSoyadi.Text = secilenOgrenci.Soyadi;
            }
        }

        private void btn_NotEkle_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            
            secilenOgrenci = dgvOgrenciler.SelectedRows[0].DataBoundItem as Ogrenci;
            if (secilenOgrenci != null)
            {
                OgrenciDersleriForm ogrencidersleri = new OgrenciDersleriForm(secilenOgrenci);
                
                ogrencidersleri.ShowDialog();
            }
        }
    }
}
