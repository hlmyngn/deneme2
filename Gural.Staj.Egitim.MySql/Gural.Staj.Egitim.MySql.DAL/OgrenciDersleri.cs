using Gural.Staj.Egitim.MySql.DAL;
using Gural.Staj.Egitim.MySql.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gural.Staj.Egitim.MySql.BL
{
    public class OgrenciDersleri
    {
        public int Id { get; set; }
        public Ogrenci Ogrenci { get; set; }
        public Ders Ders { get; set; }
    }
}
