using Gural.Staj.Egitim.MySql.BL;
using Gural.Staj.Egitim.MySql.DAL;
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
    public partial class DersEkle : Form
    {
        public DersEkle()
        {
            InitializeComponent();
            DersGetir();

        }
        public void DersGetir()
        {
            List<Ders> dersler = DersBL.DersGetir();
            dgvDersGöster.DataSource = dersler;

        }
        public void Ders_Ekle()
        {
            Ders ders= new Ders();

            ders.DersAdi = txtDersAdi.Text.Trim();
          
            DersBL.DersEkle(ders);

            
            DersGetir();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Ders_Ekle();
            
        }
    }
}
