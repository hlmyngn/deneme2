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
    public partial class OgrenciDersleriForm : Form
    {
        Ogrenci _ogrenci = null;


        public OgrenciDersleriForm(Ogrenci ogrenci)
        {
            InitializeComponent();
            _ogrenci = ogrenci;
            UIDegerleriniVer();
            DersGetir();
            SecilenDersiGetir();
        }

        public void OgrenciDersleriGetir()
        {
            List<Ders> dersler = DersBL.DersGetir();
            dgvDersListesi.DataSource = dersler;
         }

        private void UIDegerleriniVer()
        {
            if (_ogrenci != null)
            {
               string adSoyad =  String.Format("{0} {1}",_ogrenci.Adi, _ogrenci.Soyadi);
               lblOgrenciAdi.Text = adSoyad;
            }
        }

        public void DersGetir()
        {
            List<Ders> dersler = DersBL.DersGetir();
            dgvDersListesi.DataSource = dersler;
        }
        public void SecilenDersiGetir() {

            List<OgrenciDersleri> ogrenciDersleri = OgrenciBL.OgrenciDersGetir(_ogrenci);
            dgvSeciliDersListesi.DataSource = ogrenciDersleri;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ders secilenDers = dgvDersListesi.SelectedRows[0].DataBoundItem as Ders;
            if (secilenDers != null)
            {
                OgrenciDersleri yeniDers = new OgrenciDersleri();
                yeniDers.Ogrenci = _ogrenci;
                yeniDers.Ders = secilenDers;
                OgrenciBL.OgrenciDersEkle(yeniDers);
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {

        }

    }
}
