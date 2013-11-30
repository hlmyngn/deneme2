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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

        }

        private void miOgrenciEkleGuncelle_Click_1(object sender, EventArgs e)
        {
            OgrenciForm ogrenciForm = new OgrenciForm();
            ogrenciForm.ShowDialog();
        }

        private void miDersEkleGüncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DersEkle dersEkle = new DersEkle();
            dersEkle.ShowDialog();

        }

        private void miNotEkleGüncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NotForm notForm = new NotForm();
            notForm.ShowDialog();
        }
    }
}
