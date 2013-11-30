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
    public partial class NotForm : Form
    {
        public NotForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
       
        public void NotEkle()
        {
           Not not = new Not();

            not.Vize1 = Convert.ToInt32(txtVize1.Text.Trim());
            not.Vize2 = Convert.ToInt32(txtVize2.Text.Trim());
            not.Final = Convert.ToInt32(txtFinal.Text.Trim());

            NotBL.NotEkle(not);
            
            
        }
        private void btn_NotEkle_Click(object sender, EventArgs e)
        {
            NotEkle();
        }
    }
}
